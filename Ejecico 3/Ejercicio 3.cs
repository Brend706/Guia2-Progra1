using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnos
{
    internal class Alumnos
    {
        static void Main(string[] args)
        {
            ArrayList alumnos = new ArrayList() {
                "Jorge",
                "Pepe",
                "Tatiana",
                "Camila",
                "Rodrigo",
                "Luis",
                "Gabriela"
            };

            Console.WriteLine("Por favor ingrese el nombre del alumno que quiere buscar");
            string buscar = Console.ReadLine().Trim().ToLower();

            if (alumnos.Cast<string>().Any(a => a.ToLower() == buscar))
            {
                Console.WriteLine("El alumno se encontró exitosamente");
                Console.WriteLine("¿Desea actualizar el nombre del alumno? (s/n)");
                char actualizar = char.Parse(Console.ReadLine().ToLower());

                if (actualizar == 's')
                {
                    int index = alumnos.Cast<string>().ToList().FindIndex(a => a.ToLower() == buscar);
                    Console.WriteLine("Ingrese el nuevo nombre del alumno");
                    string nuevoNombre = Console.ReadLine();
                    alumnos[index] = nuevoNombre;
                    Console.WriteLine("El alumno fue actualizado a " + nuevoNombre);
                }
            }
            else
            {
                Console.WriteLine("El alumno no se encuentra en la lista.");
            }
            Console.ReadKey();
        }
    }
}