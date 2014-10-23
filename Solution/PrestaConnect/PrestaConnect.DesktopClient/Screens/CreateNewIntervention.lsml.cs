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
    public partial class CreateNewIntervention
    {
        partial void CreateNewIntervention_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            if (this.InterventionId.HasValue)
            {
                this.InterventionProperty = this.DataWorkspace.DBPrestaConnectData.Interventions_Single(this.InterventionId.Value);
                this.DisplayName = "Edit Client";
            } else this.InterventionProperty = new Intervention();
        }

        partial void CreateNewIntervention_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowListInterventions();
        }
    }
}