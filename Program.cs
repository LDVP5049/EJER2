using EJER2.metodos;

namespace Ejercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicios ejercicio1 = new Ejercicios();
            Console.WriteLine("Ingresa el rango del arrglo 1: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el rango del arreglo 2: ");
            ejercicio1.Eje1();

            Ejercicios ejercicio2 = new Ejercicios();
            Console.WriteLine("Ingresa el valor buscado");
            int valorB = int.Parse(Console.ReadLine());
            ejercicio2.Eje2(valorB);

            Ejercicios ejercicio3 = new Ejercicios();
            Console.WriteLine("Ingresa la cantidad de alumnos de la clase: ");
            int z = int.Parse(Console.ReadLine());
            ejercicio3.Eje3(n);

            Ejercicios ejercicio4 = new Ejercicios();
            Console.WriteLine("Ingresa el numero de datos");
            ejercicio4.Eje4();


            Ejercicios ejercicio5 = new Ejercicios();
            ejercicio5.Eje5();
        }
    }
}