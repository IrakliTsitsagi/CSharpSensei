using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persona
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Surname}, {Age}, {Sex}"; //es kaia
        }

    }
}

