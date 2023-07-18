using KatmanliOrnek.DAL.Abstract;
using KatmanliOrnek.DAL.Concrete.Context;
using KatmanliOrnek.DAL.Concrete.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace KatmanliOrnek.DAL.Concrete
{
    public static class EfContextDal
    {
        public static IServiceCollection AddScopedDal(this IServiceCollection services)
        {
            services.AddDbContext<PlakDbContext>()
                .AddScoped<IUserRepo,UserRepo>()
                .AddScoped<IPlakRepo, PlakRepo>()
                .AddScoped<IArtistRepo,ArtistRepo>();

            return services;
        }
    }
}
