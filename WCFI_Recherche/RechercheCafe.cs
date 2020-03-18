using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WCFI_Recherche
{
    public class RechercheCafe : WCFC_Recherche.IRecherche  
    {


        public WCFC_Recherche.RechercheExtrant Rechercher(WCFC_Recherche.RechercheIntrant critere)
        {
            WCFC_Recherche.RechercheExtrant Retour  = null;
        //Dim traducteurRechercheTpPourIntrant As New TraducteurRechercheTpIntrant
        //Dim rechercheTpTraducteurPourRetour As New TraducteurRechercheTPExtrant

        //Dim criteresRechercherTP As New ENTT.CriteresRechercherTransactionPaiement
        //Dim retourTP As E8_ENT.ReponseAvecCodeRetour(Of List(Of E8_ENT.ReponseRechercherTransactionPaiement)) = Nothing

        //Using scope As New Transactions.TransactionScope(Transactions.TransactionScopeOption.Required)

        //    'Effacer tous les messages
        //    E899_MSG.GestionMessage.ObtenirInstance().EffacerTousLesMessages()

        //    criteresRechercherTP = traducteurRechercheTpPourIntrant.TraduireDataContractEnEntite(critere)


        //    Try 'Lancer les recherches dans TCP et fermer les connexions TCP à la fin, erreur technique ou pas.

        //        retourTP = TransactionPaiementCDA.RechercherTP(criteresRechercherTP)

        //        Retour = rechercheTpTraducteurPourRetour.TraduireEntiteEnDataContract(retourTP)

        //        scope.Complete()


        //    Catch ex As Exception
        //        XP.Framework.Accesseurs.Instance.JournalisationException.EcrireException(ex)
        //        Throw
        //    End Try
        //End Using

            return Retour;
        }
    }
}
