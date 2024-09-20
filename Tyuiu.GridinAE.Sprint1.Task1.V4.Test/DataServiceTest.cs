namespace Tyuiu.GridinAE.Sprint1.Task1.V4.Test;
using Tyuiu.GridinAE.Sprint1.Task1.V4.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidateExpression()
    {
        var ds = new DataService();
        var result = ds.Calculate(10, 2);
        Assert.AreEqual(2.4, result);
    }
}