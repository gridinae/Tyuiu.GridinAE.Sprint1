namespace Tyuiu.GridinAE.Sprint1.Task5.V5.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task5V5
{
    public int Calculate(double x)
    {
        return ((int)((x - Math.Truncate(x)) * 10)) % 10;
    }
}
