using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public class TraducteurRechercheExtrant
    {
        public override WCFC_Recherche.RechercheExtrant  TraduireEntiteEnDataContract(List<LC_ENT.ReponseRechercheCafe>  entite)
        {
   

            WCFC_Recherche.RechercheExtrant RetourDC = new WCFC_Recherche.RechercheExtrant();
        Dim traducteurRechTP As New E8_SV.Implementation.TraducteurRechercherTP()
        WCFC_Recherche.RechercheRetour resultatRechercheTpDC = new WCFC_Recherche.RechercheRetour(); 

        if (entite != null) {
            //If entite. .Reponse IsNot Nothing Then
                foreach (LC_ENT.ReponseRechercheCafe reponse in  entite){
                    resultatRechercheTpDC = traducteurRechTP.TraduireEntiteEnDataContract(reponse);
                    RetourDC.ListeResultatRechercheTP.Add(resultatRechercheTpDC);
                }
            //End If
        }
            return RetourDC;
        }


        public override LC_ENT.CoffeeEntite TraduireDataContractEnEntite(WCFC_Recherche.RechercheIntrant dc)
        {
            //Retourne nothing pour des fins de test
            return null;

            
        }
    }
}
