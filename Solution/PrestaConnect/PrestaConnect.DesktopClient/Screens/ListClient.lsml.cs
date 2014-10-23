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
    public partial class ListClient
    {
        partial void Clients_SelectionChanged()
        {
            if (this.Clients.SelectedItem != null && !string.IsNullOrEmpty(this.Clients.SelectedItem.Localisation1.UrlBingMapImage))
            {
                this.UrlBingMapImageParameter = this.Clients.SelectedItem.Localisation1.UrlBingMapImage;
            }
        }

        partial void ClientListAddAndEditNew_Execute()
        {
            // Write your code here.
            Application.ShowCreateNewClient(null);
        }

        partial void ClientListEditSelected_Execute()
        {
            // Write your code here.
            Application.ShowCreateNewClient(this.Clients.SelectedItem.Id);
        }
    }
}
