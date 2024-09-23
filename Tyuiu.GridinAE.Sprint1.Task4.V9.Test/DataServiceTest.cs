namespace Tyuiu.GridinAE.Sprint1.Task4.V9.Test;
using Tyuiu.GridinAE.Sprint1.Task4.V9.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        var dataService = new DataService();
        Assert.AreEqual(0.386, dataService.Calculate(10, 2));
    }
}