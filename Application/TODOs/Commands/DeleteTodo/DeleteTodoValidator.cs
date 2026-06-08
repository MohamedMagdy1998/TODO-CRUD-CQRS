using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.TODOs.Commands.DeleteTodo;

public class DeleteTodoValidator : AbstractValidator<DeleteTodoCommand>
{
    public DeleteTodoValidator()
    {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id is required.");
    }
}
