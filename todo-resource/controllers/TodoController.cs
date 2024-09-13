using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("/")]
public class TodoController : ControllerBase
{
    [HttpGet]
    public IEnumerable<ToDO> Get()
    {
        return TodoService.GetToDOs();
    }
}

