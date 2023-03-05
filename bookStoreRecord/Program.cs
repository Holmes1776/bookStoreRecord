using System;
namespace bookStore
{
    class Program
    {
        public record Book(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            Book harry_potter = new(1, "Harry Potter and the Chamber of Secrets", "JK Rowling", 30);
            Console.WriteLine(harry_potter);

        }
    }
}
