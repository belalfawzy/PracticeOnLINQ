using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using Assignment17_linq;
using ConsoleTables;
namespace Assignment17_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = SampleData.Books;
            var subjects = SampleData.Subjects;
            var authors = SampleData.Authors;
            var publisher = SampleData.Publishers;

            /*------------------------------------------------------------------------------------*/

            //var Q1 = from b in books
            //         select new { b.Title, b.Isbn };
            // ConsoleTableHelper.DisplayResults(Q1,"QUERY 1");

            /*-----------------------------------------------------------------------------------*/

            //var Q2 = books.Where(b => b.Price > 20).Take(3).Select(b => new { b.Title, b.Price });
            //ConsoleTableHelper.DisplayResults(Q2, "QUERY 2");

            /*------------------------------------------------------------------------------------*/

            //// --1
            //var Q3_1 = books.Select(b => new { b.Title, b.Publisher });
            //ConsoleTableHelper.DisplayResults(Q3_1, "QUERY 3_1");


            ////--2

            //var Q3_2 = from b in books
            //           select new{ b.Title, b.Publisher };
            //ConsoleTableHelper.DisplayResults(Q3_2, "QUERY 3_2");

            /*------------------------------------------------------------------------------------*/

            //var Q4 = books.Count(b => b.Price > 20);
            //Console.WriteLine(Q4);

            /*------------------------------------------------------------------------------------*/

            //var Q5 = books.OrderBy(b => b.Subject.Name)
            //    .ThenByDescending(b => b.Price).Select(b => new { b.Title, b.Price, b.Subject });
            //ConsoleTableHelper.DisplayResults(Q5, "QUERY 5");

            /*------------------------------------------------------------------------------------*/
            ////--1

            //var Q6_1 = from s in subjects
            //         join b in books on s equals b.Subject into subjectBooks
            //         select new
            //         {
            //             SubjectName = s.Name,
            //             Books = subjectBooks.Select(b => b.Title).ToList()
            //         };

            //foreach (var a in Q6_1)
            //{
            //    Console.WriteLine($"\nSubject: {a.SubjectName}\nBooks: ");
            //    foreach (var b in a.Books)
            //    {
            //        Console.WriteLine(b);
            //    }
            //}

            ////--2

            //Console.WriteLine("\n--------------------------------------------------\n");

            //var Q6_2 = subjects.GroupJoin(books,s => s,b => b.Subject,
            //   (s, b) => new
            //   {
            //       SubjectName = s.Name,
            //       Books = b.Select(b => b.Title).ToList()
            //   });

            //foreach (var a in Q6_1)
            //{
            //    Console.WriteLine($"\nSubject: {a.SubjectName}\nBooks: ");
            //    foreach (var b in a.Books)
            //    {
            //        Console.WriteLine(b);
            //    }
            //}
            /*-------------------------------------------------------------------------------*/

            //var B = SampleData.GetBooks().Cast<Book>();
            //var Q7 = from b in B
            //         select new
            //                     {
            //                         b.Title,
            //                         Price = b.Price
            //                     };

            //ConsoleTableHelper.DisplayResults(Q7, "QUERY 7");


            /*-------------------------------------------------------------------------------*/

            //var Q8 = from b in books
            //         group b by b.Publisher into bk
            //         select new
            //         {
            //             Publisher = bk.Key,
            //             s = from a in bk
            //                 group a by a.Subject into sub
            //                 select new
            //                 {
            //                     Subject = sub.Key.Name,
            //                     Books = sub.Select(b => b.Title).ToList()
            //                 }
            //         };
            //foreach (var publisherGroup in Q8)
            //{
            //    Console.WriteLine($"\nPublisher: {publisherGroup.Publisher}");
            //    foreach (var subjectGroup in publisherGroup.s)
            //    {
            //        Console.WriteLine($"  Subject: {subjectGroup.Subject}");
            //        Console.WriteLine("  Books:");
            //        foreach (var book in subjectGroup.Books)
            //        {
            //            Console.WriteLine($"    - {book}");
            //        }
            //    }
            //}


            /*----------------------------------------------------------------------------*/
        }
      
        public static class ConsoleTableHelper
        {
            public static void DisplayResults<T>(IEnumerable<T> results, string queryTitle)
            {
                Console.WriteLine($"\n{queryTitle}");
                var table = ConsoleTable.From(results);
                table.Write();
            }
        }
    }
}
