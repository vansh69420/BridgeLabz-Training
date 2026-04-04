using System;
using System.Reflection;

interface IGreeting
{
    void SayHello();
}

class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}

class LoggingProxy : DispatchProxy
{
    private object _target;

    public static T Create<T>(T target)
    {
        object proxy = Create<T, LoggingProxy>();
        ((LoggingProxy)proxy)._target = target;
        return (T)proxy;
    }

    protected override object Invoke(MethodInfo method, object[] args)
    {
        Console.WriteLine("Calling method: " + method.Name);
        return method.Invoke(_target, args);
    }
}

class LoggingProxy
{
    static void Main()
    {
        IGreeting greet = LoggingProxy.Create<IGreeting>(new Greeting());
        greet.SayHello();
    }
}
