using System.Threading;
using NUnit.Framework;

[TestFixture]
public class PerformanceTests
{
    [Test, Timeout(2000)]
    public void LongTask_Test()
    {
        Thread.Sleep(3000);
    }
}
