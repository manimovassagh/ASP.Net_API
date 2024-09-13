using Microsoft.AspNetCore.Mvc;


    [ApiController]
    [Route("/")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            return new List<TodoItem>
            {
                new (1, "Learn .NET", false),
                new (2, "Build API", true),
                new (3, "Test Application", false)
            };
        }
    }

