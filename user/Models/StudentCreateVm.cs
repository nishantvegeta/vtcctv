using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace user.Models
{
    public class StudentCreateVm
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}