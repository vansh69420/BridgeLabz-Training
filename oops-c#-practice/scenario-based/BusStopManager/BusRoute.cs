using System;

class BusRoute
{
    private int totalDistance = 0;
    private int stopDistance = 5;

    public void AddStopDistance()
    {
        totalDistance += stopDistance;
    }

    public int  GetTotalDistance()
    {
        return totalDistance;
    }
}