using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mat
{
    class rectangulo
    {
        private double largo { set; get; }
        private double ancho { set; get; }

        public void Pide()
        {
            Console.WriteLine("Ingresa tu largo: ");
            largo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu ancho: ");
            ancho = double.Parse(Console.ReadLine());

            Console.WriteLine("area es" + Metodo());
        }

        public double Metodo()
        {
            return largo * ancho;
        }
        
    }
}
