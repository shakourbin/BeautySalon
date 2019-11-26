using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Models
{
    public abstract class BaseEntity : object
    {
        public System.Guid Id { get; set; }
        public BaseEntity(): base()
        {
            Id = System.Guid.NewGuid();
        }
    }
}
