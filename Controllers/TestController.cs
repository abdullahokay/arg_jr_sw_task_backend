using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task.Entities;
using Task.Repository;

namespace Task.Controllers
{
    [ApiController]
    [Route("/Test/[action]")]
    public class TestController : ControllerBase
    {
        private EF_DataContext _dbContext;

        public TestController(EF_DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<User>>> GetUser() {

            if (_dbContext.Users == null)
            {
                return NotFound();
            }

            return await _dbContext.Users.ToListAsync();
        }

        [HttpPost]

        public async Task<ActionResult<User>> SaveUser([FromBody] User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), user);
        }
    }
}