using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class CreateNewClient
    {
        partial void CreateNewClient_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            if (this.ClientId.HasValue)
            {
                this.ClientProperty = this.DataWorkspace.DBPrestaConnectData.Clients_Single(this.ClientId.Value);
                this.DisplayName = "Edit Client";
            }
            else {
                this.ClientProperty = new Client();
            }
        }

        partial void CreateNewClient_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowListClient();
        }
    }
}