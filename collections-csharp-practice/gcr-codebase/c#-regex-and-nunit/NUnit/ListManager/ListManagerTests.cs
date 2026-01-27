using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class ListManagerTests
{
    ListManager manager;
    List<int> list;

    [SetUp]
    public void Setup()
    {
        manager = new ListManager();
        list = new List<int>();
    }

    [Test]
    public void Add_Test()
    {
        manager.AddElement(list, 10);
        Assert.Contains(10, list);
    }

    [Test]
    public void Remove_Test()
    {
        list.Add(5);
        manager.RemoveElement(list, 5);
        Assert.IsEmpty(list);
    }

    [Test]
    public void Size_Test()
    {
        manager.AddElement(list, 1);
        manager.AddElement(list, 2);
        Assert.AreEqual(2, manager.GetSize(list));
    }
}
