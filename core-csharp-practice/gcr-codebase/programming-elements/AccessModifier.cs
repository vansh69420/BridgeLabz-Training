using System;
class AccessModifier
{
	public static void Main(string[] args)
	{
		PublicClass pub = new PublicClass();
        pub.PublicMethod();
        Console.WriteLine(pub.publicVar);

        InternalClass inter = new InternalClass();
        Console.WriteLine(inter.internalVar);

        BaseClass baseObj = new BaseClass();
        baseObj.ShowBaseData();

        DerivedClass derived = new DerivedClass();
        derived.ShowDerivedData();

	}
	public class PublicClass
	{
		public int publicVar = 10;

		public void PublicMethod()
		{
			Console.WriteLine("Public Method");
		}
	}

	internal class InternalClass
	{
    	internal int internalVar = 20;
	}

	class BaseClass
	{
	    public int publicData = 1;
	    private int privateData = 2;
	    protected int protectedData = 3;
	    internal int internalData = 4;
	    protected internal int protectedInternalData = 5;
	    private protected int privateProtectedData = 6;

	    public void ShowBaseData()
	    {
	        Console.WriteLine("Inside BaseClass:");
	        Console.WriteLine(publicData);
	        Console.WriteLine(privateData);
	        Console.WriteLine(protectedData);
	        Console.WriteLine(internalData);
	        Console.WriteLine(protectedInternalData);
	        Console.WriteLine(privateProtectedData);
	    }
	}

	class DerivedClass : BaseClass
	{
	    public void ShowDerivedData()
	    {
	        Console.WriteLine("\nInside DerivedClass:");
	        Console.WriteLine(publicData);              
	        // Console.WriteLine(privateData);
	        Console.WriteLine(protectedData);           
	        Console.WriteLine(internalData);            
	        Console.WriteLine(protectedInternalData);   
	        Console.WriteLine(privateProtectedData);    
	    }
	}

}