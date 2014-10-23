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
    public partial class CreateNewZone
    {
        partial void CreateNewZone_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            if (ZoneId.HasValue) {
                this.ZoneProperty = this.DataWorkspace.DBPrestaConnectData.Zones_Single(ZoneId.Value);
                this.DisplayName = "Edit Zone";
            }
            else this.ZoneProperty = new Zone();
        }

        partial void CreateNewZone_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowListZone();
        }

        partial void CreateLocalisationNO_Execute()
        {
            // Write your code here.
            Application.Current.ShowCreateNewLocalisation(null);
        }
    }
}