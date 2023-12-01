using Volo.Abp.DependencyInjection;

namespace Todo.Maui;

public class HelloWorldService : ITransientDependency
{
    public string SayHello()
    {
        return "Hello, World!";
    }
}