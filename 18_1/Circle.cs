using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_1
{
    
    class Circle:Figure
    {
        const double PI = 3.14;
        private int r;
        public Circle(string name,int r):base(name)
        {
            this.r = r;
        }

        public int R { get => r; set => r = value; }
        public override double Area()
        {
            return PI*Math.Pow(r,2);
        }
        public override double Perimenter()
        {
            return 2 * PI * r;
        }
        public override void Print()
        {
            base.Print();
            WriteLine($"Радиус: {r}\nПлощадь: {Area()}\nПериметр: {Perimenter()}");
        }

    }
}
