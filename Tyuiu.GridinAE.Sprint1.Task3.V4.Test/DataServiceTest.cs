namespace Tyuiu.GridinAE.Sprint1.Task3.V4.Test;
using Tyuiu.GridinAE.Sprint1.Task3.V4.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService dataService = new DataService();
        Assert.AreEqual(dataService.PurchaseAmount(2.75, 0.5, 7), 22.75);
    }
}