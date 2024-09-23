namespace Tyuiu.GridinAE.Sprint1.Task6.V16.Test;
using Tyuiu.GridinAE.Sprint1.Task6.V16.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValiCheckSpecSymbols()
    {
        var dataService = new DataService();
        Assert.AreEqual(false, dataService.CheckSpecSymbols("Aut!sm123"));
        Assert.AreEqual(true, dataService.CheckSpecSymbols("cock?! balls?!"));
    }
}