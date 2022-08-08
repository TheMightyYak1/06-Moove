using Application.Core;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Assignments;

public class Details
{
    public class Query : IRequest<Result<AssignmentDto>>
    {
        public Guid Id {get; set;}
    }
    public class Handler : IRequestHandler<Query, Result<AssignmentDto>>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task<Result<AssignmentDto>> Handle(Query request, CancellationToken cancellationToken)
        {
            var assignment = await _context.Assignments
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            var assignmentDto = assignment.MapToAssignmentDto();

            return Result<AssignmentDto>.Success(assignmentDto);
        }
    }
}
