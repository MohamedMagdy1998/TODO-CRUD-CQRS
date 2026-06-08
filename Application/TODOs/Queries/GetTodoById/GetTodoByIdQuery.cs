using Domain.Todos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.TODOs.Queries.GetTodoById;

public sealed record GetTodoByIdQuery(Guid Id) : IRequest<Todo>
{
}
