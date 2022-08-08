using Application.Assignments;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers;

public class AssignmentsController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetAssignments()
    {
        return HandleResult(await Mediator.Send(new List.Query{}));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAssignment(Guid id)
    {
        return HandleResult(await Mediator.Send(new Details.Query{Id = id}));
    }

    [HttpPost]
    public async Task<IActionResult> CreateAssignment(Assignment assignment)
    {
        return HandleResult(await Mediator.Send(new Create.Command{Assignment = assignment}));
    }

    // to create authorise policy for assignment author
    [HttpDelete]
    public async Task<IActionResult> DeleteAssignment(Guid id)
    {
        return HandleResult(await Mediator.Send(new Delete.Command{Id = id}));
    }
}
