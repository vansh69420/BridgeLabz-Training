using NUnit.Framework;
using System.IO;

[TestFixture]
public class FileProcessorTests
{
    string file = "test.txt";
    FileProcessor fp = new FileProcessor();

    [Test]
    public void File_Write_Read_Test()
    {
        fp.WriteToFile(file, "Hello");
        Assert.IsTrue(File.Exists(file));
        Assert.AreEqual("Hello", fp.ReadFromFile(file));
    }

    [Test]
    public void File_Not_Found_Test()
    {
        Assert.Throws<IOException>(() => fp.ReadFromFile("nofile.txt"));
    }
}
