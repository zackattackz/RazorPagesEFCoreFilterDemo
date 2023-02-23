using RazorPagesEFCoreFilterDemo.Models;
using System.Linq.Expressions;

namespace RazorPagesEFCoreFilterDemo.Data.Repositories;

public interface IZooRepository
{
    IEnumerable<Animal> GetEntriesByPageNo(int pgno, Expression<Func<Animal, bool>>? predicate);
}