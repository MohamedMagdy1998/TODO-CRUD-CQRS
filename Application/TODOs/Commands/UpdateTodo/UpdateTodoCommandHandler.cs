using Application.Common.Exceptions;
using Application.Common.Interface;
using Domain.Todos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.TODOs.Commands.UpdateTodo;

public class UpdateTodoCommandHandler : IRequestHandler<UpdateTodoCommand>
{
    private readonly IAppDbContext DbContext;

    public UpdateTodoCommandHandler(IAppDbContext dbContext)
    {
        DbContext = dbContext;
    }
    public async Task Handle(UpdateTodoCommand request, CancellationToken cancellationToken)
    {
        var NewTodo = await DbContext.Todos.FindAsync(request.Id);
        
        if (NewTodo is null)
            throw new NotFoundException(nameof(NewTodo), request.Id);

        NewTodo.Title = request.Title; NewTodo.Completed = request.Completed ;

      

        await DbContext.SaveChangesAsync(cancellationToken);


    }
}
