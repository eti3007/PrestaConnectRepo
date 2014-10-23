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
    public partial class ListLocalisation
    {
        partial void Localisations_SelectionChanged()
        {
            if (this.Localisations.SelectedItem != null && !string.IsNullOrEmpty(this.Localisations.SelectedItem.UrlBingMapImage))
            {
                this.UrlBingMapImageParameter = this.Localisations.SelectedItem.UrlBingMapImage;                
            }
        }

        partial void LocalisationListAddAndEditNew_Execute()
        {
            // Write your code here.
            Application.ShowCreateNewLocalisation(null);
        }

        partial void LocalisationListEditSelected_Execute()
        {
            // Write your code here.
            Application.ShowCreateNewLocalisation(this.Localisations.SelectedItem.Id);
        }
    }
}
