using Microsoft.AspNetCore.Identity;

namespace Domain;
public class User : IdentityUser
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Photo { get; set; }
    public int Rating { get; set; }
    public ICollection<Assignment> Assignments { get; set; }
}