using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Figure> figures = new List<Figure>();
                Write("Список доступных фигур: \n");
                Square square1 = new Square("Квадрат", 10);
                Rectangle rectangle1 = new Rectangle("Прямоугольник", 8, 9);
                Circle circle1 = new Circle("Круг", 5);
                figures.Add(square1);
                figures.Add(rectangle1);
                figures.Add(circle1);
                foreach (var elem in figures)
                {
                    elem.Print();
                }
                bool flag = true;
                bool flag2 = true;
                while (flag2)
                {
                    Write("Какое действие вы хотите сделать с фигурой: \n Добавить - 1 \n Изменить объект - 2 \n Удалить объект - 3 \n Вывод объектва - 4 \n Выход - 5 \n Введите цифру: ");
                    int figure = Convert.ToInt32(ReadLine());
                    WriteLine();
                    switch (figure)
                    {
                        case 1:
                            while (flag)
                            {
                                WriteLine("Введите первую букву фигуры (R-rectangle) (S-square) (T-triangle) (C-circle): ");
                                string fig = ReadLine();
                                switch (fig.ToLower())
                                {
                                    case "r":
                                        Rectangle rectangle = new Rectangle(); 
                                        figures.Add(Rectangle.Input());
                                        break;
                                    case "s": 
                                        Square square = new Square();
                                        figures.Add(Square.Input());
                                        break;
                                    case "t": Triangle triangle = new Triangle(); 
                                        figures.Add(Triangle.Input()); 
                                        break;
                                    case "c": Circle circle = new Circle(); 
                                        figures.Add(Circle.Input());
                                        break;
                                    default:Clear(); Write("Вы ввели неправильную букву\n"); flag = false; break;
                                }
                            }
                            foreach (var elem1 in figures)
                            {
                                elem1.Print();
                            }
                            flag = true;
                            break;
                        case 2:
                            while (flag)
                            {

                                Write("Выберите элемент из списка: ");
                                int n = Convert.ToInt32(ReadLine());
                                Write("Введите первую букву фигуры (R-rectangle) (S-square) (T-triangle) (C-circle): ");
                                string fig = ReadLine();
                                switch (fig.ToLower())
                                {
                                     case "r": 
                                        Rectangle rectangle = new Rectangle();
                                        figures[n] = Rectangle.Input();
                                        break;
                                     case "s": 
                                        Square square = new Square(); 
                                        figures[n] = Square.Input();
                                        break;
                                     case "t": 
                                        Triangle triangle = new Triangle();
                                        figures[n] = Triangle.Input();
                                            break;
                                     case "c": 
                                        Circle circle = new Circle(); 
                                        figures[n] = Circle.Input();
                                        break;
                                    default: Clear(); Write("Вы ввели неправильную букву\n"); flag = false; break;
                                }
                                foreach (var elem1 in figures)
                                {
                                    elem1.Print();
                                }
                                flag = false;
                            }
                            flag = true;
                            break;
                        case 3:
                            while (flag)
                            {
                                Write("Введите индекс удаляемого объекта: ");
                                int index = Convert.ToInt32(ReadLine());
                                figures.RemoveAt(index);
                                foreach (var elem1 in figures)
                                {
                                    elem1.Print();
                                }
                                flag = false;
                            }
                            flag = true;
                            break;
                        case 4:
                            while (flag)
                            {
                                Write("Объект над которым будем выполнять действия: ");
                                int elem = Convert.ToInt32(ReadLine());
                                Write("Что вы хотите узнать об объекте:\n Вывод всей информации - 1 \n Введите цифру: ");
                                int  act = Convert.ToInt32(ReadLine());
                                WriteLine();
                                switch (act)
                                {
                                    case 1:
                                        figures[elem].Print();
                                        break;
                                    default: WriteLine("Вы ввели неверную цифру цифру"); flag = false; break;
                                }
                                flag = false;
                            }
                            flag = true;
                            break;
                        case 5: return;
                        default:
                            WriteLine("Вы ввели неверную цифру цифру");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
