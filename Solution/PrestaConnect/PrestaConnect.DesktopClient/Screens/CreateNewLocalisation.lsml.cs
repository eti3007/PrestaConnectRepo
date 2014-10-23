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
        partial void CreateNewLocalisation_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            if (LocalisationId.HasValue)
            {
                this.LocalisationProperty = this.DataWorkspace.DBPrestaConnectData.Localisations_Single(LocalisationId.Value);
                this.DisplayName = "Edit Localisation";
                SearchCoordinate_Execute();
            }
            else this.LocalisationProperty = new Localisation();
        }

        partial void CreateNewLocalisation_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowListLocalisation();
        }

        partial void SearchCoordinate_Execute()
        {
            string BingMapKey = "Ap8vn7IzLQYLvWDz33AcQQ6sBS51ik7_CLlLSYnok4NAE3KuM6RgPZDU1HoS3LGE";

            if (!string.IsNullOrEmpty(this.LocalisationProperty.AdresseComplete) &&
                !string.IsNullOrWhiteSpace(this.LocalisationProperty.AdresseComplete))
            {
                string key = BingMapKey;
                HttpBingMap objBing = new HttpBingMap(key, this.LocalisationProperty.AdresseComplete);
                var Coord = objBing.GetCoordonnees();

                if (Coord != null && Coord.Length == 2)
                {
                    this.LocalisationProperty.Latitude = Coord[0].Substring(0, Coord[0].Length > 9 ? 9 : Coord[0].Length);
                    this.LocalisationProperty.Longitude = Coord[1].Substring(0, Coord[1].Length > 10 ? 10 : Coord[1].Length);
                }
            }

            if (this.LocalisationProperty != null && !string.IsNullOrEmpty(this.LocalisationProperty.UrlBingMapImage))
            {
                this.UrlBingMapImageParameter = this.LocalisationProperty.UrlBingMapImage;
            }
        }
    }
}