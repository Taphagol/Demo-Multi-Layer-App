using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC_CDA
{
    public class CoffeeCDA
    {

        public LC_ENT.CoffeeEntite ObtenirInfoCoffee(LC_ENT.CoffeeEntite cofffee)
        {

            LC_ENT.CoffeeEntite reponseTP = new LC_ENT.CoffeeEntite();

            reponseTP = LC_ENTTR.CoffeeTR.GetCoffeeByType(cofffee.Type);

            return reponseTP;
        }

        public List<LC_ENT.CoffeeEntite> RechercherTP(LC_ENT.CoffeeEntite criteres)
        {

            List<LC_ENT.CoffeeEntite> reponseTP = new List<LC_ENT.CoffeeEntite>();

            reponseTP = LC_ENTTR.CoffeeTR.RechercherTP(criteres);

            return reponseTP;
        }






        //Private pour forcer les gens à passer par l'interface ITransactionPaiementCDA
        /// <summary>
        /// Obtient les details d'une transaction paiement
        /// </summary>
        /// <param name="criteres">critères de sélection qui seront validés par cette fonction</param>
        /// <returns>la transaction paiement si les critères sont valides. Le code de retour sera différent de 00 si invalide ou autres problèmes</returns>
        /// <remarks></remarks>
        //private ENTT.ReponseAvecCodeRetour<ENTT.TransactionPaiement> ObtenirDetailTP(ENTT.CriteresObtenirTransactionPaiement 
        //    )
        //{

        //    E8_ENT.TransactionPaiement transactionPaiement = null;
        //    E8_ENT.ReponseAvecCodeRetour<E8_ENT.TransactionPaiement> retour = new E8_ENT.ReponseAvecCodeRetour<E8_ENT.TransactionPaiement>();

        //    string codeRetour = ValiderCriteresObtenirDetailTP(criteres);
        //    if (codeRetour == "00")
        //    {
        //        transactionPaiement = TransacPaiementTR.Obtenir(criteres);
        //        //transactionPaiement = ObtenirDetailTPDemo(criteres)


        //        if (transactionPaiement == null)
        //        {
        //            if (!string.IsNullOrWhiteSpace(criteres.NTP.ToString))
        //            {
        //                ajoutMessageFonc("E8_00012E", criteres.NTP.ToString);
        //                codeRetour = "03";
        //            }


        //            if (!string.IsNullOrWhiteSpace(criteres.DPE))
        //            {
        //                ajoutMessageFonc("E8_00013E", criteres.DPE);
        //                codeRetour = "04";
        //            }
        //        }

        //    }
        //    retour.CodeRetour = codeRetour;
        //    retour.Reponse = transactionPaiement;

        //    return retour;
        //}



    }
}
