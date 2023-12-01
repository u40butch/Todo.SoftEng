using System;

namespace Todo.Maui.Dtos;

[Serializable]
public class TodoDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}