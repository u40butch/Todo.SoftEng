using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Todo.SoftEng.Tasks;

public class TodoAppServiceTests : SoftEngApplicationTestBase
{
    private readonly ITodoAppService _todoAppService;

    public TodoAppServiceTests()
    {
        _todoAppService = GetRequiredService<ITodoAppService>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        // Arrange

        // Act

        // Assert
    }
    */
}

