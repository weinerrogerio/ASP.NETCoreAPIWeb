namespace ASP.NETCoreAPI.Models.Seeds
{
    public static class BookSeed
    {
        public static List<Book> GetPredefinedBooks()
        {
            return new List<Book>()
            {   
                new Book
                {
                    Id = 1,
                    Author = "Michael C. Feathers",
                    Launch_date = DateTime.Parse("2004-09-01"),
                    Price = 49.00m,
                    Title = "Working Effectively with Legacy Code"

                },
                new Book
                {
                    Id = 2,
                    Author = "Ralph Johnson, Erich Gamma, John Vlissides, Richard Helm",
                    Launch_date = DateTime.Parse("1994-10-21"),
                    Price = 45.00m,
                    Title = "Design Patterns: Elements of Reusable Object-Oriented Software"
                },
                new Book
                {
                    Id = 3,
                    Author = "Robert C. Martin",
                    Launch_date = DateTime.Parse("2008-08-11"),
                    Price = 77.00m,
                    Title = "Clean Code: A Handbook of Agile Software Craftsmanship"
                },
                new Book
                {
                    Id = 4,
                    Author = "Douglas Crockford",
                    Launch_date = DateTime.Parse("2008-05-15"),
                    Price = 67.00m,
                    Title = "JavaScript: The Good Parts"
                },
                new Book
                {
                    Id = 5,
                    Author = "Steve McConnell",
                    Launch_date = DateTime.Parse("2004-06-09"),
                    Price = 58.00m,
                    Title = "Code Complete (2nd Edition)"
                },
                new Book
                {
                    Id = 6,
                    Author = "Martin Fowler, Kent Beck",
                    Launch_date = DateTime.Parse("1999-07-08"),
                    Price = 88.00m,
                    Title = "Refactoring: Improving the Design of Existing Code"
                },
                new Book
                {
                    Id = 7,
                    Author = "Eric Freeman, Elisabeth Freeman, Kathy Sierra, Bert Bates",
                    Launch_date = DateTime.Parse("2004-10-25"),
                    Price = 110.00m,
                    Title = "Head First Design Patterns"
                },
                new Book
                {
                    Id = 8,
                    Author = "Eric Evans",
                    Launch_date = DateTime.Parse("2003-08-30"),
                    Price = 92.00m,
                    Title = "Domain-Driven Design: Tackling Complexity in the Heart of Software"
                },
                new Book
                {
                    Id = 9,
                    Author = "Brian Goetz, Tim Peierls",
                    Launch_date = DateTime.Parse("2006-05-09"),
                    Price = 80.00m,
                    Title = "Java Concurrency in Practice"
                },
                new Book
                {
                    Id = 10,
                    Author = "Susan Cain",
                    Launch_date = DateTime.Parse("2012-01-24"),
                    Price = 123.00m,
                    Title = "Quiet: The Power of Introverts in a World That Can''t Stop Talking"
                },
                new Book
                {
                    Id = 11,
                    Author = "Roger S. Pressman",
                    Launch_date = DateTime.Parse("2009-01-01"),
                    Price = 56.00m,
                    Title = "Software Engineering: A Practitioner''s Approach (7th Edition)"
                },
                new Book
                {
                    Id = 12,
                    Author = "Viktor Mayer-Schonberger, Kenneth Kukier",
                    Launch_date = DateTime.Parse("2013-03-05"),
                    Price = 54.00m,
                    Title = "Big Data: A Revolution That Will Transform How We Live, Work, and Think"
                },
                new Book
                {
                    Id = 13,
                    Author = "Richard Hunter, George Westerman",
                    Launch_date = DateTime.Parse("2009-01-01"),
                    Price = 95.00m,
                    Title = "The Real Business of IT: How CIOs Create and Communicate Value"
                },
                new Book
                {
                    Id = 14,
                    Author = "Aguinaldo Aragon Fernandes, Vladimir Ferraz de Abreu",
                    Launch_date = DateTime.Parse("2000-01-01"),
                    Price = 54.00m,
                    Title = "Implementing IT Governance: A Practical Guide to Global Best Practices in IT Management"
                },
                new Book
                {
                    Id = 15,
                    Author = "Marc J. Schiller",
                    Launch_date = DateTime.Parse("2012-01-01"),
                    Price = 45.00m,
                    Title = "The 11 Secrets of Highly Influential IT Leaders"
                }
            };  
        }
    }
}
