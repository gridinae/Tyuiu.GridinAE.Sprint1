namespace Tyuiu.GridinAE.Sprint1.Task2.V29.Test;
using Tyuiu.GridinAE.Sprint1.Task2.V29.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        var ds = new DataService();
        Assert.AreEqual(2, ds.ConvertSecondsToMinutes(120));
    }
}