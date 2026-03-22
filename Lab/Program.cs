using Lab;

public class Program
{
    public static void Main()
    {
        Sorter sorter = new Sorter();
        
        sorter.GenerateControlData();
        
        sorter.PrintAll();
        Console.WriteLine();
        
        sorter.RatingOfTheFilm();
        sorter.CountScores();
        sorter.MostCommonRating();
    }

    private static void Menu()
    {
           
    }
}