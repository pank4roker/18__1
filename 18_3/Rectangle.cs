using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_1
{

    /// <summary>
    /// Наследуемый класс прямоугольника 
    /// </summary>
    class Rectangle:Figure
    {
       /// <summary>
       /// Поля сторон прямоуг.
       /// </summary>
       private int side1, side2;
        public Rectangle() { }
       /// <summary>
       /// Конструктор с параметрами 
       /// </summary>
       /// <param name="name"> Название </param>
       /// <param name="side1"> Сторона 1 </param>
       /// <param name="side2"> Сторона 2 </param>
       public Rectangle(string name,int side1, int side2):base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        /// <summary>
        /// Св-ва полей сторон
        /// </summary>
        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }
        /// <summary>
        /// Метод вычисления площади
        /// </summary>
        /// <returns>Площадь</returns>
        public override double Area()
        {
            return side1*side2;
        }
        /// <summary>
        /// Метод вычисления периметра
        /// </summary>
        /// <returns>Периметр</returns>
        public override double Perimenter()
        {
            return (side2 + side1) * 2;
        }
        /// <summary>
        /// Виртуальный метод вывода информации
        /// </summary>
        public override void Print()
        {
            base.Print();
            WriteLine($"Сторона 1: {side1}\nСторона 2: {side2}\nПлощадь: {Area()}\nПериметр: {Perimenter()}\n");
        }
        public static Rectangle Input()
        {
            string name = "Прямоугольник\n";
            WriteLine("\n1 сторона: ");
            int side1 = Convert.ToInt32(ReadLine());
            Write("\n2 сторона: ");
            int side2 = Convert.ToInt32(ReadLine());
            return new Rectangle(name, side1,side2);
        }

    }
}
