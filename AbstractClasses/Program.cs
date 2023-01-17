using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {

        // interface ve virtual method birleşimi gibi inheritance olarak düşününlebiir.
        static void Main(string[] args)
        {
            //interface gibi abstract class ları da new yapamayız bu sebeple 

            // sadece oracle veya sql servere implemente edebiliriz
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();

            Console.ReadLine();

        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        // mesela burada örnek olarak public void add diyerek eklemeyi tüm databaselerde aynı olacak şekilde girdik 
        // ancak Delete methodunu abstract ettik. yani örnek olarak silme işlemini heryerde farklı kabul ettik 
        // bu tamamlanmış methoddur. 
        
       
        public abstract void Delete();


    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }

}
