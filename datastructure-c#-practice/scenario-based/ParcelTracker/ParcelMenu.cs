using System;
class ParcelMenu
{
    private IParcelService service;

    public ParcelMenu()
    {
        service = new ParcelUtilityImpl();
        service.CreateDefaultChain();
    }

    public void DisplayMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("\n1. Add Intermediate Checkpoint");
            Console.WriteLine("2. Track Parcel Forward");
            Console.WriteLine("3. Mark Parcel Lost");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Insert after stage: ");
                    string after = Console.ReadLine();

                    Console.Write("New stage name: ");
                    string stage = Console.ReadLine();

                    service.AddIntermediateStage(after, stage);
                    break;

                case 2:
                    service.TrackForward();
                    break;

                case 3:
                    service.MarkParcelLost();
                    break;

                case 4:
                    Console.WriteLine("Exit");
                    break;
            }
        } while (choice != 4);
    }
}
