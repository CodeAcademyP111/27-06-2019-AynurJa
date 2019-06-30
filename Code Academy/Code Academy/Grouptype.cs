using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Academy
{
    class Grouptype
    {
        private static int ID;
        public string Type { get; set; }
       

        public Grouptype(string type)
        {
            ID++;
            Type = type;
          
        }

    }
}
