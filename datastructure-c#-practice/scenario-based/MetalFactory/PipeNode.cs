using System;
public class PipeNode
{
    private int Length;
    private int Price;
    private PipeNode next;

    public PipeNode(int length, int price)
    {
        this.Length = length;
        this.Price = price;
        this.next = null;
    }

    public int GetLength()
    {
        return Length;
    }
    public void SetLength(int length)
    {
        Length = length;
    }
    public int  GetPrice()
    {
        return Price;
    }
    public void SetPrice(int price)
    {
        Price = price;
    }

    public PipeNode GetNext()
    {
        return next;
    }
    public void SetNext(PipeNode next)
    {
        this.next = next;
    }

    public override string ToString()
    {
        return $"Length: {Length}, Price: {Price}";
    }
}