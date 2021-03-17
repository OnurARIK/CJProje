using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CJProje.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string userRole { get; set; }
    }
}
