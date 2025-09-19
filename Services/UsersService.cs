
public class Service
{
    private ConnectBD connectBD;


    public Service()
    {
        connectBD = new ConnectBD("Host=dpg-d2oias7fte5s738b7nug-a.oregon-postgres.render.com;Port=5432;Username=pets;Password=8mPUBMxaTTBNRc4H9mGHc0EKSzSNIqy5;Database=pets_px49");
    }
    public void Hola()
    {
        var query = "SELECT * FROM stores"; // Cambia por tu tabla
        using var reader = connectBD.ExecuteQuery(query);

        Console.WriteLine("ID\tName\tAddress");
        while (reader.Read())
        {
            // Suponiendo que la tabla "stores" tiene estas columnas:
            int id = reader.GetInt32(reader.GetOrdinal("id"));          // columna id (int)
            string name = reader.GetString(reader.GetOrdinal("name"));   // columna name (string)

            Console.WriteLine($"{reader}");
                        Console.WriteLine($"{name}");

        }
    }


}