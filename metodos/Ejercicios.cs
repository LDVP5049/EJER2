using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EJER2.metodos
{
    internal class Ejercicios
    {
        public void Eje1()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arreglo1 = new int[n];
            int[] arreglo2 = new int[n];
            int[] arreglo3 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ingresa el primer numero: ");
                arreglo1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Ingresa el segundo numero: ");
                arreglo2[i] = int.Parse(Console.ReadLine());

                arreglo3[i] = arreglo1[i] + arreglo2[i];
            }

            Console.WriteLine("Contenido del arreglo 1: ");
            foreach (int i in arreglo1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Contenido del arreglo 2: ");
            foreach (int i in arreglo2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Contenido del arreglo 3: ");
            foreach (int i in arreglo3)
            {
                Console.WriteLine(i);
            }
        }

        public void Eje2(int valorB)
        {

            int[] arreglo1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            List<int> valores = new List<int>();

            for (int i = 0; i < arreglo1.Length; i++)
            {
                if (arreglo1[i] == valorB)
                {
                    valores.Add(i);
                }
            }
            if (valores.Count > 0)
            {
                Console.WriteLine("El valor se encontro en: ");
                foreach (int valor in valores)
                {
                    Console.WriteLine(valor);
                }
            }
            else
            {
                Console.WriteLine("El elemento no se encontro mi compita");
            }

        }

        public void Eje3(int z)
        {
            int contador = 0;
            int[] algebra = new int[z];
            int[] analisis = new int[z];

            for (int i = 0; i < z; i++)
            {
                Console.WriteLine("Ingresa el ID del alumno que cursa algebra: ");
                algebra[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el ID del alumno que cursa analisis: ");
                analisis[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ID's de alumnos que cursan algrebra: ");
            foreach (int i in algebra)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("ID's de alumnos que cursan analisis");
            foreach (int i in analisis)
            {
                Console.WriteLine(i);
            }

            foreach (int id in algebra)
            {
                if (analisis.Contains(id))
                {
                    contador++;
                }
            }

            if (contador > 0)
            {
                Console.WriteLine($"Cantidad de alumnos que cursan ambas materias:");
                Console.WriteLine(contador);
            }
            else
            {
                Console.WriteLine("No hay alumnos en las dos materias");
            }

        }

        public void Eje4()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];
            int[] mostrar = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingresa los numeros del arrelglo pa: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numeros del arreglo");
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }


        public void Eje5()
        {

            double[] notas = { 10, 15, 3, 8, 12, 5, 18, 7, 14, 9 };


            int aprobadas = 0, desaprobadas = 0;
            double sumaAprobadas = 0, sumaDesaprobadas = 0;


            foreach (double nota in notas)
            {
                if (nota >= 6 && nota <= 10)
                {

                    aprobadas++;
                    sumaAprobadas += nota;
                }
                else
                {

                    desaprobadas++;
                    sumaDesaprobadas += nota;
                }
            }

            double promedioAprobadas = aprobadas > 0 ? sumaAprobadas / aprobadas : 0;
            double promedioDesaprobadas = desaprobadas > 0 ? sumaDesaprobadas / desaprobadas : 0;

            Console.WriteLine("Notas Aprobadas: " + aprobadas);
            Console.WriteLine("Notas Desaprobadas: " + desaprobadas);
            Console.WriteLine("Promedio de Notas Aprobadas: " + promedioAprobadas);
            Console.WriteLine("Promedio de Notas Desaprobadas: " + promedioDesaprobadas);
        }


    }
}
