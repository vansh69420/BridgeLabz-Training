using System;

public class BrowserUtilityImpl : IBrowserOperations
{
    private UniversalLinkedList history = new UniversalLinkedList();
    private UniversalLinkedList closedTabs = new UniversalLinkedList();

    private UniversalLinkedList.Node current;

    public void VisitPage()
    {
        Console.Write("Enter URL: ");
        string url = Console.ReadLine();

        BrowserPage page = new BrowserPage();
        page.SetUrl(url);

        history.AddLast(page);

        if (current == null)
            current = history.GetHead();
        else
            current = current.GetNext();
    }

    public void Back()
    {
        if (current != null && current.GetPrev() != null)
            current = current.GetPrev();
        else
            Console.WriteLine("No previous page.");
    }

    public void Forward()
    {
        if (current != null && current.GetNext() != null)
            current = current.GetNext();
        else
            Console.WriteLine("No forward page.");
    }

    public void CloseTab()
    {
        if (current == null)
        {
            Console.WriteLine("No tab to close.");
            return;
        }

        closedTabs.AddLast(current.GetData());

        UniversalLinkedList.Node prev = current.GetPrev();
        UniversalLinkedList.Node next = current.GetNext();

        if (prev != null)
            prev.SetNext(next);
        if (next != null)
            next.SetPrev(prev);

        current = prev != null ? prev : next;
    }

    public void RestoreTab()
    {
        object data = closedTabs.RemoveLast();

        if (data == null)
        {
            Console.WriteLine("No closed tabs to restore.");
            return;
        }

        history.AddLast(data);
        current = history.GetHead();

        while (current.GetNext() != null)
            current = current.GetNext();
    }

    public void ShowCurrentPage()
    {
        if (current == null)
            Console.WriteLine("No active page.");
        else
            Console.WriteLine("Current Page → " + (BrowserPage)current.GetData());
    }
}
