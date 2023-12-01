using System;
using Volo.Abp.Domain.Repositories;

namespace Todo.SoftEng.Tasks;

public interface ITodoRepository : IRepository<Todo, Guid>
{
}
