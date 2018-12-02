using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5_3_Radix; 

namespace _5_3_Radix
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodoRadix figura1 = new MetodoRadix(); //Declaracion de la clase, en este caso externa
            int[] Vector1 = new int[] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 }; //Vector 1
            int[] Vector2 = new int[] { 8, 3, 9, 3, 11, 7, 1, 27, 12 }; //Vector 2
            int[] Vector3 = new int[] { 10, 40, 36, 5, 24, 2, 5, 8 }; //Vector 3
            int[] Vector4 = new int[] { 55, 42, 0, -3, 0, -1, 2, 4, 7 }; //Vector 4
            int[] Vector5 = new int[] { 25, 108, 1024, 12, 351, 251, 39 }; //Vector 5

            Console.WriteLine("Valores sin ordenar: ");

            foreach (var item in Vector1) //Imprime el vector 1 sin ordenar
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");

            foreach (var item in Vector2) //Imprime el vector 2 sin ordenar
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");

            foreach (var item in Vector3) //Imprime el vector 3 sin ordenar
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");

            foreach (var item in Vector4) //Imprime el vector 4 sin ordenar
            {
                Console.Write(" " + item);
            }
            Console.WriteLine("\n");
            foreach (var item in Vector5) //Imprime el vector 5 sin ordenar
            {
                Console.Write(" " + item);
            }

            figura1.Radix(Vector1); //Se carga "public void Radix" de la clase externa
            Console.WriteLine("\n");
            Console.WriteLine("Valores Ordenados: ");

            foreach (var item in Vector1) //Se imprime el vector1 ya ordenado 
            {
                Console.Write(" " + item);

            }
            Console.WriteLine("\n");
            foreach (var item in Vector2) //Se imprime el vector2 ya ordenado 
            {
                Console.Write(" " + item);

            }
            Console.WriteLine("\n");
            foreach (var item in Vector3) //Se imprime el vector3 ya ordenado 
            {
                Console.Write(" " + item);

            }
            Console.WriteLine("\n");
            foreach (var item in Vector4) //Se imprime el vector4 ya ordenado 
            {
                Console.Write(" " + item);

            }
            Console.WriteLine("\n");
            foreach (var item in Vector5) //Se imprime el vector5 ya ordenado 
            {
                Console.Write(" " + item);

            }

            Console.ReadKey();
        }
        
    }
}