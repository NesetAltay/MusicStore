using AutoMapper;
using KatmanliOrnek.Entities;
using KatmanliOrnek.Models.DTOs.AdminDtos;
using KatmanliOrnek.Models.DTOs.ArtistDtos;
using KatmanliOrnek.Models.DTOs.PlakDtos;
using KatmanliOrnek.Models.VMs.AdminVMs;
using KatmanliOrnek.Models.VMs.ArtistVMs;
using KatmanliOrnek.Models.VMs.PlakVMs;
using KatmanliOrnek.Models.VMs.UserVMs;

namespace KatmanliOrnek.BLL.Concrete.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Plak, PlakCreateDto>().ReverseMap();
            CreateMap<Plak, PlakUpdateDto>().ReverseMap();
            CreateMap<PlakCreateDto, PlakCreateVm>().ReverseMap();
            CreateMap<PlakUpdateDto, PlakUpdateVm>().ReverseMap();

            CreateMap<Artist, ArtistCreateDto>().ReverseMap();
            CreateMap<Artist,ArtistDetailDto>().ReverseMap();
            CreateMap<ArtistCreateDto,ArtistCreateVm>().ReverseMap();

            CreateMap<User, AdminCreateDto>().ReverseMap();
            CreateMap<User, LoginVm>().ReverseMap();
            CreateMap<AdminCreateDto, AdminCreateVm>().ReverseMap();
        }
    }
}
