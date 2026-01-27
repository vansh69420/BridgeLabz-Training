[TestFixture]
public class NumberUtilsTests
{
    NumberUtils utils = new NumberUtils();

    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven_Test(int num, bool expected)
    {
        Assert.AreEqual(expected, utils.IsEven(num));
    }
}
