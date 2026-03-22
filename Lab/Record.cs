using System.ComponentModel.DataAnnotations;

namespace Lab;

public class Record(int reviewId, string movieTitle, string userName, int rating)
    : IComparable
{
    private int _reviewId { get; set; } = reviewId;
    private string _movieTitle { get; set; } = movieTitle;
    private string _userName { get; set; } = userName;
    private int _rating { get; set; } = rating;

    public int GetId()
    {
        return _reviewId;
    }
    
    public int GetRating()
    {
        return _rating;
    }
    
    public int CompareTo(object? obj)
    {
        Record other = obj as Record;
        
        return _rating.CompareTo(other.GetRating());
    }

    public override string ToString()
    {
        return $"ID: {_reviewId} || Title: {_movieTitle} || User name: {_userName} || Rating: {_rating}";
    }
}