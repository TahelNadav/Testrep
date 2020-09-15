using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Person
    {
        
        public int Id { get; set; }
        [DisplayName("תעודת זהות")]
        public int SocialSecurityNumber { get; set; }
        [DisplayName("שם פרטי")]
        public string FirstName { get; set; }
        [DisplayName("שם משפחה")]
        public string LastName { get; set; }
        
    }
}
