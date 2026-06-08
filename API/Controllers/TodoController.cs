using API.Requests;
using Application.TODOs.Commands.Create;
using Application.TODOs.Commands.DeleteTodo;
using Application.TODOs.Commands.UpdateTodo;
using Application.TODOs.Queries.GetTodoById;
using Application.TODOs.Queries.GetTodos;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoController : ControllerBase
{
    private readonly ISender mediator;

    public TodoController(ISender mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await mediator.Send(new GetTodosQuery());

        return Ok(result);
    }

    [HttpGet("{todoId:guid}", Name = "GetTodoById")]
    public async Task<IActionResult> Get(Guid todoId)
    {
        var result = await mediator.Send(new GetTodoByIdQuery(todoId));

        return result is null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateTodoRequest request)
    {
        var command = new CreateTodoCommand(request.Title);

        var todoId = await mediator.Send(command);

        return CreatedAtRoute("GetTodoById", new { todoId }, null);
    }

    [HttpPut("{todoId:guid}")]
    public async Task<IActionResult> Put(Guid todoId, UpdateTodoRequest request)
    {
        var command = new UpdateTodoCommand(todoId, request.Title, request.Completed);

        await mediator.Send(command);

        return NoContent();
    }

    [HttpDelete("{todoId:guid}")]
    public async Task<IActionResult> Delete(Guid todoId)
    {
        var command = new DeleteTodoCommand(todoId);

        await mediator.Send(command);

        return NoContent();
    }












}
