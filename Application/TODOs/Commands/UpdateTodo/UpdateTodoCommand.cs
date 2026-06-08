using MediatR;


namespace Application.TODOs.Commands.UpdateTodo;

public sealed record UpdateTodoCommand (Guid Id, string Title, bool Completed) : IRequest
{
}
