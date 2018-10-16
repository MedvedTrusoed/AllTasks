using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Figure
    {
        public abstract void Draw();

    }

    class Program
    {
        //  Напишите заготовку для векторного графического редактора.
        //  Полная версия редактора должна позволять создавать и выводить на экран
        //  такие фигуры как: Линия, Окружность, Прямоугольник, Кольцо.
        //  Заготовка, для упрощения, должна представлять собой консольное приложение с функционалом:
        //⦁	Создать фигуру выбранного типа по произвольным координатам.
        //⦁	Фигуры должны создаваться в общей коллекции(массиве)
        //⦁	Вывести фигуры на экран
        //  (для каждой фигуры вывести на консоль её тип и значения параметров реализовать в методе Draw)
        //  с использованием перегрузки метода Draw

        static void Main(string[] args)
        {
            try
            {
                Figure[] fig = new Figure[4];

                fig[0] = new Rectangle(0, 1, 5, 4);

                fig[1] = new Round(0, 0, 4);

                fig[2] = new Line(1, 5, 4, 5);

                fig[3] = new Ring(10, 5, 2, 5);

                foreach (Figure figure in fig)
                {
                    figure.Draw();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }

        }
    }
}

