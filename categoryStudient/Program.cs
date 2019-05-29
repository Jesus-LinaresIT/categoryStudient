using System;

namespace categoryStudient
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            double prom;
            char c;

            Console.Write("Digite el nombre del estudiante: ");
            name = Console.ReadLine();
            Console.Write("Digite el promedio del estudiante: ");
            prom = Convert.ToDouble(Console.ReadLine());

            if (prom >= 9.0)
            {
                c = 'A';
            }
            else
            {
                if (prom >= 8.0)
                {
                    c = 'B';
                }
                else
                {
                   if (prom >= 7.0)
                    {
                        c = 'C';
                    }
                   else
                   {
                       if (prom >= 6.0)
                       {
                           c = 'D';
                       }
                       else
                       {
                           c = 'E';
                       }
                   }

                }               
            }

            Console.WriteLine("El estudiante: {0}, es de Categoria {1}", name, c);
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();

        }
    }
}
