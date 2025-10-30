using BooksManagement.DBModel;

namespace BooksManagement.Repository
{
    public class BooksRepository : IBooksRepository
    {
        private IMyDBContext dBContext;
        public BooksRepository(IMyDBContext _dBContext) { 
            dBContext= _dBContext;  
        }
        public Task<List<Book>> GetBookByAuthor(string authorName)
        {
          
        }

        public Task<Book> GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookByTitle(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveBooks(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpsertBooks(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
