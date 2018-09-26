using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.Entities.Common;

namespace TUIBackEnd.Entities
{
    [Table("Test")]
    public class Test : Entity<int>
    {
        [MaxLength(100)]
        public string Col1 { get; set; }

        [MaxLength(50)]
        public string Col2 { get; set; }

    }
}
