﻿using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            //- Número de Artículo (1 a 15)
            //- Cantidad Vendida 
            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.


            int nroArticulo;
            int cantidad;
            int[] totalCantidadVendida = new int[15];
            for (int x = 0; x < 15; x++)
            {
                totalCantidadVendida[x] = 0;
            }

            Console.WriteLine("Ingrese el numero de articulo: ");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());

            while (nroArticulo != 0)
            {

                totalCantidadVendida[nroArticulo - 1] += cantidad;
                


                Console.WriteLine("Ingrese el numero de articulo: ");
                nroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida: ");
                cantidad = int.Parse(Console.ReadLine());



            }

            //punto a

            int maxCantidad = totalCantidadVendida[0];
            int nroMaximo = 1;
            for (int x = 0; x < 15; x++)
            {
                if(totalCantidadVendida[x] > maxCantidad){
                    maxCantidad = totalCantidadVendida[x];
                    nroArticulo = x + 1;
                }

            }
            Console.WriteLine("El producto mas vendido es el: " + nroArticulo + " con la cantidad: " + maxCantidad);

            //punt0 b
            for (int x = 0; x < 15; x++)
            {
                if(totalCantidadVendida[x] == 0)
                    Console.WriteLine("El producto" + (x +1)+  "no tuvo ventas");
            }

            //punto c
            Console.WriteLine("La cantidad de articulo vendidos para el articulo 10 es: " + totalCantidadVendida[9]);





        }
    }
}
