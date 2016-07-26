using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreSample.Entity;

namespace EFCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {

            var db = new DatabaseContext();
            db.Books.Add(new Book() {Title = "TEST"});
            db.SaveChanges();

            var book = db.Books.First();
            Console.WriteLine($"ID:{book.Id}  TITLE:{book.Title}");

            Console.ReadLine();
        }
    }
}
