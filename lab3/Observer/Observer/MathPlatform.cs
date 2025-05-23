using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
     public class MathPlatform : ILearningPlatform
    {

        private  List<IStudent> _students = new List<IStudent>();

        public void AddStudent(IStudent student)
        {
            _students.Add(student);
        }

        public void NotifyStudent(string notification)
        {

            foreach (var student in _students)
                student.Update(notification);
        }

        public void RemoveStudent(IStudent student)
        {
            _students.Remove(student);
        }

        public void AddLastMathMaterials(string material)
        {
            Console.WriteLine($"[Matematica] Material nou: {material}");
            NotifyStudent(material);
        }
        public void AddGrade(IStudent student,string grade)
        {
            /*Console.WriteLine($"Ai primit nota {grade} la Matematica");
            NotifyStudent(grade);*/
            if (_students.Contains(student))
            {
                Console.WriteLine($"Ai primit nota {grade} la Matematica");
                student.Update($"Nota ta este: {grade}");
            }
        }
    }
}
