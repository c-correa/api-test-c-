using System;
using Npgsql;

public class PostgresDb
{
    private readonly string _connectionString;

    public PostgresDb(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void TestConnection()
    {
        using var conn = new NpgsqlConnection(_connectionString);
        try
        {
            conn.Open();
            Console.WriteLine("Conexión exitosa a PostgreSQL");

            using var cmd = new NpgsqlCommand("SELECT version()", conn);
            var version = cmd.ExecuteScalar().ToString();
            Console.WriteLine($"Versión de PostgreSQL: {version}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al conectar: {ex.Message}");
        }
    }

}
