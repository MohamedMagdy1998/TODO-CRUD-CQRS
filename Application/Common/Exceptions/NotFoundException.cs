using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string entity, Guid id) : base($"Entity \"{entity}\" with id {id} was not found.")
    {

    }
}
