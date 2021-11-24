using System;
using System.Linq;

public class Kata
{
    public static int PositiveSum(int[] array)
    {
        var total = 0;
        foreach (var num in array)
        {
            if (num >= 0)
            {
                total += num;
            }
        }
        return total;
    }
}