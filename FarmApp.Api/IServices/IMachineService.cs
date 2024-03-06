using FarmApp.Api.Dtos;
using FarmApp.Api.Models;

namespace FarmApp.Api.IServices
{
    public interface IMachineService : IService<Machine, CreateMachineDto, UpdateMachineDto>
    {
        public Task<bool> UpdateMilage(Guid id, decimal updatedMilage);
    }
}
