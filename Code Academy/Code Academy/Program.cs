using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Grouptype Programming = new Grouptype("Programming");
            Grouptype design = new Grouptype("design");
            Grouptype marketing = new Grouptype("marketing");


            Student Aynur = new Student("Aynur", "P111", "aynurja@code.edu.az", 4500, Programming);
            Student Firuze = new Student("Firuze", "P111", "Firuze@code.edu.az", 5000, Programming);
            Student Shela = new Student("Shela", "P111", "Shela@code.edu.az", 500, Programming);

            Student Yagub = new Student("Yagub", "P111", "yagubism@code.edu.az", 4500, marketing);
            Student Huseyn = new Student("Huseyn", "P111", "huseyn@code.edu.az", 4500, marketing);
            Student Vugar = new Student("Vugar", "P111", "vugar@code.edu.az", 4500, marketing);

            Group programming1 = new Group("programming1");
            programming1.Addstudent(Aynur);
            programming1.Addstudent(Firuze);
            programming1.Addstudent(Shela);
            programming1.GetStudent();

            Group marketing1 = new Group("marketing1");
            marketing1.Addstudent(Yagub);
            marketing1.Addstudent(Huseyn);
            marketing1.Addstudent(Vugar);
            marketing1.GetStudent();

        }
        
    }
}
