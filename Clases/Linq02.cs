using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.Clases
{
    public class Linq02
    {
        List<Student> _student = new List<Student>(){
            new Student(){Id = 1, Name = "Sebas", Age = 19},
            new Student(){Id = 2, Name = "Iron Man", Age = 18},
            new Student(){Id = 3, Name = "Hulk", Age = 19},
            new Student(){Id = 4, Name = "SpiderMan",Age = 17}
        };

        public void PrintData()
        {
            var teenStudents = _student.Where(s => s.Age > 12 && s.Age < 20).ToList<Student>();
            teenStudents.ForEach(tp => Console.WriteLine($"{tp.Name}"));
        }

        public void NameId()
        {
            var expre = from s in _student select new { s.Id, s.Name };

            foreach (var item in expre)
            {
                Console.WriteLine($"Id:{item.Id} \nNombre:{item.Name}");
            }
        }
    }
}