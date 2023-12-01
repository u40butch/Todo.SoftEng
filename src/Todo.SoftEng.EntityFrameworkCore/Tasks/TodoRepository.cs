using System;
using System.Linq;
using System.Threading.Tasks;
using Todo.SoftEng.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Todo.SoftEng.Tasks;

public class TodoRepository : EfCoreRepository<SoftEngDbContext, Todo, Guid>, ITodoRepository
{
    public TodoRepository(IDbContextProvider<SoftEngDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Todo>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}