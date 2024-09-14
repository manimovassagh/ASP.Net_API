




using api.todo_resource.Models;

public static class ToDoMapper
{
    private static readonly Random _random = new Random();

    
    public static ToDo MapToDO(TodoDto todoDto)
    {
        if (todoDto == null)
        {
            return null;
        }
        
        return new ToDo(_random.Next(1, 10000), todoDto.Name, todoDto.IsComplete);
      
    }
}