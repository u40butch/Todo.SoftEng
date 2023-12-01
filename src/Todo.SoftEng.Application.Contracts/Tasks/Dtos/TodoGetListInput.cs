using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace Todo.SoftEng.Tasks.Dtos;

[Serializable]
public class TodoGetListInput : PagedAndSortedResultRequestDto
{
    public string? Title { get; set; }

    public string? Description { get; set; }
}