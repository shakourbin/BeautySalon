using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Models
{
    public class Person : BaseEntity 
    {
        public Person () : base ()
        {
           
        }

        public int Code { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string FullName { get; set; }
        public int PhoneNumber { get; set; }
        public int MobileNumber { get; set; }
        public string Address { get; set; }
    }
}
