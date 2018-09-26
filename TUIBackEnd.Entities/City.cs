using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUIBackEnd.Entities
{
    [Table("City")]
    public class City
    {
        public int ID { get; set; }

        public string CityName { get; set; }

        public decimal distance { get; set; }
        public double  MyProperty { get; set; }

        //public virtual ICollection<Student> Students { get; set; }
    }
}
