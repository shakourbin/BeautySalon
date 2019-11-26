using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Models
{
    public class User : BaseEntity
    {
        public User() : base()
        {
        }

        public string UserName {get;set;}
        public string Password { get; set; }
        public string FamilyName { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
    }
}
