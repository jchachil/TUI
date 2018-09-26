using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TUIBackEnd.Entities.Common
{
    
    public abstract class Entity<T> : IEntity<T> where T : IComparable<T>
    {
        public virtual T Id { get; set; }
    }
}
