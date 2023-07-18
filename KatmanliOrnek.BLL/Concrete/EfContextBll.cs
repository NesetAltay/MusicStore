using AutoMapper;
using KatmanliOrnek.BLL.Abstract.IServices;
using KatmanliOrnek.BLL.Concrete.Mapper;
using KatmanliOrnek.BLL.Concrete.Services;
using KatmanliOrnek.DAL.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace KatmanliOrnek.BLL.Concrete
{
    public static class EfContextBll
    {
        public static IServiceCollection AddScopedBll(this IServiceCollection services)
        {
            services.AddScopedDal()
                .AddScoped<IAdminService, AdminService>()
                .AddScoped<IPlakService, PlakService>()
                .AddScoped<IArtistServise, ArtistServices>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new Mapping());
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
