using System;

namespace ToDoAPI
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoAPI.Authentication;
using ToDoAPI.Models;

namespace ToDoAPI.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ToDoItemController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        protected UserManager<ApplicationUser> UserManager { get; set; }

        public ToDoItemController(ApplicationDbContext context)
        {
            _context = context;
        }

  

        // GET: api/ToDoItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoItemModel>>> GetToDoItems()
        {
    
            return await _context.ToDoItems.ToListAsync();
        }

        // GET: api/ToDoItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoItemModel>> GetToDoItemModel(int id)
        {
            var toDoItemModel = await _context.ToDoItems.FindAsync(id);

            if (toDoItemModel == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Not found" });
            }

            return toDoItemModel;
        }
        [HttpGet("status={status}")]
        public async Task<ActionResult<IEnumerable<ToDoItemModel>>> GetToDoItemStatus(string status)
        {
            var toDoItemModel = await _context.ToDoItems.Where(s=> s.ItemStatus == status).ToListAsync(); ;

            if (toDoItemModel == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Not found" });

            }

            return toDoItemModel;
        }

        // PUT: api/ToDoItem/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToDoItemModel(int id, ToDoItemModel toDoItemModel)
        {
            if (id != toDoItemModel.ItemId)
            {
                return BadRequest();
            }
            toDoItemModel.ItemUpdated = DateTime.Now.ToString("yyyy-MM-dd");
            _context.Entry(toDoItemModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToDoItemModelExists(id))
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Not found" });

                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ToDoItem
        [HttpPost]
        public async Task<ActionResult<ToDoItemModel>> PostToDoItemModel(ToDoItemModel toDoItemModel)
        {
            toDoItemModel.ItemCreated = DateTime.Now.ToString("yyyy-MM-dd");
            toDoItemModel.ItemUpdated = DateTime.Now.ToString("yyyy-MM-dd");
        
            await _context.SaveChangesAsync();
            
            return CreatedAtAction("GetToDoItemModel", new { id = toDoItemModel.ItemId }, toDoItemModel);
        }


        // DELETE: api/ToDoItem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDoItemModel(int id)
        {
            var toDoItemModel = await _context.ToDoItems.FindAsync(id);
            if (toDoItemModel == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Not found" });
            }

            _context.ToDoItems.Remove(toDoItemModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ToDoItemModelExists(int id)
        {
            return _context.ToDoItems.Any(e => e.ItemId == id);
        }
    }
}
*/