using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_1
{
    /// <summary>
    /// Наследуемый класс круга
    /// </summary>
    class Circle :Figure
    {
        const double PI = 3.14;
        /// <summary>
        /// Поле радиуса
        /// </summary>
        private int r;
        public Circle() { }
        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="name"> Название </param>
        /// <param name="r"> Радиус </param>
        public Circle(string name,int r):base(name)
        {
            this.r = r;
        }
        /// <summary>
        /// Свойство
        /// </summary>
        public int R { get => r; set => r = value; }
        /// <summary>
        /// Метод вычисления площади
        /// </summary>
        /// <returns>Площадь</returns>
        public override double Area()
        {
            return PI*Math.Pow(r,2);
        }
        /// <summary>
        /// Метод вычисления периметра
        /// </summary>
        /// <returns>Периметр</returns>
        public override double Perimenter()
        {
            return 2 * PI * r;
        }
        /// <summary>
        /// Виртуальный метод вывода информации
        /// </summary>
        public override void Print()
        {
            base.Print();
            WriteLine($"Радиус: {r}\nПлощадь: {Area()}\nПериметр: {Perimenter()}\n");
        }
        public static Circle Input()
        {
            string name = "Круг\n";
            Write("\nРадиус: ");
            int r = Convert.ToInt32(ReadLine());
            return new Circle(name, r);
        }

    }
}
