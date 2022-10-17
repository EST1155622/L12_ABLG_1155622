using System;

namespace L12_ABLG_1156622
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PUNTOS");
            pruebaVector pv = new pruebaVector();
            pv.Cargar();
            pv.Imprimir();
        }

        class pruebaVector
        {
            private int[] PUNTOS;
            public int suma = 0;
            public double media;
            public void Cargar()
            {
                PUNTOS = new int[15];
                for (int f = 0; f < 15; f++)
                {
                    Console.WriteLine("Ingresa una nota: ");
                    string linea;
                    linea = Console.ReadLine();
                    PUNTOS[f] = int.Parse(linea);
                    suma = suma + PUNTOS[f];


                }
                media = +suma / 15;

            }



            public void Imprimir()
            {
                for (int f = 0; f < 15; f++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Se ingreso ");
                    Console.WriteLine("");
                    Console.WriteLine(PUNTOS[f]);


                }
                Console.WriteLine("La suma es : " + suma);
                Console.WriteLine("La media es : " + media);
                Console.ReadKey();
            }

        }
    }
}