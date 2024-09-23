namespace Tyuiu.GridinAE.Sprint1.Task7.V2.Test;
using Tyuiu.GridinAE.Sprint1.Task7.V2.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckCalcValid()
    {
        DataService dataService = new DataService();
        Assert.AreEqual(-0.042, dataService.Calculate(2, 3));
    }
}