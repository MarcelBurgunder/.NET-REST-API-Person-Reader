using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonApi.Models;

namespace PersonApi.Controllers
{
    // Controller Class
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // Controller Contexts holding the data model
        private readonly PersonContext _context;
    
        // Controller Constructor - Sets the context
        public PersonController(PersonContext context)
        {
            _context = context;
        }

        // API Endpoint (Post Method) that takes in first and last name and phone number, and saves this to the PersonContext holding Persons.
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<Person>> PostPerson(string FirstName, string LastName, string PhoneNumber)
        {
            Person pers = new Person(FirstName, LastName, PhoneNumber);
            _context.Person.Add(pers);
            await _context.SaveChangesAsync();
            return CreatedAtAction("None", pers); // currently no action exists to retrieve the saved objects, hence first parameter is "None"
        }

        // API Endpoint (Get Method) that takes in a list of persons via a file and logs each line, and returns processed file as response.
        [HttpGet]
        public async Task<ActionResult<string>> ReadFile(this IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest();
            }

            var result = new StringBuilder();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                {
                    string line = await reader.ReadLineAsync();
                    result.AppendLine(line);
                    Console.WriteLine(line);
                }
            }

            return result.ToString();
        }
    }
};
