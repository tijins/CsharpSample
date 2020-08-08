using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class User
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }

        public User() { 
        }

        public User(string name, string address, int age)
        {
            Name = name;
            Address = address;
            Age = age;
        }
    }
}
