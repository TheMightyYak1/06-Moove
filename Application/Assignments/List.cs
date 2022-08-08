using Application.Core;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Assignments;

public class List
{
    public class Query : IRequest<Result<List<AssignmentDto>>>
    {

    }
    public class Handler : IRequestHandler<Query, Result<List<AssignmentDto>>>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task<Result<List<AssignmentDto>>> Handle(Query request, CancellationToken cancellationToken)
        {
            var assignments = await _context.Assignments
                .ToListAsync();

            var assignmentsDto = assignments
                .Select(x => x.MapToAssignmentDto())
                .ToList();

            return Result<List<AssignmentDto>>.Success(assignmentsDto);
        }
    }
}
