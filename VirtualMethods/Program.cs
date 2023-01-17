using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }
    // bir classın var çeşitli operasyonları var 

    // mesela databese class açtık add diye method ekledik ekleme methodu. add ve delete operasyonları mevcut

    //
    class Database
    {

        // publicten sonra virtual yazmak Sql i veya Mysql i kullanan kişi
        // aşağıdaki added by default aralığındaki kod tüm veritabanları için geçerli
        // fakat SqlServer ' a gelince ekleme yaparken daha farklı kod yazma zorunluluğu doğuyor.
        // bu sebeple override ve base kodlarını yazarak base kodu ezdirerek istediğimizi server üzerinde yazarız.
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }


        public virtual void Delete()

        {
            Console.WriteLine("Deleted by default");
        }


    }
        // bu class SqlServer : Database demek siz sql server için databesi 'in add ve deletini kullanabilirsin demek


    // override Add yazınca public override void add ekler
    // base.Add(); yukarıdaki databasede olan kodu ekler. 
    // inheritance yaptığın ortamda yazdığın kodu diğer serverlarda değiştirmek yani ezebilmek için
    // virtual method + override + base i devre dışı bırakman (veya base i de yazdırman ) gerekir
    // işte bu olayı interface ile yapamayız.
    // interfacelerde amacımız imzaları oluşturmak ve onu implemente eden sınıfın  bütün imzaları tekrar yazmasını sağlamak. bunu zorunlu hale getirip kullanıyorduk.

        class SqlServer : Database
        {
        public override void Add()
        {
            Console.WriteLine("Added by SqlServer");
            //base.Add();
        }
    }
        class MySql : Database
        {

        }
    
}
