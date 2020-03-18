using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization; 

namespace WCFC_Recherche
{
    [DataContract(Name="EnvReponseRecherche")]
    public class RechercheExtrant
    {

        private List<RechercheRetour> aListeResultatRechercheTP = new List<RechercheRetour>();

        [DataMember(Name = "RechercheCafe", IsRequired = true)]
        public List<RechercheRetour> ListeResultatRechercheTP
        {
            get { return aListeResultatRechercheTP; }
            set { aListeResultatRechercheTP = value; }
        }
    }
}
