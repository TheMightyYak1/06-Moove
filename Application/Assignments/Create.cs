using Application.Core;
using Domain;
using MediatR;
using Persistence;

namespace Application.Assignments;
public class Create
{
    public class Command : IRequest<Result<Unit>>
    {
        public Assignment Assignment { get; set; }
    }

    public class Handler : IRequestHandler<Command, Result<Unit>>
    {
        private readonly DataContext _context;
        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
        {
            _context.Assignments.Add(request.Assignment);

            var result = await _context.SaveChangesAsync() > 0;

            if (!result) return Result<Unit>.Failure("Failed to create assignment");

            return Result<Unit>.Success(Unit.Value);
        }
    }

}
