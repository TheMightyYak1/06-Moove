namespace Domain;

public class Review
{
    public Guid Id { get; set; }
    public User Author { get; set; }
    public string Body { get; set; }
    public int Rating { get; set; }
}