using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.UI
{
    internal static class Utilidades
    {
        public static int LeerNumero() 
        {
            return LeerNumero(int.MaxValue);
        }
        public static int LeerNumero(int max) {

            int numero;
            while ((!int.TryParse(Console.ReadLine(), out numero) || (numero > max || numero < 0)))
            {
                Console.WriteLine("Ingrese una de las opciones correctas");
            }
            return numero;
        }

        public static string LeerTexto()
        {
            string res;
            do
            {
                res = Console.ReadLine();
            } while (res == "");

            return res;
        }
    }
}
