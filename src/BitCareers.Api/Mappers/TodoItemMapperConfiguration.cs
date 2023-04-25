using BitCareers.Api.Models.TodoItem;
using BitCareers.Shared.Dtos.TodoItem;

namespace BitCareers.Api.Mappers;

public class TodoItemMapperConfiguration : Profile
{
    public TodoItemMapperConfiguration()
    {
        CreateMap<TodoItem, TodoItemDto>().ReverseMap();
    }
}
