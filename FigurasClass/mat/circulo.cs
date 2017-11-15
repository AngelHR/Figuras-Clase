using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mat
{
    class circulo
    {
        private double radio { set; get;}
        private double pi = 3.1416;
        public void Pide()
        {
            Console.WriteLine("Ingresa tu radio: ");
            radio = double.Parse(Console.ReadLine());

            Console.WriteLine("area es" + Metodo(radio));
        }

        public double Metodo(double r)
        {
            return pi * Pot(r, 2);
        }
        public double Pot(double r,int e)
        {
            double res;
            if (e == 0)
                return 1;
            else
                res = r * Pot(r, e-1);

            return res;
        }


    }

}
