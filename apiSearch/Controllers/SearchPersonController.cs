using apiSearch.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchPersonController : ControllerBase
    {
        private readonly ISearchService _searchService;
        public SearchPersonController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        // GET: api/<PeopleController>
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get(string searchTerm)
        {
            List<Person> people = _searchService.getPeopleDetails();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return BadRequest("Please provide a search term");
            }
            var results = people.Where(x => x.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
            x.LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
             $"{x.FirstName} {x.LastName}".Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            return Ok(results);
        }
    }
}
