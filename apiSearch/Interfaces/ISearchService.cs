using apiSearch.Models;

namespace apiSearch
{
    public interface ISearchService
    {
        List<Person> getPeopleDetails();
    }
}
