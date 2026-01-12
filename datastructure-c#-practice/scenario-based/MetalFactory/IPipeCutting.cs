using System;
public interface IPipeCutting
{
    void InitializePriceChart();
    int GetOptimizeRevenue(int rodLength);
    int GetNonOptimizeRevenue(int rodLength);
}