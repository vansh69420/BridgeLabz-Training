using System;
using System.Diagnostics;
using System.Reflection;

class Worker
{
    public void Task1()
    {
        for (int i = 0; i < 100000; i++) { }
    }

    public void Task2()
    {
        for (int i = 0; i < 200000; i++) { }
    }
}

class AllMethodsTiming
{
    static void Main()
    {
        Worker obj = new Worker();
        Type t = typeof(Worker);

        foreach (MethodInfo method in t.GetMethods(
            BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
        {
            Stopwatch sw = Stopwatch.StartNew();
            method.Invoke(obj, null);
            sw.Stop();

            Console.WriteLine($"{method.Name} executed in {sw.ElapsedMilliseconds} ms");
        }
    }
}
