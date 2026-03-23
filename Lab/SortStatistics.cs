namespace Lab;

public static class SortStatistics
{
    private static int _copies { get; set; }
    private static int _passes { get; set; }
    private static long _time { get; set; }

    public static void PrintStats()
    {
        Console.WriteLine("Statistics:" +
                          $"\nCopies done: {_copies}" +
                          $"\nPasses done: {_passes}" +
                          $"\nTime elapsed: {_time}ms"
                          );
    }

    public static void UpdatePasses()
    {
        _passes++;
    }
    
    public static void UpdateCopies()
    {
        _copies++;
    }
    
    public static void UpdateTime(long time)
    {
        _time = time;
    }

    public static void Reset()
    {
        _passes = 0;
        _copies = 0;
        _time = 0;
    }
}