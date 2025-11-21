using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                  new Student(1, "An", 16),
            new Student(2, "Binh", 14),
            new Student(3, "Anh Tu", 18),
            new Student(4, "Hoa", 17),
            new Student(5, "A Tuan", 19),
            new Student(6, "A Phuong", 20),
            new Student(7, "Linh Nhan", 20),
            new Student(8, "Minh Tri", 20),
            new Student(9, "Hong Tai", 20),
        };

            Console.WriteLine("a. Danh sach toan bo hoc sinh:");
            foreach (var s in students)
                Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");

            Console.WriteLine("\nb. Hoc sinh co tuoi tu 15 den 18:");
            var tuoi1518 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var s in tuoi1518)
                Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");

            Console.WriteLine("\nc. Hoc sinh co ten bat dau bang chu A:");
            var batDauA = students.Where(s => s.Name.StartsWith("A"));
            foreach (var s in batDauA)
                Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");

            Console.WriteLine("\nd. Tong tuoi hoc sinh:");
            int tongTuoi = students.Sum(s => s.Age);
            Console.WriteLine(tongTuoi);

            Console.WriteLine("\ne. Hoc sinh co tuoi lon nhat:");
            int maxAge = students.Max(s => s.Age);
            var lonNhat = students.Where(s => s.Age == maxAge);
            foreach (var s in lonNhat)
                Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");

            Console.WriteLine("\nf. Danh sach sap xep theo tuoi tang dan:");
            var sapXep = students.OrderBy(s => s.Age);
            foreach (var s in sapXep)
                Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}");

            Console.ReadLine();
        }
      }
    }