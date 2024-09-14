using api.todo_resource.Models;

namespace api. todo_resource.todoutils;
public static class TodoMapper
{
    private static readonly Random _random = new Random();

    public static ToDo? MapToDO(TodoDto todoDto)
    {
        if (todoDto == null)
        {
            return null;
        }
        
        return new ToDo(_random.Next(1, 10000), todoDto.Name, todoDto.IsComplete);
      
    }
}