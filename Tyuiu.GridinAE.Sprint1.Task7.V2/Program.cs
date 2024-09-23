using Tyuiu.GridinAE.Sprint1.Task7.V2.Lib;

Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *");
Console.WriteLine("* Задание #7                                                           *");
Console.WriteLine("* Вариант #2                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая вычисляет математическое                 *");
Console.WriteLine("* выражение по исходным значениям данных, вводимых пользователем.      *");
Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                           *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");

Console.WriteLine("Введите X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().Calculate(x, y));

Console.ReadKey();