using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml;
using User_Details_Project.Entities;
using User_Details_Project.Infrastructure.Services;

namespace User_Details_Project.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _userService.GetAllEntitiesAsync();
            return Ok(entities);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _userService.GetEntityByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Users entity)
        {
            var createdEntity = await _userService.CreateEntityAsync(entity);
            return CreatedAtAction(nameof(GetById), new { id = createdEntity.Id }, createdEntity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Users entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await _userService.UpdateEntityAsync(id, entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.DeleteEntityAsync(id);
            return NoContent();
        }
    }
}
