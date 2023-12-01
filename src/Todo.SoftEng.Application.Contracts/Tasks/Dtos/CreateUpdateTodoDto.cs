using System;

namespace Todo.SoftEng.Tasks.Dtos;

[Serializable]
public class CreateUpdateTodoDto
{
    public string Title { get; set; }

    public string Description { get; set; }
}