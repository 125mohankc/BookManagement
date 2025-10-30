using BooksManagement.DBModel;
using BooksManagement.Repository;

namespace BooksManagement.Services
{
    public class BookServices:IBookServices
    {

        private readonly IBooksRepository bookRepo;
        public BookServices(IBooksRepository _bookRepo) { 
        bookRepo= _bookRepo;
        }

        public async Task<List<Book>> GetBookByAuthor(string authorName)
        {
            return await bookRepo.GetBookByAuthor(authorName);
        }

        public async Task<Book> GetBookById(int id)
        {
            return await bookRepo.GetBookById(id);
        }

        public async Task<Book> GetBookByTitle(string name)
        {
            return await bookRepo.GetBookByTitle(name);
        }

        public async Task<bool> RemoveBooks(int id)
        {
            return await bookRepo.RemoveBooks(id);
        }

        public async Task<bool> UpsertBooks(Book book)
        {
            return await bookRepo.UpsertBooks(book);
        }
    }
}
