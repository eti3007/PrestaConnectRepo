using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;

namespace LightSwitchApplication
{
    public partial class Localisation
    {

        partial void Longitude_Changed()
        {
            
        }

        partial void UrlBingMapImage_Compute(ref string result)
        {
            string BingMapKey = "Ap8vn7IzLQYLvWDz33AcQQ6sBS51ik7_CLlLSYnok4NAE3KuM6RgPZDU1HoS3LGE";

            if (!string.IsNullOrEmpty(this.Latitude) && !string.IsNullOrEmpty(this.Longitude))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("http://dev.virtualearth.net/REST/v1/Imagery/Map/Road/");
                sb.Append(this.Latitude);
                sb.Append(",");
                sb.Append(this.Longitude);
                sb.Append("/15?mapSize=350,350&pp=");
                sb.Append(this.Latitude);
                sb.Append(",");
                sb.Append(this.Longitude);
                sb.Append(";22&key=");
                sb.Append(BingMapKey);
                result = sb.ToString();
            }
        }
    }
}
