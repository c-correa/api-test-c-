using System;
using System.Collections.Generic;
using Npgsql;

public class ConnectBD
{
    private readonly string _connectionString;

    public ConnectBD(string connectionString)
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

    // Aquí agregamos el método ExecuteQuery
    public NpgsqlDataReader ExecuteQuery(string query)
    {
        var conn = new NpgsqlConnection(_connectionString);
        conn.Open();

        var cmd = new NpgsqlCommand(query, conn);
        // Al usar CommandBehavior.CloseConnection, la conexión se cerrará al cerrar el reader
        return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
    }
}
