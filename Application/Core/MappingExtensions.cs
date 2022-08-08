using Application.Assignments;
using Domain;

namespace Application.Core;

public static class MappingExtensions
{
    public static AssignmentDto MapToAssignmentDto(this Assignment assignment)
    {
        if (assignment != null)
        {
            return new AssignmentDto
            {
                Id = assignment.Id,
                Title = assignment.Title,
                Type = assignment.Type,
                Description = assignment.Description,
                FromLocation = assignment.FromLocation,
                ToLocation = assignment.ToLocation,
                Price = assignment.Price,
                Date = assignment.Date,
                Accepted = assignment.Accepted
            };
        }

        return null;
    }

    
}
