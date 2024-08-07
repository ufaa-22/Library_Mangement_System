using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangement_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            MemberManagement memberManagement = new MemberManagement();
            BorrowingSystem borrowingSystem = new BorrowingSystem();

            Book book1 = new Book("Book One", "Sayed", 3);
            Book book2 = new Book("Book Two", "Ali", 2);

            library.AddBook(book1);
            library.AddBook(book2);

            Member member1 = new Member(1, "Mohamed");
            Member member2 = new Member(2, "Youssef");

            memberManagement.RegisterMember(member1);
            memberManagement.RegisterMember(member2);

            borrowingSystem.BorrowBook(member1, book1);
            borrowingSystem.BorrowBook(member2, book2);

            library.DisplayAllBooks();
            memberManagement.DisplayAllMembers();

            borrowingSystem.ReturnBook(member1, book1);
            borrowingSystem.ReturnBook(member2, book2);

            library.DisplayAllBooks();
            Console.ReadKey();
        }
    
    }
}
