using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Todos;

public class Todo
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool Completed { get; set; }
}
