namespace Tyuiu.GridinAE.Sprint1.Task4.V9.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task4V9
{
    public double Calculate(double x, double y) => Math.Round(Math.Log(x * y, Math.E) / (x - Math.Sqrt(1 + y*y)), 3);
}
