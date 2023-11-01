using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.Clases;
public class Linq02
{
    List<Student> _student = new List<Student>(){
            new Student(){Id = 1, Name = "Sebas", Age = 19, IdStandard = 1},
            new Student(){Id = 2, Name = "Iron Man", Age = 18, IdStandard = 1},
            new Student(){Id = 3, Name = "Hulk", Age = 19, IdStandard = 3},
            new Student(){Id = 4, Name = "SpiderMan",Age = 17, IdStandard = 1}
        };

    List<Standard> _standard = new List<Standard>(){
            new Standard(){IdStandard = 1, StandardName = "Standard 1"},
            new Standard(){IdStandard = 2, StandardName = "Standard 2"},
            new Standard(){IdStandard = 3, StandardName = "Standard 3"},
            new Standard(){IdStandard = 4, StandardName = "Standard 4"},
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

    public void PrintDataV2()
    {
        var filteredStudent = _student.Where((s, i) =>
        {
            if (i % 2 == 0)
                return true;

            return false;
        }).ToList();

        filteredStudent.ForEach(x => Console.WriteLine(x.Name));
    }

    //construir metodo ordenar forma asendente o descendente

    public List<Student> OrderName()
    {
        Console.Clear();
        Console.WriteLine("Seleccion Orden\n 1-Ascendente \n 2-Descendente");
        Console.Write("Opcion: ");
        int select = Convert.ToInt16(Console.ReadLine());
        List<Student> stu;
        switch (select)
        {
            case 1:
                stu = _student.OrderBy(s => s.Name).ToList();
                break;
            case 2:
                stu = _student.OrderByDescending(s => s.Name).ToList();
                break;
            default:
                Console.WriteLine("Opcion Invalidad");
                return stu = new List<Student>();
        }
        return stu;
    }

    public void InnerJoin()
    {
        Console.Clear();
        var resul = _student.Join(
            _standard,
            std => std.IdStandard,
            stan => stan.IdStandard,
            (std,stan) => new {
                StudentName = std.Name,
                stan = stan.StandardName
            }).ToList();
        resul.ForEach(x => Console.Write($"Nombre: {x.StudentName} -- Nota: {x.stan}\n"));
    }
}