using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangement_System
{
    internal class BorrowingSystem
    {
        private List<(Member, Book)> borrowedBooks = new List<(Member, Book)>();

        public void BorrowBook(Member member, Book book)
        {
            if (book.NumberOfCopies > 0)
            {
                borrowedBooks.Add((member, book));
                book.NumberOfCopies--;
            }
            else
            {
                Console.WriteLine("No copies available to borrow.");
            }
        }

        public void ReturnBook(Member member, Book book)
        {
            var borrowedBook = borrowedBooks.FirstOrDefault(b => b.Item1 == member && b.Item2 == book);
            if (borrowedBook != default)
            {
                borrowedBooks.Remove(borrowedBook);
                book.NumberOfCopies++;
            }
            else
            {
                Console.WriteLine("This book was not borrowed by the member.");
            }
        }
    }
}
