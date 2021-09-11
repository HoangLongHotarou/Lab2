using Lab2.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Search
{
    public  class TeacherManagement
    {
        public static List<Teacher> ls = new List<Teacher>();

        public TeacherManagement()
        {
            ls = new List<Teacher>();
        }

        public static bool Add(Teacher gv)
        {
            var s = ls.Find(x => x.ID == gv.ID);
            if (s == null)
            {
                ls.Add(gv);
                return true;
            }
            return false;
        }

        public static Teacher Search(SearchType type, string temp)
        {
            bool t;
            if (type == SearchType.TheoMa)
                return ls.Find(x => x.ID == temp);
            else if (type == SearchType.TheoHoTen)
                return ls.Find(x => x.Name == temp);
            else
                return ls.Find(x => x.phoneNum == temp);
        }

        public static void Delete(SearchType type, string temp)
        {
            if (type == SearchType.TheoMa)
                ls.RemoveAll(x => x.ID == temp);
            else if (type == SearchType.TheoHoTen)
                ls.RemoveAll(x => x.Name == temp);
            else
                ls.RemoveAll(x => x.phoneNum == temp);
        }
    }
}
