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
    public partial class CreateNewPrestataire
    {
        partial void CreateNewPrestataire_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            if (this.PrestataireId.HasValue)
            {
                this.PrestataireProperty = this.DataWorkspace.DBPrestaConnectData.Prestataires_Single(this.PrestataireId.Value);
                this.DisplayName = "Edit Prestataire";
            }
            else { this.PrestataireProperty = new Prestataire(); }
        }

        partial void CreateNewPrestataire_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowListPrestataires();
        }
    }
}