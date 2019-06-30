using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Academy
{
    class Student
    {
        private static int ID;
        public string Name { get; set; }
        public string Group { get; set; }
        public string Email { get; set; }
        public int Payment { get; set; }
        public  Grouptype Type { get; set; }

        public Student(string name, string group,string email,int payment, Grouptype type)
        {
            ID++;
            Name = name;
            Group = group;
            Email = email;
            Payment = payment;
           Type= type;
        }


    }
}
