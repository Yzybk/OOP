using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            // aşağıdaki classın bir örneği -referansı oluştu
            // not: CLASS OLUŞTURULURKEN classa vereceğimiz ismin baş harfleri büyük olur CustomerManager gibi
            // ancak class için refereans ornek oluşturuken ilk kelimenin ilki küçük sonraki ilk harf büyük yazılır. SYNTAX ONEMLİ. 
            customerManager.Add();
            customerManager.update();


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.update();
            //prodcut ile ilgili bir şey yapacağımda add ve updatei bu şekilde çagırırım
            // Yani hangi nesne ile çalışacaksam o nesneye ait classın örneğini oluşturuyorum. Sonra içindeki metodları
            // istediğim gibi çağırıyorum.

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirsName = "Yusuf";
            customer.LastName = "Bey";

            // yukarıdaki ile aşağıdaki aynı işi yapıyor yukarıda çalışan set bloğu aşağısı get bloğudur public int ID {get ; set; }
            // için
            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirsName = "Derin", LastName = "Hanım"
            };

            Console.WriteLine(customer2.FirsName);

            Console.ReadLine();          


        }
    }

}


// gruplama yaptık classları 

