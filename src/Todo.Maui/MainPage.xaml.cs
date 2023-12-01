using Todo.Maui.Dtos;
using Todo.Maui.Services;
using Volo.Abp.DependencyInjection;

namespace Todo.Maui;

public partial class MainPage : ContentPage, ITransientDependency
{
	private readonly HelloWorldService _helloWorldService;
    private readonly RestService _todoService;
    int count = 0;

	private List<TodoDto> _items = new List<TodoDto>();

	public MainPage(HelloWorldService helloWorldService, RestService todoService)
	{
		_helloWorldService = helloWorldService;
        _todoService = todoService;
        InitializeComponent();
		SetHelloLabText();
    }

    private void SetHelloLabText()
    {
		HelloLab.Text = _helloWorldService.SayHello();
    }
    
    private async void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

        _items = await GetTodos();
	}

	public async Task<List<TodoDto>> GetTodos()
	{
        return await _todoService.RefreshDataAsync();
    }
}
