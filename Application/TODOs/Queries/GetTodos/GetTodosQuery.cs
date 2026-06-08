using Domain.Todos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.TODOs.Queries.GetTodos;

public sealed record GetTodosQuery : IRequest<IEnumerable<Todo>>
{
}
