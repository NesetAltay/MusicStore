using AutoMapper;
using KatmanliOrnek.BLL.Abstract.IServices;
using KatmanliOrnek.Core.Enums;
using KatmanliOrnek.DAL.Abstract;
using KatmanliOrnek.Entities;
using KatmanliOrnek.Models.DTOs.PlakDtos;
using KatmanliOrnek.Models.VMs.PlakVMs;
using KatmanliOrnek.Shared;

namespace KatmanliOrnek.BLL.Concrete.Services
{
    public class PlakService : IPlakService
    {
        private readonly IPlakRepo _plakRepo;
        private readonly IArtistServise _artistService;
        private readonly IMapper _mapper;

        public PlakService(IMapper mapper, IPlakRepo plakRepo, IArtistServise artistService)
        {
            _artistService = artistService;
            _mapper = mapper;
            _plakRepo = plakRepo;
        }

        public ResultService<PlakCreateDto> Create(PlakCreateVm createVm)
        {
            ResultService<PlakCreateDto> result = new ResultService<PlakCreateDto>();

            var existArtist = _artistService.FindArtistByName(createVm.ArtistName);

            if (existArtist.Data == null)
            {
                result.AddError(ErrorType.NotFound, "Önce Sanatçıyı Ekleyin");
                return result;
            }

            PlakCreateDto createDto = _mapper.Map<PlakCreateDto>(createVm);
            createDto.ArtistId = existArtist.Data.Id;

            Plak newPlak = _mapper.Map<Plak>(createDto);
            var addedPlak = _plakRepo.Create(newPlak);

            if (addedPlak != null)
            {
                result.Data = createDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız");
            }

            return result;
        }

        public bool Delete(int id)
        {
            Plak plak = _plakRepo.GetFirstOrDefault(filter: x => x.Id == id);

            if (plak != null)
            {
                return _plakRepo.Delete(plak);
            }

            return false;
        }

        public ResultService<List<PlakBaseVm>> DiscontinuedPlakList(bool discontinued)
        {
            ResultService<List<PlakBaseVm>> result = new ResultService<List<PlakBaseVm>>();

            var plaks = _plakRepo.GetFilteredList(select: x => new PlakBaseVm
                         {
                             PlakName = x.PlakName,
                             ArtistName = x.Artist.ArtistName
                         },
                             where: x => x.State != State.Deleted && x.Discontinued == discontinued,
                             inculudes: x => x.Artist);

            if (plaks != null)
            {
                result.Data = plaks.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir Hata ile karşılaşıldı");
            }

            return result;
        }

        public ResultService<List<PlakBaseVm>> DiscountedPlakList()
        {
            ResultService<List<PlakBaseVm>> result = new ResultService<List<PlakBaseVm>>();

            var plaks = _plakRepo.GetFilteredList(select: x => new PlakBaseVm
            {
                PlakName = x.PlakName,
                ArtistName = x.Artist.ArtistName
            },
            where: x => x.State != State.Deleted && x.Discount != null && x.Discount != 0,
            inculudes: x => x.Artist,
            orderBy: x => x.OrderByDescending(x => x.Discount));

            if (plaks != null)
            {
                result.Data = plaks.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı");
            }

            return result;
        }

        public ResultService<List<PlakDetailVm>> GetAll()
        {
            ResultService<List<PlakDetailVm>> result = new ResultService<List<PlakDetailVm>>();

            var plaks = _plakRepo.GetFilteredList(select: x => new PlakDetailVm
            {
                PlakName = x.PlakName,
                ArtistName=x.Artist.ArtistName,
                Discount = x.Discount,
                Discontinued = x.Discontinued,
                RecorDate  = x.RecordDate,
                UnitPrice = x.UnitPrice
            }, where:  x => x.State != State.Deleted && !x.Discontinued,
                inculudes: x => x.Artist);

            if (plaks != null)
            {
                result.Data = plaks.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı");
            }

            return result;
        }

        public bool IsExistPlak(string plakName, string artistName)
        {
            return _plakRepo.Any(x => x.PlakName.Equals(plakName) && x.Artist.ArtistName.Equals(artistName));
        }

        public ResultService<List<PlakBaseVm>> LastTenAddedPlak()
        {
            ResultService<List<PlakBaseVm>> result = new ResultService<List<PlakBaseVm>>();

            var plaks = _plakRepo.GetFilteredList(select: x => new PlakBaseVm
            {
                ArtistName = x.Artist.ArtistName,
                PlakName = x.PlakName
            }, where: x => !x.Discontinued && x.State != State.Deleted,
                inculudes: x => x.Artist,
                orderBy: x => x.OrderBy(x => x.CreatedDate))?.Take(10);

            if (plaks != null)
            {
                result.Data = plaks.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı");
            }

            return result;
        }

        public ResultService<PlakUpdateDto> Update(PlakUpdateVm updateVm)
        {
            ResultService<PlakUpdateDto> result = new ResultService<PlakUpdateDto>();

            var updateDto = _mapper.Map<PlakUpdateDto>(updateVm);
            var data = _mapper.Map<Plak>(updateDto);

            var updateData = _plakRepo.Update(data);

            if (updateData !=null)
            {
                result.Data = updateDto;
            }
            else
            {
                result.AddError(ErrorType.ServerError, "Güncelleme işlemi başarısız");
            }

            return result;
        }
    }
}
