using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroOO_dotNet.Capitulo_2
{
    public class Circulo
    {
        private readonly double PI = 3.14;

        public double Raio { get; set; }

        public double Area()
        {
            return PI * Math.Pow(Raio, 2);
        }

        public double Comprimento()
        {
            return PI * Raio;
        }
    }
}
