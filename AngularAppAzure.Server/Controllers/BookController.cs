using AngularAppAzure.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularAppAzure.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book{Id = 0, Author = "Hailey Reall", Title = "Torts", BestSellerList = true, PublishDate = DateTime.UtcNow, Publisher = "Tesla Publishing House"},
            new Book{Id = 1, Author = "Hailey Reall", Title = "Torts", BestSellerList = true, PublishDate = DateTime.UtcNow, Publisher = "Einstein Publishing House"},
            new Book{Id = 2, Author = "Hailey Reall", Title = "Torts", BestSellerList = true, PublishDate = DateTime.UtcNow, Publisher = "Pavlov Publishing House"},
            new Book{Id = 3, Author = "Hailey Reall", Title = "Torts", BestSellerList = true, PublishDate = DateTime.UtcNow, Publisher = "Crick & Watson Publishing House"},
            new Book{Id = 4, Author = "Hailey Reall", Title = "Torts", BestSellerList = true, PublishDate = DateTime.UtcNow, Publisher = "Ginsburg Legal Publishing House"},

        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }
    }
}
