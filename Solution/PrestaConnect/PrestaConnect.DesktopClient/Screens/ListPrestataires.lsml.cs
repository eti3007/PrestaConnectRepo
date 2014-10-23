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
    public partial class ListPrestataires
    {
        partial void Prestataires_SelectionChanged()
        {
            if (this.Prestataires.SelectedItem != null && !string.IsNullOrEmpty(this.Prestataires.SelectedItem.Localisation1.UrlBingMapImage))
            {
                this.UrlBingMapImageParameter = this.Prestataires.SelectedItem.Localisation1.UrlBingMapImage;                
            }
        }

        partial void PrestataireListAddAndEditNew_Execute()
        {
            // Write your code here.
            Application.Current.ShowCreateNewPrestataire(null);
        }

        partial void PrestataireListEditSelected_Execute()
        {
            // Write your code here.
            Application.Current.ShowCreateNewPrestataire(this.Prestataires.SelectedItem.Id);
        }
    }
}
