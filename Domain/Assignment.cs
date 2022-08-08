namespace Domain;
public class Assignment
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Type { get; set; } // can change to enum later
    public string Description { get; set; }
    public string FromLocation { get; set; }
    public string ToLocation { get; set; }
    public int Price { get; set; }
    public DateTime Date { get; set; }
    public bool Accepted { get; set; }
}