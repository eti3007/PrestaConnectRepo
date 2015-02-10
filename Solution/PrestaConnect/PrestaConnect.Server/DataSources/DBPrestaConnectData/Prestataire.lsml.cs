using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Prestataire
    {
        partial void NomPrenom_Compute(ref string result)
        {
            // Set result to the desired field value
            result = string.Format("{0} {1}", this.Nom, this.Prenom);
        }

        partial void EmailPro_Validate(EntityValidationResultsBuilder results)
        {
            // vérifie si il n'est pas déjà dans la table
            var query = this.DataWorkspace.DBPrestaConnectData.Prestataires.Where(c => c.EmailPro == this.EmailPro);
            if (query.SingleOrDefault() != null) {
                results.AddPropertyError("Cet email existe déjà pour un autre prestataire !");
            }
        }

        partial void EmailPerso_Validate(EntityValidationResultsBuilder results)
        {
            // vérifie si il n'est pas déjà dans la table
            var query = this.DataWorkspace.DBPrestaConnectData.Prestataires.Where(c => c.EmailPerso == this.EmailPerso);
            if (query.SingleOrDefault() != null) {
                results.AddPropertyError("Cet email existe déjà pour un autre prestataire !");
            }
        }
    }
}
