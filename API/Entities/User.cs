using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entity
{
    public class User
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}