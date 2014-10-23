using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Client
    {
        partial void Localisation1_Changed()
        {
            if (this.Localisation1 != null)
            {
                this.Zone1 = null;
                var zones = this.DataWorkspace.DBPrestaConnectData.FindZoneByLocalisation(this.Localisation1.Latitude, this.Localisation1.Longitude);
                if (zones != null && zones.FirstOrDefault() != null && zones.FirstOrDefault().Id > 0)
                {
                    this.Zone1 = zones.FirstOrDefault();
                }
            }
        }
    }
}
