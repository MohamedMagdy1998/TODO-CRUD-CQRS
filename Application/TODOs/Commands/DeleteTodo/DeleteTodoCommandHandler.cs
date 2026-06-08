using Application.Common.Exceptions;
using Application.Common.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.TODOs.Commands.DeleteTodo;

public class DeleteTodoCommandHandler : IRequestHandler<DeleteTodoCommand>
{
    private readonly IAppDbContext DbContext;

    public DeleteTodoCommandHandler(IAppDbContext dbContext)
    {
        DbContext = dbContext;
    }
    public async Task Handle(DeleteTodoCommand request, CancellationToken cancellationToken)
    {
       var entity = await DbContext.Todos.FindAsync(request.Id);
       if (entity == null)
       {
           throw new NotFoundException(nameof(entity), request.Id);
       }

      DbContext.Todos.Remove(entity);

       await DbContext.SaveChangesAsync(cancellationToken);
    }
}
