using System;
public class ParcelUtilityImpl : IParcelService
{
    private UniversalLinkedList list;

    public ParcelUtilityImpl()
    {
        list = new UniversalLinkedList();
    }

    public void CreateDefaultChain()
    {
        list.AddLast(new ParcelStage("Packed"));
        list.AddLast(new ParcelStage("Shipped"));
        list.AddLast(new ParcelStage("In Transit"));
        list.AddLast(new ParcelStage("Delivered"));
    }

    // TRUE intermediate insertion
    public void AddIntermediateStage(string afterStage, string newStage)
    {
        bool inserted = list.AddAfter(
            new ParcelStage(afterStage),
            new ParcelStage(newStage)
        );

        if (!inserted)
            Console.WriteLine("Stage not found. Cannot insert.");
    }

    // CLEAR forward tracking
    public void TrackForward()
    {
        UniversalLinkedList.Node current = list.GetHead();

        if (current == null)
        {
            Console.WriteLine("Parcel LOST (null chain)");
            return;
        }

        Console.WriteLine("\nForward Parcel Tracking:");
        while (current != null)
        {
            Console.WriteLine("→ " + current.GetData());
            current = current.GetNext();   // FORWARD traversal
        }
    }

    public void MarkParcelLost()
    {
        while (!list.IsEmpty())
            list.RemoveFirst();

        Console.WriteLine("Parcel marked LOST. Chain removed.");
    }
}
