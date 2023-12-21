using apiSearch;
using apiSearch.Controllers;
using apiSearch.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace apiSearchTests
{
    public class SearchPersonControllerTest
    {
        private SearchPersonController? controller;
        private Mock<ISearchService>? searchServiceMock;

        [SetUp]
        public void Setup()
        {
            searchServiceMock = new Mock<ISearchService>();
            controller = new SearchPersonController(searchServiceMock.Object);
        }

        [Test]
        public void Get_ReturnsOkResult_WithSearchResults()
        {
            // Arrange
            var people = new List<Person>
        {
            new Person { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Gender = "Male" },
            new Person { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Gender = "Female" },
            // Add more sample data as needed
        };

            searchServiceMock?.Setup(x => x.getPeopleDetails()).Returns(people);

            // Act
            var result = controller?.Get("John");

            // Assert
            Assert.IsNotNull(result);

            var objectResult = result?.Result as OkObjectResult;
            Assert.IsInstanceOf<IEnumerable<Person>>(objectResult?.Value);
            var filteredResults = objectResult?.Value as IEnumerable<Person>;
            Assert.AreEqual(1, filteredResults?.Count());
            Assert.AreEqual("John", filteredResults?.First().FirstName);
        }

        [Test]
        public void Get_REturnsBadResult_WithEmptySearchTerm()
        {
            //Arrange
            var searchTerm = "";
            var people = new List<Person>
        {
            new Person { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Gender = "Male" },
            new Person { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Gender = "Female" },
        };

            searchServiceMock?.Setup(x => x.getPeopleDetails()).Returns(people);

            //Act
            var result = controller?.Get(searchTerm);

            //Assert
            Assert.IsNotNull(result);
            var objectResult = result?.Result as BadRequestObjectResult;
            Assert.AreEqual(400, objectResult?.StatusCode);
            Assert.AreEqual("Please provide a search term", objectResult?.Value);
        }
    }
}