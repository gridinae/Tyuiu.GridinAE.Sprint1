using Tyuiu.GridinAE.Sprint1.Task5.V5.Lib;

Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                           *");
Console.WriteLine("* Задание #5                                                           *");
Console.WriteLine("* Вариант #5                                                           *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая решает следующую задачу:                 *");
Console.WriteLine("* Присвоить целой переменной d первую цифру из дробной части           *");
Console.WriteLine("* положительного вещественного числа x.                                *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: x = 21341.1239801                                   *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

var d = new DataService().Calculate(21341.1239801);
Console.WriteLine($"d = {d}");