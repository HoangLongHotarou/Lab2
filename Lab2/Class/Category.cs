using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Class
{
    public class Category
    {
        public List<Subject> ls;
        public Category()
        {
            ls = new List<Subject>();
        }

        public override string ToString()
        {
            string s = "DS môn học: ";
            foreach (var item in ls)
            {
                s += item + ";";
            }
            return base.ToString();
        }
    }
}
