using APITestBed.Data;
using APITestBed.Interfaces;
using APITestBed.Models;

namespace APITestBed.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<BookModel> GetBooks()
        {
            return _context.Books.OrderBy(b => b.Book_ID).ToList();
        }
    }
}
