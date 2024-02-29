using System;
using static System.Console;

namespace _18_1
{
    /// <summary>
    /// Наследуемый класс квадрата
    /// </summary>
    class Square : Figure
    {
        /// <summary>
        /// Поле стороны
        /// </summary>
        private int side;
        public Square() { }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"> Название </param>
        /// <param name="side"> 1/2 Стороны </param>
        public Square(string name, int side) : base(name)
        {
            this.side = side;
        }
        /// <summary>
        /// Св-во поля сторон
        /// </summary>
        public int Side { get => side; set => side = value; }
        // <summary>
        /// Метод вычисления площади
        /// </summary>
        /// <returns>Площадь</returns>
        public override double Area()
        {
            return side * side;
        }
        /// <summary>
        /// Метод вычисления периметра
        /// </summary>
        /// <returns>Периметр</returns>
        public override double Perimenter()
        {
            return (side + side) * 2;
        }
        /// <summary>
        /// Виртуальный метод вывода информации
        /// </summary>
        public override void Print()
        {
            base.Print();
            WriteLine($"Сторона 1/2: {side}\nПлощадь: {Area()}\nПериметр: {Perimenter()}\n");
        }
        public static Square Input()
        {
            string name = "Квадрат\n";
            Write("Стороны: ");
            int side1 = Convert.ToInt32(ReadLine());
            WriteLine();
            return new Square(name, side1);
        }
    }
}
