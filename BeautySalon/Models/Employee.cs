using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Models
{
    public class Employee : Person
    {
        public Employee() :base()
        {
        }

        // اطلاعات کارمندان 
        
        public string NationalCode { get; set; }
        public string BirthDate { get; set; }
        public string FatherName { get; set; }
       
       
    }
}
