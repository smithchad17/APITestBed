namespace APITestBed.Models
{
    public class AuthorModel
    {
        public int Author_ID { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }

        public ICollection<BookAuthorModel> BookAuthors { get; set; }
    }
}
