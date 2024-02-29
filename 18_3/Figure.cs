using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_1
{
    /// <summary>
    /// Абстрактный класс описывающий фигуры 
    /// </summary>
    abstract class Figure
    {
        /// <summary>
        /// Поле название фигуры 
        /// </summary>
        private string name;
        public Figure() { }
        /// <summary>
        /// Конструктор с параметром 
        /// </summary>
        /// <param name="name">Название фигуры</param>
        public Figure(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Св-во поля названия
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Абст. метод вычисления площади
        /// </summary>
        /// <returns>Площадь</returns>
        public abstract double Area();
        /// <summary>
        /// Абст. метод вычисления периметра
        /// </summary>
        /// <returns>Периметр</returns>
        public abstract double Perimenter();
        /// <summary>
        /// Виртуальный метод вывода информации
        /// </summary>
        virtual public void Print()
        {
            Write($"Название фигуры: {name}\n");
        }
    }
}
