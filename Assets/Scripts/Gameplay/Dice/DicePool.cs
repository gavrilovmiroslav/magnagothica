
using System;
using System.Collections.Generic;

public class DicePool
{
    private readonly Queue<int> Remaining;
    private readonly List<int> Discarded = new List<int>();

    public DicePool()
    {
        var list = new List<int>();
        for (int n = 0; n < 3; n++)
        {
            for (int i = 1; i <= 6; i++)
            {
                list.Add(i);
            }
        }

        list.Shuffle();
        Remaining = new Queue<int>(list);
    }

    public int Next()
    {
        if (Remaining.TryDequeue(out int result))
        {
            return result;
        }
        else
        {
            Discarded.Shuffle();
            foreach (int i in Discarded)
            {
                Remaining.Enqueue(i);
            }
            Discarded.Clear();
            return Remaining.Dequeue();
        }
    }

    public int Roll(int n)
    {
        if (n < 1)
        {
            return Math.Min(Next(), Next());
        }
        else
        {
            var roll = Next();
            for (int i = 0; i < n - 1; i++)
            {
                roll = Math.Max(roll, Next());
            }
            return roll;
        }
    }
}