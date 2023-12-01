using System;
using Volo.Abp.Application.Dtos;

namespace Todo.SoftEng.Tasks.Dtos;

[Serializable]
public class TodoDto : EntityDto<Guid>
{
    public string Title { get; set; }

    public string Description { get; set; }
}