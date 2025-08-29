using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Program
    {
        // Lista para almacenar estudiantes
        static List<string> estudiantes = new List<string>();

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\n=== MENÚ DE ESTUDIANTES ===");
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Listar estudiantes");
                Console.WriteLine("3. Buscar estudiante");
                Console.WriteLine("4. Eliminar estudiante");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarEstudiante();
                        break;
                    case 2:
                        ListarEstudiantes();
                        break;
                    case 3:
                        Console.Write("Introduce el nombre a buscar: ");
                        string nombre = Console.ReadLine();
                        bool encontrado = BuscarEstudiante(nombre);
                        if (encontrado)
                            Console.WriteLine("El estudiante {0} está en la lista.", nombre);
                        else
                            Console.WriteLine("No se encontró el estudiante.");
                        break;
                    case 4:
                        Console.Write("Introduce el nombre a eliminar: ");
                        string eliminar = Console.ReadLine();
                        EliminarEstudiante(eliminar);
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo.");
                        break;
                }

            } while (opcion != 5);
        }

        // Método sin retorno y sin parámetros
        static void AgregarEstudiante()
        {
            Console.Write("Introduce el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            estudiantes.Add(nombre);
            Console.WriteLine("Estudiante agregado con éxito.");
        }

        // Método sin retorno que muestra datos
        static void ListarEstudiantes()
        {
            Console.WriteLine("\n=== LISTA DE ESTUDIANTES ===");
            if (estudiantes.Count == 0)
            {
                Console.WriteLine("No hay estudiantes registrados.");
            }
            else
            {
                foreach (var est in estudiantes)
                {
                    Console.WriteLine("- " + est);
                }
            }
        }

        // Método con retorno (true/false) y con parámetro
        static bool BuscarEstudiante(string nombre)
        {
            return estudiantes.Contains(nombre);
        }

        // Método con parámetros y sin retorno
        static void EliminarEstudiante(string nombre)
        {
            if (estudiantes.Remove(nombre))
            {
                Console.WriteLine("Estudiante eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("No se encontró el estudiante.");
            }
        }
    }
}
