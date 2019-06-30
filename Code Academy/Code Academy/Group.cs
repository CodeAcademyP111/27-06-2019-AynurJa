using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Academy
{
    class Group
    {
        private static int ID;
        public string Name { get; set; }
       
       
        private Student[] Students;


        public Group(string name)
        {
            ID++;
            Name = name;
           

           Students = new Student[0];

        }

          public  void Addstudent(Student student)
        {
           if(Students.Length <= 2)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine($"{student.Name} {student.Group} {student.Email} {student.Payment}, qrupa daxil olmadiniz");
            }

        }
         public void GetStudent()
        {
            foreach (var item in Students)
            {
                if (item.Payment < 3500)
                {
                    Console.WriteLine($"{item.Name} {item.Group} {item.Email} {item.Payment}, Odenis tam deyil");
                }
                else
                {
                    Console.WriteLine($"Adi:{item.Name},Group:{item.Group},Email:{item.Email},Payment:{item.Payment}");
                }
            }
        }
    }

   
}
