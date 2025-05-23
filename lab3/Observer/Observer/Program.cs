using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var mathPlatform = new MathPlatform();

            var student1 = new MathPlatformStudent("Ion");
            var student2 = new MathPlatformStudent("Maria");

            mathPlatform.AddStudent(student1);
            mathPlatform.AddStudent(student2);

            
            mathPlatform.AddLastMathMaterials("Ecuatii de gradul II");

            mathPlatform.AddGrade(student1, "7");
            mathPlatform.AddGrade(student2, "10");

            Console.ReadKey();

        }
    }
}
