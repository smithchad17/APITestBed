namespace APITestBed.Models
{
    public class PublisherModel
    {
        public int Publisher_ID { get; set; }
        public string Name { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }

        public ICollection<BookPublisherModel> BookPublishers { get; set; }
    }
}
