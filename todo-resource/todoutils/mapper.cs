public static class TodoMapper
{
    private static readonly Random _random = new Random();

    public static ToDO? MapToDO(TodoDto todoDto)
    {
        if (todoDto == null)
        {
            return null;
        }
        
        return new ToDO(_random.Next(1, 10000), todoDto.Name, todoDto.IsComplete);
      
    }
}