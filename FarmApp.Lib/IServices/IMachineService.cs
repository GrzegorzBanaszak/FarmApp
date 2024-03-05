using FarmApp.Lib.Dtos;
using FarmApp.Lib.Models;

namespace FarmApp.Lib.IServices
{
    public interface IMachineService : IService<Machine, CreateMachineDto, UpdateMachineDto>
    {
        public Task<bool> UpdateMilage(Guid id, decimal updatedMilage);
    }
}
