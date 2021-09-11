using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Class
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }

        public Subject(string name)
        {
            this.Name = name;
        }

        public Subject(int iD, string name, int credits)
        {
            ID = iD;
            Name = name;
            Credits = credits;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
