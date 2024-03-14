namespace APITestBed.Models
{
    public class BookPublisherModel
    {
        public int Book_ID { get; set; }
        public int Publisher_Id { get; set; }

        public BookModel Book { get; set; }
        public PublisherModel Publisher { get; set; }
    }
}
