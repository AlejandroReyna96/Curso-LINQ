using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // ----------------------- LINQ SQL ----------------------------------
            var querySyntax = from n in numeros
                              where n > 2
                              select n;

            Console.WriteLine("Sintaxis de LINQ QUERY: ");
            foreach (var item  in querySyntax)
            {
                Console.WriteLine(item);
            }

            // ------------------- LINQ TO METHOD --------------------------------
            var MethodSyntax = numeros.Where(n => n > 2);

            Console.WriteLine("Sintaxis de LINQ To Method: ");
            foreach (var item in MethodSyntax)
            {
                Console.WriteLine(item);
            }

            // -------------------- LINQ CON LOS 2 FORMAS ----------------------
            var mixedSyntax = (from n in numeros
                               select n).Max();
            Console.WriteLine("Con las 2 Sintaxis: " + mixedSyntax);


            /// VIDEO # 4 -------------------------------------------------------
            IEnumerable<int> querySyntax2 = from n in numeros
                                            where n > 2
                                            select n;


            // VIDEO # 5 -----------------------------------------------------------
            List<Empleado> empleados = new List<Empleado>()
            {
                new Empleado() { ID = 1, Name = "Alex"},
                new Empleado() { ID = 1, Name = "José Luis"},
                new Empleado() { ID = 1, Name = "Miguel"},
                new Empleado() { ID = 1, Name = "Glendy"},
                new Empleado() { ID = 1, Name = "Juancho"}
            };

            // SELECT * FROM..
            var basicQueryALL = (from em in empleados
                              select em).ToList();
            var basicMehtodALL = empleados.ToList();

            // SELECT 'CAMPO' FROM...
            var basicPropQuery = (from em in empleados
                                  select em.Name).ToList();
            var basicPropMethod = empleados.Select(em => em.Name).ToList();

            // SELECT NEW {}   y ANÓNIMO
            var selectQuery = (from emp in empleados
                               select new Empleado()
                               {
                                   ID = emp.ID,
                                   Name = emp.Name
                               }).ToList();
            var selectMethod = empleados.Select(emp => new
            {
                CustomId = emp.ID,
                CustomName = emp.Name
            });
        }
    }
}
