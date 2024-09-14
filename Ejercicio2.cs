using System;
using System.Collections.Generic;
using System.Linq;

class Ejercicio2
{
    static void Main(string[] args)
    {
        List<string> lista = new List<string>();
        const int MIN_ELEMENTOS = 10;

        // Solicitar al usuario que ingrese al menos 10 elementos
        Console.WriteLine("Ingrese al menos 10 elementos para iniciar la lista:");
        while (lista.Count < MIN_ELEMENTOS)
        {
            Console.Write($"Elemento {lista.Count + 1}: ");
            lista.Add(Console.ReadLine());
        }

        while (true)
        {
            // Limpiar la pantalla y mostrar el menú
            Console.Clear();
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion.ToLower())
            {
                case "a":
                    AgregarElemento(lista);
                    break;
                case "b":
                    ActualizarElemento(lista);
                    break;
                case "c":
                    EliminarElemento(lista);
                    break;
                case "d":
                    MostrarOrdenado(lista, ascending: true);
                    break;
                case "e":
                    MostrarOrdenado(lista, ascending: false);
                    break;
                case "f":
                    Console.WriteLine("Cerrando programa...");
                    return; // Termina la ejecución del programa
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Menú:");
        Console.WriteLine("a) Agregar un nuevo elemento.");
        Console.WriteLine("b) Actualizar un elemento.");
        Console.WriteLine("c) Eliminar un elemento.");
        Console.WriteLine("d) Mostrar alfabéticamente (A-Z).");
        Console.WriteLine("e) Mostrar alfabéticamente y en orden inverso (Z-A).");
        Console.WriteLine("f) Cerrar programa.");
        Console.Write("Seleccione una opción: ");
    }

    static void AgregarElemento(List<string> lista)
    {
        Console.Write("Ingrese el nuevo elemento: ");
        string nuevoElemento = Console.ReadLine();
        lista.Add(nuevoElemento);
        Console.WriteLine("Elemento agregado. Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ActualizarElemento(List<string> lista)
    {
        Console.Write("Ingrese el elemento a actualizar: ");
        string elementoAntiguo = Console.ReadLine();

        if (lista.Contains(elementoAntiguo))
        {
            Console.Write("Ingrese el nuevo valor: ");
            string nuevoElemento = Console.ReadLine();
            int index = lista.IndexOf(elementoAntiguo);
            lista[index] = nuevoElemento;
            Console.WriteLine("Elemento actualizado. Presione cualquier tecla para continuar...");
        }
        else
        {
            Console.WriteLine("El elemento no existe en la lista.");
        }
        Console.ReadKey();
    }

    static void EliminarElemento(List<string> lista)
    {
        Console.Write("Ingrese el elemento a eliminar: ");
        string elemento = Console.ReadLine();

        if (lista.Contains(elemento))
        {
            lista.Remove(elemento);
            Console.WriteLine("Elemento eliminado. Presione cualquier tecla para continuar...");
        }
        else
        {
            Console.WriteLine("El elemento no existe en la lista.");
        }
        Console.ReadKey();
    }

    static void MostrarOrdenado(List<string> lista, bool ascending)
    {
        var listaOrdenada = ascending ? lista.OrderBy(x => x).ToList() : lista.OrderByDescending(x => x).ToList();

        Console.WriteLine(ascending ? "Lista en orden alfabético (A-Z):" : "Lista en orden alfabético inverso (Z-A):");
        foreach (var elemento in listaOrdenada)
        {
            Console.WriteLine(elemento);
        }
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}
