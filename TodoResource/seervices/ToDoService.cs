
namespace apitodoResource.seervices;


public static class TodoService
{
    public static  List<ToDo> GetToDOs()
    {
        return
        [
            new (1, "Learn .NET is fun", false),
                new (2, "Build API and see how good ", true),
                new (3, "Test Application", false),
                new (4, "Service is working", false),
                new (5,"Mani is awesome",true),
                new (6,"Mani is awesome add some more",false),
            ];
    }
}

