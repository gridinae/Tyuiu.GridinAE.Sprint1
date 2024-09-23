using Tyuiu.GridinAE.Sprint1.Task4.V9.Lib;

Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Class Math                                                     *");
Console.WriteLine("* Задание #4                                                           *");
Console.WriteLine("* Вариант #9                                                           *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя               *");
Console.WriteLine("* исходные данные, вычисляет результат по формуле                      *");
Console.WriteLine("* и печатает его на экране. Ответ округлите до 3 знаков после запятой. *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");

double x, y;
Console.WriteLine("Введите X: ");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Y: ");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().Calculate(x, y));


Console.ReadKey();