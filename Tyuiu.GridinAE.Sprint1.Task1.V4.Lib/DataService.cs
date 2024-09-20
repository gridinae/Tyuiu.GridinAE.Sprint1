namespace Tyuiu.GridinAE.Sprint1.Task1.V4.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task1V4
{
    public double Calculate(double x, double y)
    {
        return (x + y) / x * y;
    }
}
