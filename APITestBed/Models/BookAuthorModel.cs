namespace APITestBed.Models
{
    public class BookAuthorModel
    {
        public int Book_ID { get; set; }
        public int Author_ID { get; set; }

        public BookModel Book { get; set; }
        public AuthorModel Author { get; set; }
    }
}
