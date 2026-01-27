using System;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute { }

class Worker
{
    [LogExecutionTime]
    public void DoWork()
    {
        for (int i = 0; i < 1000000; i++) { }
    }
}

class LogExecutionTime
{
    static void Main()
    {
        Worker w = new Worker();
        MethodInfo method = typeof(Worker).GetMethod("DoWork");

        Stopwatch sw = Stopwatch.StartNew();
        method.Invoke(w, null);
        sw.Stop();

        Console.WriteLine("Execution Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
