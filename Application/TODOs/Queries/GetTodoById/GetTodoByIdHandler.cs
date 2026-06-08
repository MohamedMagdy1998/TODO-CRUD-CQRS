using Application.Common.Exceptions;
using Application.Common.Interface;
using Domain.Todos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.TODOs.Queries.GetTodoById;

public class GetTodoByIdHandler : IRequestHandler<GetTodoByIdQuery, Todo?>
{
    private readonly IAppDbContext _context;
    public GetTodoByIdHandler(IAppDbContext appDbContext)
    {
        _context = appDbContext;
    }
    public async Task<Todo?> Handle(GetTodoByIdQuery request, CancellationToken cancellationToken)
    {
        var todo = await _context.Todos.FindAsync(request.Id);
        if (todo == null) 
            throw new NotFoundException(nameof(Todo), request.Id);

        return todo;
    }
}
