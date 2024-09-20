using Tyuiu.GridinAE.Sprint1.Task0.V2.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
// Длина строки 75 символов
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                     *");
Console.WriteLine("* Задание #0                                                           *");
Console.WriteLine("* Вариант #0                                                           *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, которая вычисляет выражение 10 / (2 + 3)         *");
Console.WriteLine("* и печатает результат на экране.                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* 10 / (2 + 3)                                                         *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(ds.Calculate());
Console.ReadLine();