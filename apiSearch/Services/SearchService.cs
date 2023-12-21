using apiSearch.Models;

namespace apiSearch.Services
{
    public class SearchService : ISearchService
    {
        public List<Person> getPeopleDetails()
        {
            return new List<Person> {
            new Person { Id = 1, FirstName = "Antony", LastName= "Fitt", Email= "afitt0@a8.net", Gender="Male"},
            new Person {Id=2,FirstName="Katey", LastName="Gaines", Email="kgaines1@bbb.org", Gender="Female"},
            new Person {Id=3, FirstName = "Ardelle", LastName="Soames", Email="asoames2@google.it", Gender="Female"},
            new Person {Id=4, FirstName= "Kalila", LastName="Tennant", Email="ktennant3@phpbb.com", Gender="Female"},
            new Person {Id=5,FirstName="Veda", LastName="Emma", Email="vemma4@nature.com", Gender="Female"},
            new Person {Id = 6, FirstName= "Pauli", LastName="Isacke", Email= "pisacke5@is.gd", Gender="Female"},
            new Person {Id = 7, FirstName="Belita", LastName="Ruoff", Email="bruoff6@wiley.com", Gender="Female"},
            new Person {Id= 8, FirstName="James", LastName="Kubu",Email="hkubu7@craigslist.org",Gender="Male"},
            new Person {Id=9, FirstName="Jasen",LastName="Jiroudek",Email="jjiroudek8@google.it",Gender="Polygender"},
            new Person {Id = 10, FirstName = "Gusty", LastName="Tuxill", Email="gtuxill9@illinois.edu", Gender="Female"},
            new Person {Id=11, FirstName="James", LastName="Pfeffer", Email="bpfeffera@amazon.com", Gender="Male"},
            new Person {Id=12, FirstName="Mignonne", LastName="Whitewood", Email="mwhitewoodb@godaddy.com", Gender="Female"},
            new Person {Id=13, FirstName="Moselle",LastName="Gaize",Email="mgaizec@tumblr.com", Gender="Female"},
            new Person {Id=14, FirstName="Chalmers", LastName="Longfut", Email="clongfujam@wp.com",Gender="Male"},
            new Person {Id=15,FirstName="Linnell",LastName="Jumont", Email="ljumonte@storify.com" ,Gender="Female"},
            new Person {Id=16, FirstName="Viole", LastName="Eaglen", Email="veaglenf@nytimes.com", Gender="Female"},
            new Person {Id =17, FirstName="Sileas", LastName="Tarr", Email="starrg@telegraph.co.uk",Gender="Female"},
            new Person{Id=18,FirstName="Katey", LastName="Soltan",Email="ksoltanh@simplemachines.org",Gender="Female"},
            new Person {Id=19, FirstName="Gar",LastName="Motion", Email="gmotioni@shop-pro.jp", Gender="Male"},
            new Person {Id=20, FirstName="Kameko", LastName="Vanes", Email="kvanesj@discuz.net",Gender="Female"}
            };
        }
    }
}
