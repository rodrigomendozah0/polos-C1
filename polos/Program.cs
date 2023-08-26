using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string polo;
            int cantPolo;
            double precioUni, precioTotal, desc;

            Console.WriteLine("Ingrese el modelo del polo: ");
            polo = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de polos a comprar: ");
            cantPolo = int.Parse(Console.ReadLine());

            desc = 0;
            precioUni = 0;

            if (cantPolo < 0)
            {
                return;
            }

            switch (polo.ToLower())
            {
                case "real madrid":
                    precioUni = 88.90;
                    break;
                case "barcelona":
                    precioUni = 87.80;
                    break;
                case "juventus":
                    precioUni = 74.90;
                    break;
                case "inter de milan":
                    precioUni = 77.50;
                    break;
                default:
                    Console.WriteLine("No existe ese modelo");
                    Console.ReadKey();
                    break;
            }
            if (cantPolo < 6)
            {
                desc = 1;
            }
            if (cantPolo >= 6 && cantPolo < 12)
            {
                desc = 0.96;
            }
            if (cantPolo >= 12 && cantPolo < 15)
            {
                desc = 0.94;
            }
            if (cantPolo >= 15)
            {
                desc = 0.92;
            }

            precioTotal = precioUni * cantPolo;
            precioTotal = precioTotal * desc;
            Console.WriteLine("El Precio final de la compra es: S/" + precioTotal);
            Console.ReadKey();
        }
    }
}
