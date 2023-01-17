using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();
            // bir verimiz var hem şirketin sql veri tabanına hem oracle veri tabanına 
            // yazmak için ;

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal(),
            };

            foreach ( var customerDal in customerDals)
            {
                customerDal.Add();
            }


            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Yusuf",
                LastName = "Bey",
                Address = "Denizli"
            };

            Student student = new Student
            {

                Id = 1,
                FirstName = "Yusuf",
                LastName = "Bey",
                Department = "Computer Sciences"
            };
            manager.Add(customer);
            manager.Add(student);
        }
    }



    // ilk harf I BÜYÜK SONRAKİ İLK İSİM HARFİ BÜYÜKTÜR

    // interface soyuttur class lar somut.
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }

        string LastName { get; set; }


    }
    // public versiyonları yazılması gerekli

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
