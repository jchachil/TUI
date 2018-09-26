using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUIBackEnd.Entities
{
    [Table("Student")]

    public class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int BirthCityID { get; set; }

        public int LivingCityID { get; set; }

        [ForeignKey("BirthCityID")]
        [InverseProperty("Students")]
        public virtual City BirthCity { get; set; }

        [ForeignKey("LivingCityID")]
        public virtual City LivingCity { get; set; }
    }
}
