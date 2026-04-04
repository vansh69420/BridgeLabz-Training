using System;
class PipeUtilityImpl: IPipeCutting
{
    private PipeNode head;

    public void InitializePriceChart()
    {
        head = new PipeNode(1, 1);
        PipeNode current = head;

        current.SetNext(new PipeNode(2, 5));
        current = current.GetNext();

        current.SetNext(new PipeNode(3, 8));
        current = current.GetNext();

        current.SetNext(new PipeNode(4, 9));
        current = current.GetNext();

        current.SetNext(new PipeNode(5, 34));
        current = current.GetNext();

        current.SetNext(new PipeNode(6, 60));
        current = current.GetNext();

        current.SetNext(new PipeNode(7, 40));
        current = current.GetNext();

        current.SetNext(new PipeNode(8, 50));
    }

    public int GetOptimizeRevenue(int rodLength)
    {
        if(rodLength == 0)
        {
            return 0;
        }
        int maxRevenue = 0;
        PipeNode temp = head;
        while(temp != null && temp.GetLength() <= rodLength)
        {
            int revenue = temp.GetPrice() + GetOptimizeRevenue(rodLength - temp.GetLength());
            if(revenue > maxRevenue)
            {
                maxRevenue = revenue;
            }
            temp = temp.GetNext();
        }
        return maxRevenue;
    }

    public int GetNonOptimizeRevenue(int rodLength)
    {
        PipeNode temp = head;
        while(temp != null)
        {
            if(temp.GetLength() == rodLength)
            {
                return temp.GetPrice();
            }
            temp = temp.GetNext();
        }
        return 0;
    }
}