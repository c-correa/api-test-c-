using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ApplicationDbContext<T> : DbContext where T : class, IEntity
{
    public DbSet<T> Entities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Env.Load(); // carga el .env
        var connectionString = Environment.GetEnvironmentVariable("URL_CONNECT_BD");

        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // opcional: asignar el nombre de tabla igual al nombre de la clase
        modelBuilder.Entity<T>().ToTable(typeof(T).Name.ToLower());
    }

    public async Task<List<T>> FindAll()
    {
        List<T> record = await Entities.ToListAsync();
        // record.Where(i => i.deleted_At !== null)
        return record;
    }

public async Task<T> FindOne(int id)
{
    var entity = await Entities.FirstOrDefaultAsync(i => i.Id == id);

    if (entity == null)
    {
        throw new Exception($"No se encontró un registro con Id = {id}");
    }

    return entity;
}

}
