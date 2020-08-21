using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuples
{
    static class BookExamples
    {
        static readonly List<Book> books = new List<Book> {
             new Book (1, "Dr No","Ian Fleming"),
             new Book (2, "Goldfinger","Ian Fleming"),
             new Book (3, "Pride and Prejudice","Jane Austen"),
             new Book (4, "Mansfield Park","Jane Austen"),
             new Book (5, "Harry Potter and the Philosopher's Stone","J.K. Rowling"),
             new Book (6, "Harry Potter and the Chamber of Secrets","J.K. Rowling")
            };


        public static void ProcessBooks()
        {
            //foreach(var book in books)
            //    Console.WriteLine(book);

            Book book1 = books.First();

            var ( t, _) = book1;

            Console.WriteLine(t);

        }

    }
}
