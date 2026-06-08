using Domain.Todos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Interface;

public interface IAppDbContext
{
    DbSet<Todo> Todos { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
