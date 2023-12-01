using System;
using System.Threading.Tasks;
using Todo.SoftEng.Tasks;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Todo.SoftEng.EntityFrameworkCore.Tasks;

public class TodoRepositoryTests : SoftEngEntityFrameworkCoreTestBase
{
    private readonly ITodoRepository _todoRepository;

    public TodoRepositoryTests()
    {
        _todoRepository = GetRequiredService<ITodoRepository>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        await WithUnitOfWorkAsync(async () =>
        {
            // Arrange

            // Act

            //Assert
        });
    }
    */
}
