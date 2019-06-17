using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullOperatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
                Student student = new Student();
                #region Antes
                //if (student != null && student.Address != null)
                //{
                //    Console.WriteLine(student.Address.HomeAddress);
                //}
                //else
                //{
                //    Console.WriteLine("No Home Address");
                //}
                #endregion
         

                // Ahora
                Console.WriteLine(student?.Address?.HomeAddress??"No Home Address");

            Console.ReadKey();
        }
    }

    internal class Student
    {
        public Address Address { get; set; }
        public Student()
        {
            Address = new Address();
        }
    }
    internal class Address
    {
        public string HomeAddress { get; set; } = "Av Guillermo Dansey";
    }
}
