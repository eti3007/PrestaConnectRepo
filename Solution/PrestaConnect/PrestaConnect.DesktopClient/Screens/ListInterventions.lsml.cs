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
    public partial class ListInterventions
    {
        partial void Interventions_SelectionChanged()
        {
            if (this.Interventions.SelectedItem != null && !string.IsNullOrEmpty(this.Interventions.SelectedItem.Client1.Localisation1.UrlBingMapImage))
            {
                this.UrlBingMapImageParameter = this.Interventions.SelectedItem.Client1.Localisation1.UrlBingMapImage;
            }
        }

        partial void InterventionListAddAndEditNew_Execute()
        {
            // Write your code here.
            Application.Current.ShowCreateNewIntervention(null);
        }

        partial void InterventionListEditSelected_Execute()
        {
            // Write your code here.
            Application.Current.ShowCreateNewIntervention(this.Interventions.SelectedItem.Id);
        }
    }
}
