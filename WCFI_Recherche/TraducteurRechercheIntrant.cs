using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public class TraducteurRechercheIntrant
    {

        public override WCFC_Recherche.RechercheIntrant TraduireEntiteEnDataContract(LC_ENT.CoffeeEntite  reponse)
        {
            //Retourne nothing pour des fins de test
            return null;
        }


        public override LC_ENT.CoffeeEntite TraduireDataContractEnEntite(WCFC_Recherche.RechercheIntrant dc)
        {

            LC_ENT.CoffeeEntite retour = new LC_ENT.CoffeeEntite();
            retour.Id  = dc.Id ;
            
            //if (dc.DateReceptionObligation.HasValue)
            //{
            //    retour.DateReceptionObliga = dc.DateReceptionObligation;
            //}
            retour.Name = dc.Name;
            retour.Type = dc.Type;
            retour.Price = dc.Price;
            //retour.Roast = dc.Roast;
            //retour.Country = dc.Country;
            //retour.Image = dc.Image;


            return retour;
        }

    }
}
