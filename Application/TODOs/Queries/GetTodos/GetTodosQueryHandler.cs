using Application.Common.Interface;
using Domain.Todos;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.TODOs.Queries.GetTodos;

public class GetTodosQueryHandler : IRequestHandler<GetTodosQuery, IEnumerable<Todo>>
{
        private readonly IAppDbContext _context;
    public GetTodosQueryHandler(IAppDbContext dbContext)
    {
        _context = dbContext;
    }
    public async Task<IEnumerable<Todo>> Handle(GetTodosQuery request, CancellationToken cancellationToken)
    {
        return await _context.Todos.AsNoTracking().ToListAsync(cancellationToken);
    }
}
