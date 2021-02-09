using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            FiguraRectangulo rectangulo = new FiguraRectangulo();
                

            rectangulo.area(34, 56);

            FiguraTriangulo triangulo = new FiguraTriangulo();

            triangulo.area(34, 56);

            Console.ReadKey();

        }
    }
}
