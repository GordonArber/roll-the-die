using System;

public class Player
{
    readonly Random _rand = new();
    public int RollDie()
    {
        const int minNum = 1;
        const int maxNum = 18;
        
        return _rand.Next(minNum, maxNum + 1);
    }

    public double GenerateSpellStrength()
    {
        const double minNum = 0.0;
        const double maxNum = 100.0;

        return _rand.NextDouble() * (maxNum - minNum) + minNum;
    }
}
