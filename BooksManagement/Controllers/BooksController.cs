using BooksManagement.DBModel;
using BooksManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace BooksManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookServices bookService;
        public BooksController(IBookServices _bookService) {
          bookService= _bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooksByAuthor(string authorName)
        {
            List<Book> books = new List<Book>();

            try
            {
                books=await bookService.GetBookByAuthor(authorName);

                if(books==null && books.Count==0) {
                  return NotFound();
                 }

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(books);
        }

        [HttpPost]
        public async Task<IActionResult> PublishBook(Book book)
        {
            bool bFlag;
            try
            {

                if(book.publishedYear <=0)
                {
                    return BadRequest("Invalid Published Year");
                }

                bFlag = await bookService.UpsertBooks(book);

                if (!bFlag)
                {
                    return Ok("Failed to update");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok("Successfully Updated");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePublishedBook(Book book)
        {
            bool bFlag;
            try
            {

                if (book.publishedYear <= 0)
                {
                    return BadRequest("Invalid Published Year");
                }

                bFlag = await bookService.UpsertBooks(book);

                if (!bFlag)
                {
                    return Ok("Failed to update");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok("Successfully Updated");
        }

        [HttpGet]
        public async Task<IActionResult> GetBooksById(int Id)
        {
            Book books = new Book();

            try
            {
                books = await bookService.GetBookById(Id);

                if (books == null)
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(books);
        }

        [HttpGet]
        public async Task<IActionResult> GetBooksByTitle(string title)
        {
            Book books = new Book();

            try
            {
                books = await bookService.GetBookByTitle(title);

                if (books == null)
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(books);
        }
        [HttpGet]
        public async Task<IActionResult> GetBooksByAuthor(string authorName)
        {
            List<Book> books = new List<Book>();

            try
            {
                books = await bookService.GetBookByAuthor(authorName);

                if (books == null && books.Count == 0)
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(books);
        }
    }
}
