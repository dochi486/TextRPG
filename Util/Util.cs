namespace TextRPG.Util;

public static class Util
{
    public static int GetRandom(int max) => new Random().Next(1, max);
}