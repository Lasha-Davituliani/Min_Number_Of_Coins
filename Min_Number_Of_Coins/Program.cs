using System;
public class CoinChange
{
    public static int MinSplit(int amount)
    {
        int[] coins = { 50, 20, 10, 5, 1 };
        int count = 0;

        foreach (int coin in coins)
        {
            int coinCount = amount / coin;
            count += coinCount;
            amount %= coin;
        }

        return count;
    }

    public static void Main(string[] args)
    {
        int amount = 17;
        int minCoins = MinSplit(amount);

        Console.WriteLine($"Minimum number of coins needed to make {amount} tetri is: {minCoins}");
    }
}
