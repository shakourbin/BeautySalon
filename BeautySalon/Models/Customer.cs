using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Models
{
    public class Customer : BaseEntity
    {
        public Customer() : base()
        {
        }

        public int CustomerCode { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int TelephoneNumber { get; set; }
        public int MobileNumber { get; set; }
        public string Address { get; set; }
    }
}
