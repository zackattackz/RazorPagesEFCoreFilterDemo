using RazorPagesEFCoreFilterDemo.Models;
using System.Linq.Expressions;

namespace RazorPagesEFCoreFilterDemo.Data.Repositories;

public class ZooRepository : IZooRepository
{
    private const int PageCount = 10;

    private readonly ZooContext _context;

    public ZooRepository(ZooContext context)
    {
        _context = context;
    }

    public IEnumerable<Animal> GetEntriesByPageNo(int pgno, Expression<Func<Animal, bool>>? predicate)
    {
        var filteredAnimals = predicate == null
            ? _context.Animals
            : _context.Animals.Where(predicate);

        return filteredAnimals
            .OrderBy(e => e.Id)
            .Skip(PageCount * (pgno - 1))
            .Take(PageCount);
    }
}
