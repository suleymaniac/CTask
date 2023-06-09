using ConsoleApp3;
using System;


//  Создать приложение, удовлетворяющее требованиям, приведенным в задании.
//  Наследование применять только в тех заданиях, в которых это логически обосновано. 
//  Аргументировать принадлежность классу каждого создаваемого метода. Для каждого класса должно быть не менее 2 свойств.

// Создать объект класса Круг, используя классы Точка, Окружность.
// Методы: задание размеров, изменение радиуса, определение принадлежности точки данному кругу.

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point center = new(0, 0);
            Circumference circumference = new(5);

            Circle circle = new(center, circumference);

            Point somePoint = new(4, 0);

            circle.PrintIsPointInsideCircleToConsole(somePoint);

            circle.DecreaseRadius(4);
            circle.SetPosition(2, 3);

            circle.PrintIsPointInsideCircleToConsole(somePoint);

        }
    }
}