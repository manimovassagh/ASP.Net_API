namespace api.todo_resource.Models;

public class ToDO
{

    public int Id { get; set; }
    public string Name { get; set; } ="";
    public bool IsComplete { get; set; }
    
        public ToDO(int id, string name, bool isComplete)
    {
        Id = id;
        Name  = name;
        IsComplete = isComplete;
    }


}

