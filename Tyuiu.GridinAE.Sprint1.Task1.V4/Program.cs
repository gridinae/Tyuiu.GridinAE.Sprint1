using Tyuiu.GridinAE.Sprint1.Task1.V4.Lib;

Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                     *");
Console.WriteLine("* Задание #1                                                           *");
Console.WriteLine("* Вариант #4                                                           *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные      *");
Console.WriteLine("* данные, вычисляет результат по формуле (x+y)/x*y и печатает          *");
Console.WriteLine("* его на экране.                                                       *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");

double x, y;
Console.WriteLine("Введите значение X: ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y: ");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

var ds = new DataService();
Console.WriteLine(ds.Calculate(x, y));
Console.ReadLine();