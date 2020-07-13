using Microsoft.EntityFrameworkCore;
using StudentAppDotNetCore.Database;
using System;

namespace StudentAppDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (dbStudent db = new dbStudent())
            {
                var lst = db.Set<student>().FromSqlRaw("select tab1.*, tab2.* from student tab1 inner join subjects tab2 on tab1.id = tab2.studid");
                foreach (var stud in lst)
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"Student FirstName {stud.firstname} LastName {stud.lastname} has following subjects...");
                    foreach (var sub in stud.subjects)
                    {
                        Console.WriteLine($"Subject ID: {sub.id}, Subject Name: {sub.subName}");
                    }
                    Console.WriteLine("----------------------------");
                }
            }
            Console.ReadLine();
        }
    }
}
