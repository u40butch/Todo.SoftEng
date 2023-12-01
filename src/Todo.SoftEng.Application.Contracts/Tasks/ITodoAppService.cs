using System;
using Todo.SoftEng.Tasks.Dtos;
using Volo.Abp.Application.Services;

namespace Todo.SoftEng.Tasks;


public interface ITodoAppService :
    ICrudAppService< 
        TodoDto, 
        Guid, 
        TodoGetListInput,
        CreateUpdateTodoDto,
        CreateUpdateTodoDto>
{

}