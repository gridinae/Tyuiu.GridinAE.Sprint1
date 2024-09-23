using Tyuiu.GridinAE.Sprint1.Task6.V16.Lib;


Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #1                                                            *");
Console.WriteLine("* Тема: Работа со строками класс String                                *");
Console.WriteLine("* Задание #6                                                           *");
Console.WriteLine("* Вариант #16                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу: пользователь вводит текст.                       *");
Console.WriteLine("* Проверить, что в строке есть восклицание (!) и вопрос (?).           *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("************************************************************************");

Console.WriteLine("Введите строку: ");
string input;
input = Console.ReadLine();

string output = new DataService().CheckSpecSymbols(input) ? "В строке есть символы '!' и '?'" : "В строке нету сразу и символа '!', и символа '?'";

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");
Console.WriteLine(output);

Console.ReadKey();