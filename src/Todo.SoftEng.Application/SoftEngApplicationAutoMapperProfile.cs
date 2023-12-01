using Todo.SoftEng.Tasks;
using Todo.SoftEng.Tasks.Dtos;
using AutoMapper;

namespace Todo.SoftEng;

public class SoftEngApplicationAutoMapperProfile : Profile
{
    public SoftEngApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Tasks.Todo, TodoDto>();
        CreateMap<CreateUpdateTodoDto, Tasks.Todo>(MemberList.Source);
    }
}
