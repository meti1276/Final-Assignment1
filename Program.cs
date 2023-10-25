using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MynewProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


public class Student
{
    public int StudentId { get; set; }

    [Required]
    [StringLength(52)]
    public string ismet { get; set; }

    [Required]
    [StringLength(52)]
    public string Kerqeli { get; set; }

    [Required]
    public DateTime EnrollmenDate { get; set; }
}


class Program
{
    static void Main()
    {
        using (var context = new StudentContext())
        {
            var newStudent = new Student
            {
                FirstName = ("Ismet"),
                LastName = ("Kerqeli"),
                EnrollmenDate("10-11-2023") = DateTime.Now
            };

            context.Students.Add(newStudent);
            context.SaveChanges();
        }

        Console.WriteLine("Student added to the database.");
    }
}
