using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using System.IO;
using System.Text;
using System.Threading;

namespace LightSwitchApplication
{
    public class HttpBingMap
    {
        public class RequestState
        {
            // This class stores the State of the request.
            const int BUFFER_SIZE = 1024;
            public StringBuilder requestData;
            public byte[] BufferRead;
            public HttpWebRequest request;
            public HttpWebResponse response;
            public Stream streamResponse;
            public RequestState()
            {
                BufferRead = new byte[BUFFER_SIZE];
                requestData = new StringBuilder("");
                request = null;
                streamResponse = null;
            }
        }
        
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        const int BUFFER_SIZE = 1024;
        const int DefaultTimeout = 2 * 60 * 1000; // 2 minutes timeout
        const string Url = @"http://dev.virtualearth.net/REST/v1/Locations?q={0}&key={1}";
        const string CoordinatePosition = "\"coordinates\":[";

        // Abort the request if the timer fires.
        private static void TimeoutCallback(object state, bool timedOut)
        {
            if (timedOut)
            {
                HttpWebRequest request = state as HttpWebRequest;
                if (request != null)
                {
                    request.Abort();
                }
            }
        }

        public string Key { get; set; }
        public string Query { get; set; }
        public string ResponseData { get; set; }

        public HttpBingMap(string key, string query) { this.Key = key; this.Query = query; }


        public string[] GetCoordonnees()
        {
            this.GetResponse();

            if (this.ResponseData.StartsWith("Erreur")) return null;
            else {
                int posA = this.ResponseData.IndexOf(CoordinatePosition) + CoordinatePosition.Length;
                int posB = this.ResponseData.Substring(posA).IndexOf("]") + posA;
                string[] coord = this.ResponseData.Substring(posA, (posB - posA)).Split(Convert.ToChar(","));
                if (coord.Length == 2) return coord;
                else return null;
            }
        }

        private void GetResponse()
        {
            try
            {
                // Create a HttpWebrequest object to the desired URL. 
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(string.Format(Url, Query, Key)));
                
                // Create an instance of the RequestState and assign the previous myHttpWebRequest
                // object to its request field.  
                RequestState myRequestState = new RequestState();
                myRequestState.request = myHttpWebRequest;
                
                // Start the asynchronous request.
                IAsyncResult result = (IAsyncResult)myHttpWebRequest.BeginGetResponse(new AsyncCallback(RespCallback), myRequestState);
                
                // The response came in the allowed time. The work processing will happen in the 
                // callback function.
                allDone.WaitOne();

                // Release the HttpWebResponse resource.
                myRequestState.response.Close();
            }
            catch (WebException e)
            {
                this.ResponseData = "Erreur GetResponse - WebException: " + e.Message;
            }
            catch (Exception e)
            {
                this.ResponseData = "Erreur GetResponse - Exception: " + e.Message;
            }
        }

        private void RespCallback(IAsyncResult asynchronousResult)
        {
            try
            {
                // State of request is asynchronous.
                RequestState myRequestState = (RequestState)asynchronousResult.AsyncState;
                HttpWebRequest myHttpWebRequest = myRequestState.request;
                myRequestState.response = (HttpWebResponse)myHttpWebRequest.EndGetResponse(asynchronousResult);

                // Read the response into a Stream object.
                Stream responseStream = myRequestState.response.GetResponseStream();
                myRequestState.streamResponse = responseStream;

                // Begin the Reading of the contents of the HTML page and print it to the console.
                IAsyncResult asynchronousInputRead = responseStream.BeginRead(myRequestState.BufferRead, 0, BUFFER_SIZE, new AsyncCallback(ReadCallBack), myRequestState);
                return;
            }
            catch (WebException e)
            {
                this.ResponseData = "Erreur RespCallback - WebException: " + e.Message;
            }
            allDone.Set();
        }

        private void ReadCallBack(IAsyncResult asyncResult)
        {
            try
            {

                RequestState myRequestState = (RequestState)asyncResult.AsyncState;
                Stream responseStream = myRequestState.streamResponse;
                int read = responseStream.EndRead(asyncResult);
                // Read the HTML page and then print it to the console.
                if (read > 0)
                {
                    myRequestState.requestData.Append(Encoding.UTF8.GetString(myRequestState.BufferRead, 0, read));
                    IAsyncResult asynchronousResult = responseStream.BeginRead(myRequestState.BufferRead, 0, BUFFER_SIZE, new AsyncCallback(ReadCallBack), myRequestState);
                    return;
                }
                else
                {
                    this.ResponseData += "\nThe contents of the Html page are : ";
                    if (myRequestState.requestData.Length > 1)
                    {
                        string stringContent;
                        stringContent = myRequestState.requestData.ToString();
                        this.ResponseData += stringContent;
                    }

                    responseStream.Close();
                }

            }
            catch (WebException e)
            {
                this.ResponseData = "Erreur ReadCallBack - WebException: " + e.Message;
            }
            allDone.Set();

        }
    }
}
