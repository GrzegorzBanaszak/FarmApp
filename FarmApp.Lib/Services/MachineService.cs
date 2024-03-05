using FarmApp.Api.Context;
using FarmApp.Lib.Dtos;
using FarmApp.Lib.IServices;
using FarmApp.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace FarmApp.Lib.Services
{
    public class MachineService : IMachineService
    {
        private readonly FarmAppContext _context;

        public MachineService(FarmAppContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Machine>> GetAll()
        {
            return await _context.Machines.ToListAsync();
        }

        public async Task<Machine?> GetById(Guid id)
        {
            return await _context.Machines.FindAsync(id);
        }

        public async Task<Machine> Add(CreateMachineDto entity)
        {
            Machine machine = new Machine { Mark = entity.Mark, Milage = 0.0m, Seria = entity.Seria };

            _context.Machines.Add(machine);
            await _context.SaveChangesAsync();

            return machine;

        }

        public async Task<bool> Delete(Guid id)
        {
            try
            {
                _context.Machines.Remove(_context.Machines.Single(m => m.Id == id));
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(UpdateMachineDto entity)
        {
            try
            {
                Machine machine = new Machine()
                {
                    Id = entity.Id,
                    Mark = entity.Mark,
                    Seria = entity.Seria,
                    Milage = entity.Milage
                };
                _context.Machines.Update(machine);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> UpdateMilage(Guid id, decimal updatedMilage)
        {
            try
            {
                Machine machine = _context.Machines.Single(m => m.Id == id);
                machine.Milage = updatedMilage;
                _context.Machines.Update(machine);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
