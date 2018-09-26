using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.Entities.Common;
using System.Runtime.Serialization;

namespace TUIBackEnd.Entities
{
    [Table("Country")]
    //[DataContract]
    public class Country: Entity<int>
    {
        public string CountryName { get; set; }

        //[DataMember]
        public virtual ICollection<Airport> Airports { get; set; }

    }
}
