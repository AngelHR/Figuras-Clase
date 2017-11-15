using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mat
{
    class Program
    {
        static void Main(string[] args)
        {
            circulo c = new circulo();
            rectangulo r = new rectangulo();
            do
            {
                Console.WriteLine("Menu ");
                Console.WriteLine("[1] circulo ");
                Console.WriteLine("[2] Rectangulo ");
                Console.WriteLine("[3] Salir");
                Console.WriteLine("Ingresa una opcion: ");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        c.Pide();
                        break;
                    case 2:
                        r.Pide();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Selecciona la opcion funcional.");
                        break;
                }
                if (op == 3)
                    break;
            } while (true);

            Console.ReadKey();
        }

    }
}
