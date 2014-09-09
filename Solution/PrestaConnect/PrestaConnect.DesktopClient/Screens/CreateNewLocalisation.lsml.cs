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
    public partial class CreateNewLocalisation
    {
        partial void CreateNewLocalisation_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.LocalisationProperty = new Localisation();
        }

        partial void CreateNewLocalisation_Saved()
        {
            string key = "AhspMjoAQNhoVJsWeV1mh6M2WBL5m_vYakI5qLXrXoR6vu5DlJjvZCdvIg82aeZU";
            HttpBingMap objBing = new HttpBingMap(key, "35 bis avenue Jean Jaurès 91230 Crosne, FRANCE");
            objBing.GetResponse();



            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.LocalisationProperty);
        }
    }
}