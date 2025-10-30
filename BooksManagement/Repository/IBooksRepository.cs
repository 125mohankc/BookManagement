using BooksManagement.DBModel;

namespace BooksManagement.Repository
{
    public interface IBooksRepository
    {
        Task<bool> UpsertBooks(Book book);

        Task<bool> RemoveBooks(int id);

        Task<Book> GetBookById(int id);

        Task<Book> GetBookByTitle(string name);

        Task<List<Book>> GetBookByAuthor(string authorName);


    }
}
