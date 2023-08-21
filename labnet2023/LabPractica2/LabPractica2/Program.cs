using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor para dividirlo por 0:");
            var n = int.Parse(Console.ReadLine());
            n.DividirPor0();
            Console.WriteLine("Ingrese 2 numeros para dividirlos:");
            try
            {
                Console.Write("Dividendo: ");
                var dividendo = int.Parse(Console.ReadLine());
                Console.Write("Divisor: ");
                var divisor = int.Parse(Console.ReadLine());

                dividendo.Dividir(divisor);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Logic logic = new Logic();
            try
            {
                logic.ThrowException();
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);   
            }

           
            try
            {
                logic.ExcepcionPersonalizada();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
