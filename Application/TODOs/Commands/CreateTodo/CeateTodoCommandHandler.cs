using Application.Common.Interface;
using Domain.Todos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.TODOs.Commands.Create;

public class CeateTodoCommandHandler : IRequestHandler<CreateTodoCommand, Guid>
{
    private readonly IAppDbContext DbContext;

    public CeateTodoCommandHandler(IAppDbContext dbContext)
    {
        DbContext = dbContext;
    }
    public async Task<Guid> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
    {
        var NewTodo = new Todo
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
        };

     await   DbContext.Todos.AddAsync(NewTodo);

      await  DbContext.SaveChangesAsync(cancellationToken);

        return NewTodo.Id;

        
    }
}
