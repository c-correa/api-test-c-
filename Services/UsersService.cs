
public class Service
{
    private ApplicationDbContext applicationDbContext = new ApplicationDbContext();
public async Task<List<User>> Hola()
    {
        List<User> reader = await applicationDbContext.FindAll();

        Console.WriteLine($"{reader}");

        return reader;
    }


}