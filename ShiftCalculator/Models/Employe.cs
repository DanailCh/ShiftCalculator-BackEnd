using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftCalculator
{
    public class Employe
    {
        public Employe(string name, string surname, string position)
        {
            Name = name;
            Position = position;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
    }
    
}
