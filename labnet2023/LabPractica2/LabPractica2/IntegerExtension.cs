using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractica2
{
    public static class DoubleExtension
    {
        public static void DividirPor0(this int numero)
        {
            try
            {
                Console.WriteLine(numero / 0);
                
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Dividir(this int dividendo, int divisor)
        {
            try
            {
                if (divisor == 0)
                {
                    throw new DivideByZeroException();
                }

                double res = (double)dividendo / divisor;
                Console.WriteLine($"El resultado de la operación es: {res}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Que onda facha?  o sabias que no se puede dividir entre 0 campeon?.");
            }
            finally
            {
                Console.WriteLine("Operación intentada");
            }
        }
    }

}
