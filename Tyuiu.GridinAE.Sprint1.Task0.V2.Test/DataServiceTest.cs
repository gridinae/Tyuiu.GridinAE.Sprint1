namespace Tyuiu.GridinAE.Sprint1.Task0.V2.Test;

using System.ComponentModel.DataAnnotations;
using Tyuiu.GridinAE.Sprint1.Task0.V2.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        var ds = new DataService();
        var res = ds.Calculate();
        Assert.AreEqual(3 / 3 * 2 + 12 / 4 / 3 - 2, res);
    }
}