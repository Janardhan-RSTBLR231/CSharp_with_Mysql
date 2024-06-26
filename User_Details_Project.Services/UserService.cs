using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Details_Project.Infrastructure.Services;
using User_Details_Project.Infrastructure.DataAccess;
using User_Details_Project.Entities;


namespace User_Details_Project.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<Users> _repository;

        public UserService(IRepository<Users> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Users>> GetAllEntitiesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Users> GetEntityByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Users> CreateEntityAsync(Users entity)
        {
            return await _repository.CreateAsync(entity);
        }

        public async Task UpdateEntityAsync(int id, Users entity)
        {
            await _repository.UpdateAsync(id, entity);
        }

        public async Task DeleteEntityAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
    

