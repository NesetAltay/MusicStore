using KatmanliOrnek.Models.DTOs.PlakDtos;
using KatmanliOrnek.Models.VMs.PlakVMs;
using KatmanliOrnek.Shared;

namespace KatmanliOrnek.BLL.Abstract.IServices
{
    public interface IPlakService
    {
        bool IsExistPlak(string plakName, string artistName);

        ResultService<PlakCreateDto> Create(PlakCreateVm createVm);

        bool Delete(int id);

        ResultService<PlakUpdateDto> Update(PlakUpdateVm updateVm);

        ResultService<List<PlakDetailVm>> GetAll();

        ResultService<List<PlakBaseVm>> DiscontinuedPlakList(bool discontinued);

        ResultService<List<PlakBaseVm>> LastTenAddedPlak();

        ResultService<List<PlakBaseVm>> DiscountedPlakList();
    }
}
