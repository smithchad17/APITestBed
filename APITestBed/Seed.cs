using APITestBed.Data;
using APITestBed.Models;

namespace APITestBed
{
    public class Seed
    {
        private readonly DataContext dataContext;

        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        public void SeedDataContext()
        {
            if (!dataContext.BookAuthors.Any())
            {
                var bookAuthors = new List<BookAuthorModel>()
                {
                    new BookAuthorModel()
                    {
                        Book = new BookModel()
                        {
                            ISBN13 = "978-0-312-57722-3",
                            Title = "The Nightingale",
                            Genre = "Fiction",
                            Format = "Hardback",
                            Pages = 438,
                            PublicationDate = new DateTime(2015, 2, 1),
                            BookPublishers = new List<BookPublisherModel>()
                            {
                                new BookPublisherModel
                                {
                                    Publisher = new PublisherModel()
                                    {
                                        Name = "St. Martin's Press",
                                        City = "New York",
                                        State = "New York",
                                        Country = "USA"
                                    }
                                }
                            }
                        },
                        Author = new AuthorModel()
                        {
                            Last_Name = "Hannah",
                            First_Name = "Kristin"
                        }
                    },
                    new BookAuthorModel()
                    {
                        Book = new BookModel()
                        {
                            ISBN10 = "1-59448-177-6",
                            ISBN13 = "978-1-594-48177-2",
                            Title = "The Kite Runner",
                            Genre = "Fiction",
                            Format = "Paperback",
                            Pages = 371,
                            PublicationDate = new DateTime(2003, 6, 1),
                            BookPublishers = new List<BookPublisherModel>()
                            {
                                new BookPublisherModel
                                {
                                    Publisher = new PublisherModel()
                                    {
                                        Name = "Riverhead Books",
                                        City = "New York",
                                        State = "New York",
                                        Country = "USA"
                                    }
                                }
                            }
                        },
                        Author = new AuthorModel()
                        {
                            Last_Name = "Khaled",
                            First_Name = "Hosseini"
                        }
                    },
                    new BookAuthorModel()
                    {
                        Book = new BookModel()
                        {
                            ISBN10 = "1-4000-4339-5",
                            ISBN13 = "978-1-400-04339-2",
                            Title = "Never Let Me Go",
                            Genre = "Fiction",
                            Format = "Hardback",
                            Pages = 288,
                            PublicationDate = new DateTime(2005, 1, 1),
                            BookPublishers = new List<BookPublisherModel>()
                            {
                                new BookPublisherModel
                                {
                                    Publisher = new PublisherModel()
                                    {
                                        Name = "Alfred A. Knopf",
                                        City = "New York",
                                        State = "New York",
                                        Country = "USA"
                                    }
                                }
                            }
                        },
                        Author = new AuthorModel()
                        {
                            Last_Name = "Kazuo",
                            First_Name = "Ishiguro"
                        }
                    }
                };
                dataContext.BookAuthors.AddRange(bookAuthors);
                dataContext.SaveChanges();
            }
        }
    }
}
