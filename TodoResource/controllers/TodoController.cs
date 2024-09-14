using apitodoResource.seervices;
using Microsoft.AspNetCore.Mvc;


namespace api.TodoResource.controllers;

[ApiController]
[Route("/")]
public class TodoController : ControllerBase
{
    [HttpGet]
    public IEnumerable<ToDo> Get()
    {
        return TodoService.GetToDOs();
    }
}

