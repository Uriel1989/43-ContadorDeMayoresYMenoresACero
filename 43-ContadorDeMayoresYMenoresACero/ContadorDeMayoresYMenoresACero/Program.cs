using System;

namespace ContadorDeMayoresYMenoresACero
{
    class Program
    {
        static void Main(string[] args)
        {
            int b=0;
            int mayor = 0;
            int menor = 0;
            Console.WriteLine("ingrese 10 numeros y mostraremos cuantos son mayores y menores a 0");


            for (int i= 0; i<10 ; i++)
            {
                b = Convert.ToInt32(Console.ReadLine());

                if (b > 0)
                {
                    mayor = mayor + 1;
                }
                else
                {

                    if (b < 0)
                    {
                        menor = menor + 1;
                    }
                }

                
            }
            Console.WriteLine("La cantidad de numeros ingresador mayores a cero es:" + mayor);
            Console.WriteLine("La cantidad de numeros ingresados menores a cero es:" + menor);

            Console.ReadKey();
        }
    }
}
