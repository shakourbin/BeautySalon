using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Models
{
    public class Customer :BaseEntity
    {
        public Customer() : base()
        {
        }

        public string Name { get; set; }
        public string FamilyName { get; set; }
    }
}
