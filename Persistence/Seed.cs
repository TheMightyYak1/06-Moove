using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence;
public class Seed
{
    public static async Task SeedData(DataContext context)
    {
        if (!context.Assignments.Any())
        {
            // var users = new List<User>
            // {
            //     new User
            //     {
            //         FirstName = "Bob",
            //         LastName = "Burns",
            //         UserName = "bob",
            //         Email = "bob@test.com"
            //     },
            //     new User
            //     {
            //         FirstName = "Jane",
            //         LastName = "Johnson",
            //         UserName = "jane",
            //         Email = "jane@test.com"
            //     },
            //     new User
            //     {
            //         FirstName = "Tom",
            //         LastName = "Tate",
            //         UserName = "tom",
            //         Email = "tom@test.com"
            //     },
            // };

            // foreach (var user in users)
            // {
            //     await userManager.CreateAsync(user, "Pa$$w0rd");
            // }

            var assignments = new List<Assignment>
            {
                new Assignment
                {
                    Title = "Couch Bris to GC",
                    Type = "ToMove",
                    Description = "Need a couch from bris to gc",
                    FromLocation = "Brisbane",
                    ToLocation = "Gold Coast",
                    Price = 50,
                    Date = DateTime.UtcNow.AddMonths(+1),
                    Accepted = false
                },
                new Assignment
                {
                    Title = "Car cairns to darwin",
                    Type = "ToMove",
                    Description = "Need a car moved from cairns to darwin",
                    FromLocation = "Cairns",
                    ToLocation = "Darwin",
                    Price = 500,
                    Date = DateTime.UtcNow.AddMonths(+2),
                    Accepted = false
                },
                new Assignment
                {
                    Title = "Driving from Perth to Adelaide",
                    Type = "Spare Seat",
                    Description = "2 spare seats from Perth to Adelaide",
                    FromLocation = "Perth",
                    ToLocation = "Adelaide",
                    Price = 100,
                    Date = DateTime.UtcNow.AddMonths(+1),
                    Accepted = false
                }
            };

            // var reviews = new List<Review>
            // {
            //     new Review
            //     {
            //         Author = users[0],
            //         Body = "Really good!",
            //         Rating = 5
            //     },
            //     new Review
            //     {
            //         Author = users[2],
            //         Body = "Best! Came on time",
            //         Rating = 5
            //     }
            // };

            await context.Assignments.AddRangeAsync(assignments);
            await context.SaveChangesAsync();
        }
    }
}
