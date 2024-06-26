using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using User_Details_Project.Entities;

namespace User_Details_Project.Infrastructure.Services
{
    public interface IUserService
    {
        Task<IEnumerable<Users>> GetAllEntitiesAsync();
        Task<Users> GetEntityByIdAsync(int id);
        Task<Users> CreateEntityAsync(Users entity);
        Task UpdateEntityAsync(int id, Users entity);
        Task DeleteEntityAsync(int id);
    }
}
