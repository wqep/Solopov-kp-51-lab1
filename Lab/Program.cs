using Lab;

public class Program
{
    public static void Main()
    {
        Sorter sorter = new Sorter();
        
        Menu(sorter);
    }

    private static void Menu(Sorter sorter)
    {
        while (true)
        {
            Console.Write("||Main Menu||" +
                          "\n1) Initialize/Reset(if already initialized) collection" +
                          "\n2) Add a record to the collection" +
                          "\n3) Remove a record from the collection" +
                          "\n4) Print all elements in the collection" +
                          "\n5) Generate Control Data" +
                          "\n6) Sort collection" +
                          "\n7) Rating of the film" +
                          "\n8) Count ratings" +
                          "\n9) Find most common rating/s" +
                          "\n10) Find median of ratings" +
                          "\n11) Print stats of sorting" +
                          "\n0) Exit" +
                          "\n\n-->Enter: "
            );
           
            string input = Console.ReadLine();
            
            if (input == "1")
            {
                sorter.InitCollection();
            }
            
            else if (input == "2")
            {
                Console.Write("-->Enter the id of the record: ");
                int id = int.Parse(Console.ReadLine());
                
                Console.Write("-->Enter title of the film: ");
                string title = Console.ReadLine();
                
                Console.Write("-->Enter username: ");
                string username = Console.ReadLine();
                
                Console.Write("-->Enter the rating for the film: ");
                int rating = int.Parse(Console.ReadLine());
                
                sorter.AddRecord(new Record(id, title, username, rating));
            }
            
            else if (input == "3")
            {
                Console.Write("-->Enter id of a record to remove: ");
                sorter.RemoveRecord(int.Parse(Console.ReadLine()));
            }
            
            else if (input == "4")
            {
                sorter.PrintAll();
            }
            
            else if (input == "5")
            {
                sorter.GenerateControlData();
            }
            
            else if (input == "6")
            {
                sorter.SortCollection();
            }
            
            else if (input == "7")
            {
                sorter.RatingOfTheFilm();
            }
            
            else if (input == "8")
            {
                sorter.CountRatings();
            }
            else if (input == "9")
            {
                sorter.MostCommonRating();
            }
            
            else if (input == "10")
            {
                sorter.FindMedian();
            }
            
            else if (input == "11")
            {
                SortStatistics.PrintStats();
            }
            
            if (input == "0")
            {
                break;
            }
            
            Console.WriteLine();
        }
    }
}