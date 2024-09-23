namespace Tyuiu.GridinAE.Sprint1.Task5.V5.Test;
using Tyuiu.GridinAE.Sprint1.Task5.V5.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalc()
    {
        Assert.AreEqual(5, new DataService().Calculate(32.597));
    }
}