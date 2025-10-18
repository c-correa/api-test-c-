using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ApiTest.Data;
using ApiTest.Utils;

public class Service<T, C, U> where T : class, IBaseEntity where U : class?
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly DbSet<T> _entities;

    public Service(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
        _entities = _context.Set<T>();
    }

    public IEnumerable<T> GetAll()
    {
        return _entities.ToList();
    }

    public T? GetById(int id)
    {
        T? record = _entities.FirstOrDefault(x => x.Id == id);
        if (record == null)
            throw new ArgumentException("No hay data");
        return record;
    }

    public OkResult Add(C dto)
    {
        // Mapeo automático DTO → Entidad
        T entity = _mapper.Map<T>(dto);
        _entities.Add(entity);
        _context.SaveChanges();
        return new OkResult { Ok = true };
    }

  public void Update(int id, U? dto)
    {
        if (dto == null)
            throw new ArgumentException("DTO no puede ser null");

        T entity = _entities.FirstOrDefault(x => x.Id == id)
                ?? throw new ArgumentException("No hay data");

        // Mapea propiedades del DTO sobre la entidad existente
        _mapper.Map(dto, entity);

        // 🔹 Forzar EF Core a marcar la entidad como modificada
        _context.Entry(entity).State = EntityState.Modified;

        _context.SaveChanges();
    }

}
