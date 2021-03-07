using System;
using System.Collections.Generic;
using System.Linq;

namespace Module23
{
    class Program
    {
         
        static void Main(string[] args)
        {
            var classes = new []
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {         
            List<string> masList = new List<string>();
            foreach (var c in classes)
            {               
                masList.Add(c.ToString());
            }
            var grouped = classes.GroupBy(m => m.Students.ToString()).ToArray();
            return grouped;           
        }
        public class Classroom
        {
            public List<string> Students = new List<string>();
          
        }
    }
}
