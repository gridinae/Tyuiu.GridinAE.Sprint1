namespace Tyuiu.GridinAE.Sprint1.Task6.V16.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task6V16
{
    public bool CheckSpecSymbols(string value) => value.Contains('!') && value.Contains('?');
}
