using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.TODOs.Commands.Create;

internal class CeateTodoCommandValidator : AbstractValidator<CreateTodoCommand>
{
    public CeateTodoCommandValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .WithMessage("Title is required.")
            .MaximumLength(100)
            .WithMessage("Title must not exceed 100 characters.");

    }
}
