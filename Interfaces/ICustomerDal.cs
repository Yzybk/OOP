using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    
    // ICustomerDal bir interface
    internal interface ICustomerDal
    {
        void Add();
        void Update();  
        void Delete();  

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }
    }


    // yeni bir veritabanı eklemek için yeni bir class açıp 
    // bu classa yeni veritabanını tanımlayıp Program.cs de bulunan IcustomerDal arrayine new MySql... ekleyerek otomatik olarak 
    // tüm yeni dosyaları ekleme imkanına kavuşuruz 

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {

            customerDal.Add();

        }


        // biz burada Polymorphism (Çok Biçimlilik) yaptık. bir nesneyi farklı amaçlarla
        // implemente edip o implementasyonların belli bir kısmına ulaşmaktır.
        // biz burada IcustomerDal ı SqlServerCustomerDal biçiminde ve OracleCustomerDal biçiminde implemente ettik bu  polymorphisim

        


    }



}
