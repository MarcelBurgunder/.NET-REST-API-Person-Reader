using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonApi.Models;

namespace PersonApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly PersonContext _context;

    public PersonController(PersonContext context)
    {
        _context = context;
    }

    // API Endpoint (Post Method) that takes in first and last name and phone number, and saves this to the PersonContext holding Persons.
    [HttpPost]
    public async Task<ActionResult<TodoItemDTO>> PostTodoItem(string FirstName, string LastName and string PhoneNumber)
    {
    }
    
    // 
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoItemDTO>>> GetTodoItems()
    {
    }
}
