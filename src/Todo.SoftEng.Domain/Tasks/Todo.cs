using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Todo.SoftEng.Tasks
{
    public class Todo : Entity<Guid>
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    protected Todo()
    {
    }

    public Todo(
        Guid id,
        string title,
        string description
    ) : base(id)
    {
        Title = title;
        Description = description;
    }
    }
}
