using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector 
            //para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.


            int[] numeros = new int [10];
            int promedio, acumulador = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("ingrese un numero: ");
                numeros[x] = int.Parse(Console.ReadLine());
            }

            for (int x = 0; x < 10; x++)
            {
                acumulador+= numeros[x];
            }
            promedio = acumulador / 10;

            for (int x = 0; x < 10; x++)
            {
                if(numeros[x] > promedio)
                    Console.WriteLine("Este elemento fue mayor al promedio: " + numeros[x]);
            }






        }
    }
}
