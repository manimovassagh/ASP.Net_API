using Microsoft.AspNetCore.Mvc;


    [ApiController]
    [Route("/")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<ToDO> Get()
        {
            return new List<ToDO>
            {
                new (1, "Learn .NET", false),
                new (2, "Build API and see how good ", true),
                new (3, "Test Application", false)
            };
        }
    }

