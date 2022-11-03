namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShoudConvertDecimalToInt()
    {
        decimal valor = 279.98m;
        var cents = valor.ToCents();

        Assert.AreEqual(27998, cents);
    }
}