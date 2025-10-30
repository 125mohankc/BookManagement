using BooksManagement.DBModel;

namespace BooksManagement.Services
{
    public interface IBookServices
    {
        Task<bool> UpsertBooks(Book book);

        Task<bool> RemoveBooks(int id);

        Task<Book> GetBookById(int id);

        Task<Book> GetBookByTitle(string title);

        Task<List<Book>> GetBookByAuthor(string authorName);
    }
}
