using api.todo_resource.Models;
using api.todo_resource.seervices;
using Microsoft.AspNetCore.Mvc;

namespace api.todo_resource.controllers;

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

