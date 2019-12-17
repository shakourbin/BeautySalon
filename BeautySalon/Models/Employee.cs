using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Models
{
    public class Employee : BaseEntity
    {
        public Employee() :base()
        {
        }

        // اطلاعات کارمندان 
        public int EmployeeCode { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string IdentityCode { get; set; }
        public string BirthDate { get; set; }
        public string FatherName { get; set; }
        public int TelephoneNumber { get; set; }
        public int MobileNumber { get; set; }
        public string Address { get; set; }
    }
}
