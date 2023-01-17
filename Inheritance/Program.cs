using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Yusuf"
                },

                new Student
                {
                    FirstName = "Yavuz"
                }, 

                new Person
                {
                    FirstName = "Selen"
                }

            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    // Customer persondan geliyor. 1 adet atası var yani 1 kere inheritance alabilirsin 
    // interface oluştursaydık persondan sonra olmak şartıyla yazabilirdik. İnterfaceler birer implementasyondur
    // Customer persondır. 
    // Abstract class lar inheritance'lar için çok onemlidir. 
    // interface kullanıyorsanız inheritancee ihtiyaç yoksa sorun yok .
    // virtual method ile ne zaman interface ne zaman inheritance karar verebiliriz yeni cons. app mevcut. as VirtualMethods


    class Customer : Person
    {
        public string City { get; set; }    

    }
    class Student : Person
    {
        public string Department { get; set; }

    }
}
