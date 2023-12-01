using System;
using System.Linq;
using System.Threading.Tasks;
using Todo.SoftEng.Permissions;
using Todo.SoftEng.Tasks.Dtos;
using Volo.Abp.Application.Services;

namespace Todo.SoftEng.Tasks;


public class TodoAppService : CrudAppService<Todo, TodoDto, Guid, TodoGetListInput, CreateUpdateTodoDto, CreateUpdateTodoDto>,
    ITodoAppService
{
    //protected override string GetPolicyName { get; set; } = SoftEngPermissions.Todo.Default;
    //protected override string GetListPolicyName { get; set; } = SoftEngPermissions.Todo.Default;
    //protected override string CreatePolicyName { get; set; } = SoftEngPermissions.Todo.Create;
    //protected override string UpdatePolicyName { get; set; } = SoftEngPermissions.Todo.Update;
    //protected override string DeletePolicyName { get; set; } = SoftEngPermissions.Todo.Delete;

    private readonly ITodoRepository _repository;

    public TodoAppService(ITodoRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Todo>> CreateFilteredQueryAsync(TodoGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(!input.Title.IsNullOrWhiteSpace(), x => x.Title.Contains(input.Title))
            .WhereIf(!input.Description.IsNullOrWhiteSpace(), x => x.Description.Contains(input.Description))
            ;
    }
}
