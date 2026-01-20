using System;
public class CrackerMain
{
    static void Main()
    {
        CrackerUtilityImpl utility = new CrackerUtilityImpl();
        CrackerMenu menu = new CrackerMenu(utility);
        menu.ShowMenu();
    }
}
