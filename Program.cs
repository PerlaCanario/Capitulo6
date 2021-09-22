using System;

namespace Capitulo6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables necesarias
            int cantidad = 0; // Cantidad de alumnos
            int salones = 0; // Cantidad de salones
            int n = 0; // Variable de control de ciclo salones
            int m = 0; // Variable de control del ciclo alumnos
            string valor ="";

            // Variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f; //Variable para la calificación mínima
            float maxima = 0.0f; //Variable para la calificación maxima

            // Pedimos la cantidad de salones
            Console.WriteLine("Dame la cantidad de salones");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);
            // Creamos el arreglo
            float[][] calif = new float[salones][];
            // Pedimos los alumnos por salon
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                Console.WriteLine($"Dame la cantidad de alumnospara el salon {0}",n);
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);
                // Instanciamos el arreglo
                calif[n] = new float[cantidad];
            }

            // Capturamos la información
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                Console.WriteLine("\nSalon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++) //Ciclo alumnos
{
                    Console.Write("Dame la calificación ");
                    valor = Console.ReadLine();
                    calif[n][m] = Convert.ToSingle(valor);

                    suma += calif[n][m];

                    if (calif[n][m] > maxima)

                        maxima = calif[n][m];

                    else if (calif[n][m] < minima)

                        minima = calif[n][m];
                }
                
                promedio = suma / calif[n].GetLength(0);
                Console.WriteLine($"EL Promedio de Calificaciones es: {promedio}");
                
            }

            // Desplegamos la información
            Console.WriteLine("—— Información ——");
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                Console.WriteLine("\nSalon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++) // Ciclo alumnos
                {
                    Console.WriteLine("El alumno {0} tiene {1}", m, calif[n][m]);
                }
                Console.Write($"\nLa mayor venta es: {maxima}");
                Console.Write($"\nLa menor venta es: {minima}");
            }
            
        }
    }
}
