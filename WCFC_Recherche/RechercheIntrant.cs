using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization; 

namespace WCFC_Recherche
{
    [DataContract(Name = "EnvRequeteRecherche")]
    public class RechercheIntrant
    {

        [DataMember(Name = "Id", IsRequired = false)]
        public int Id { get; set; }

        [DataMember(Name = "Name", IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "Type", IsRequired = false)]
        public string Type { get; set; }

        [DataMember(Name = "Price", IsRequired = false)]
        public double Price { get; set; }

      
    }
}
