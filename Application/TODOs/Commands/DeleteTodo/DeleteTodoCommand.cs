using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.TODOs.Commands.DeleteTodo;

public sealed record DeleteTodoCommand(Guid Id) : IRequest
{
}
