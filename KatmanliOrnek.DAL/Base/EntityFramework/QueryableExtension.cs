using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KatmanliOrnek.DAL.Base.EntityFramework
{
    public static class QueryableExtension
    {
        public static IQueryable<T> MyIncludes<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includes)
            where T : class
        {
            if (query != null)
            {
                query = includes.Aggregate(query, (a, b) => a.Include(b));
            }

            return query;
        }
    }
}
