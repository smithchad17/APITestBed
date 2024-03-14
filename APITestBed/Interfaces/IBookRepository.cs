using APITestBed.Models;

namespace APITestBed.Interfaces
{
    public interface IBookRepository
    {
        ICollection<BookModel> GetBooks();
    }
}
