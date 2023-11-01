using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.Clases;
    public class Linq01
    {
        List<string> libros = new List<string>(){
            "VB.Net Tutorial",
            "C# Tutorial",
            "TypeScript e-book"
        };

        public IEnumerable<string> ListaLibrosByNombre(string criterio)
        {
            return libros.Where(x => x.Contains(criterio));
        }
        public void PrintDataQuery(string criterio)
        {
            Console.WriteLine("Ingrese el criterio de busqueda:");
            var result = (from s in libros where s.Contains(criterio) select s).ToList<string>();
            //Otra forma de hacer el foreach Importante el .ToList<string>()
            result.ForEach(x => Console.WriteLine($"Se encontro : {x}"));

        }
        public void PrintData()
        {
            Console.WriteLine("Ingrese el criterio de busqueda:");
            string criterio = Console.ReadLine();
            IEnumerable<string> data = ListaLibrosByNombre(criterio);
            foreach (string item in data)
            {
                Console.WriteLine($"Se encontro : {item}");
            }
            
            Console.WriteLine("Presione una tecla para continuar....");
            Console.ReadKey();
        }
    }