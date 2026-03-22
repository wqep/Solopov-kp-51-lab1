namespace Lab;

public class Sorter
{
    private Record[] _collection;
    private int _counter = 0;

    public void InitCollection()
    {
        if (_collection != null) _collection = new Record[50];
    }

    public void AddRecord(Record record)
    {
        if (_collection == null) return;
        
        _collection[_counter] = record;
        _counter++;
    }

    public void RemoveRecord(int id)
    {
        if (_collection == null) return;
        
        for (int i = 0; i < _counter; i++)
        {
            if (_collection[i].GetId() == id)
            {
                _collection[i] = null;

                for (int j = i; j < _counter - 1; j++)
                {
                    _collection[j] = _collection[j + 1];
                }

                _counter--;
                return;
            }
        }
    }

    public void PrintAll()
    {
        foreach (Record record in _collection)
        {
            Console.WriteLine(record);
        }
    }

    public void GenerateControlData()
    {
        _collection = [
            new Record(0, "Crazy Film 2", "CrazyReviewer76", 10),
            new Record(1, "Crazy Film 2", "Crazzy89", 4),
            new Record(2, "Crazy Film 2", "CrazyReview42", 8),
            new Record(3, "Crazy Film 2", "Reviewer101", 10),
            new Record(4, "Crazy Film 2", "Crasher99", 9),
            new Record(5, "Crazy Film 2", "Craz12", 5),
            new Record(6, "Crazy Film 2", "86", 7),
            new Record(7, "Crazy Film 2", "FilmLover65", 8),
            new Record(8, "Crazy Film 2", "Thoughtful77", 1),
            new Record(9, "Crazy Film 2", "Unlucky4", 8),
            new Record(10, "Crazy Film 2", "Death13", 9),
            new Record(11, "Crazy Film 2", "UnbreakableDiamond04", 10),
        ];

        _counter = 11;
    }

    public void SortCollection()
    {
        if (_collection == null) return;

        int min = 11;
        int max = 0;

        for (int i = 0; i < _counter; i++)
        {
            if (_collection[i].GetRating() < min)
            {
                min = _collection[i].GetRating();
            }
            
            else if (_collection[i].GetRating() > max)
            {
                max = _collection[i].GetRating();
            }
        }
        
        int[] count = new int[max - min + 1];

        for (int i = 0; i < _collection.Length; i++)
        {
            count[_collection[i].GetRating() - min]++;
        }
        
        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }
        
        Record[] output = new Record[_collection.Length];
        
        for (int i = _collection.Length - 1; i >= 0; i--)
        {
            int currentRating = _collection[i].GetRating();
            int countIndex = currentRating - min;
            
            int targetPosition = count[countIndex] - 1;
            output[targetPosition] = _collection[i];
            
            count[countIndex]--;
        }
        
        Array.Copy(output, _collection, _collection.Length);
    }

    public void RatingOfTheFilm()
    {
        if (_collection == null) return;

        int rating = 0;

        for (int i = 0; i < _collection.Length; i++)
        {
            rating += _collection[i].GetRating();
        }
        
        Console.WriteLine($"Rating of the film is: {rating / _collection.Length}");
    }

    public void CountScores()
    {
        if (_collection == null) return;

        int min = 11;
        int max = 0;

        for (int i = 0; i < _counter; i++)
        {
            if (_collection[i].GetRating() < min)
            {
                min = _collection[i].GetRating();
            }
            
            else if (_collection[i].GetRating() > max)
            {
                max = _collection[i].GetRating();
            }
        }
        
        int[] count = new int[max - min + 1];

        for (int i = 0; i < _collection.Length; i++)
        {
            count[_collection[i].GetRating() - min]++;
        }

        for (int i = 0; i < count.Length; i++)
        {
            Console.WriteLine($"{i + 1} Rating appeared {count[i]} times.");
        }
    }

    public void MostCommonRating()
    {
        if (_collection == null) return;

        int min = 11;
        int max = 0;

        for (int i = 0; i < _counter; i++)
        {
            if (_collection[i].GetRating() < min)
            {
                min = _collection[i].GetRating();
            }
            
            else if (_collection[i].GetRating() > max)
            {
                max = _collection[i].GetRating();
            }
        }
        
        int[] count = new int[max - min + 1];

        for (int i = 0; i < _collection.Length; i++)
        {
            count[_collection[i].GetRating() - min]++;
        }

        List<int> commonRating = new List<int>();

        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] == count.Max())
            {
                commonRating.Add(i + 1); 
            }
        }
        
        Console.Write($"The most common rating is: ");
        
        for (int i = 0; i < commonRating.Count - 1; i++)
        {
            Console.Write($"[{commonRating[i]}], ");
        }
        
        Console.WriteLine($"[{commonRating[^1]}].");
    }
}