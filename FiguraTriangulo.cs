using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace polimorfismo
{
    class FiguraTriangulo : FiguraRectangulo
    {
        public void area(int Base, int altura)
        {
            Console.WriteLine("El area del triangulo es: " + (Base * altura)/2);
        }

    }
}
