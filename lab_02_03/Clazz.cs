using System;


namespace library
{

    class BookException : Exception
    {
        public BookException(string title, double price, int numberPages)
            : base("For " + title + ", ratio is invalid. \nPrice is $" + price + " for " + numberPages + " pages.")
        {

        }
    }

    class Book
    {
        public Book(string title, string author, double price, int numberPages)
        {
            if ((price / numberPages) > 0.1)
            {
                throw new BookException(title, price, numberPages);
            }
        }

        private string title;
        private string author;
        private double price;
        private int numberPages;


        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int NumberPages
        {
            get
            {
                return numberPages;
            }
            set
            {
                numberPages = value;
            }
        }

    }

    class Clazz
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book("Jungle Book", "Kipling", 25.99, 50));
            bookList.Add(new Book("The Hobbit", "Tolkien", 2.99, 30));
            bookList.Add(new Book("1984", "Orwell", 31.32, 15));
            bookList.Add(new Book("Guide to Networks", "Somebody", 17.56, 500));
            try
            {
                foreach(Book book in bookList)
                {
                    Console.WriteLine(book.ToString());
                }
            }
            catch (BookException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.Read();
        }
    }
}