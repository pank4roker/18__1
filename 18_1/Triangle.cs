using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_1
{
    /// <summary>
    /// Наследуемый класс треугольник
    /// </summary>
    class Triangle : Figure
    {
        /// <summary>
        /// Поля сторон
        /// </summary>
        private int side1, side2, side3;

        public Triangle(string name, int side1, int side2, int side3) : base(name)
        {
            if (side1 < (side2 + side3) && side2 < (side1 + side3) && side3 < (side1 + side2))
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            else
            {
                Write($"Note");
            }
        }
        /// <summary>
        /// Св-ва полей сторон 
        /// </summary>
        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }
        public int Side3 { get => side3; set => side3 = value; }
        // <summary>
        /// Метод вычисления площади
        /// </summary>
        /// <returns>Площадь</returns>
        public override double Area()
        {
            int p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
        /// <summary>
        /// Метод вычисления периметра
        /// </summary>
        /// <returns>Периметр</returns>
        public override double Perimenter()
        {
            return side2 + side1 + side3;
        }
        /// <summary>
        /// Виртуальный метод вывода информации
        /// </summary>
        public override void Print()
        {
            base.Print();
            WriteLine($"Сторона 1: {side1}\nСторона 2: {side2}\nСторона 3: {side3}\nПлощадь: {Area()}\nПериметр: {Perimenter()}");
        }
    }
}
