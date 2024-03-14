namespace APITestBed.Models
{
    public class BookModel
    {
        public int Book_ID { get; set; }
        public string? ISBN13 { get; set; }
        public string? ISBN10 { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? SubTitle { get; set; }
        public string? Description { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string? Genre { get; set; }
        public string? Genre_Code { get; set; }
        public int? Edition { get; set; }
        public string? Language { get; set; }
        public string? Format { get; set; }
        public int? Pages { get; set; }

        public ICollection<BookAuthorModel> BookAuthors { get; set; }

        public ICollection<BookPublisherModel> BookPublishers { get; set; }
    }
}
