using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.TODOs.Commands.Create;

public sealed record CreateTodoCommand(string Title) : IRequest<Guid>
{
}
