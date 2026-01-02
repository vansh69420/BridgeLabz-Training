using System;
class LuckyDrawService
{
    public bool IsWinner(int num)
    {
        return num % 3 == 0 || num % 5 == 0;
    }
}