using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new smsLogger();
            customerManager.Add();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()

        {

            Logger.Log();
            Console.WriteLine("Customer added!");
        }

        // bu çalıştırılan kodu loglamak yani kayıt altına almak istiyoruz
    }

    class DatabaseLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.Write("Logged to file! ");
        }
    }
    class smsLogger : ILogger
    {
        public void Log()
        {
            Console.Write("Logged to sms! ");
        }
    }

    interface ILogger
    {
        void Log();
    }

    //bir classı dümdüz class Logger şeklinde görürsen kork bunu sadece newleyip kullanabilirsin bir interface i yok çünkü 
    // ilerde yeni bir loglama yapacak olursan bir metin dosyasında tutmak istiyorsan tüm loggerları değiştirmek yerine yapılacak iş 
    // class Logger : Ilogger gibi bir base atamalısın 
    // yani istersek customer managerde public propertiyde ILogger türünde logger ürettik bu sayede
    // customerManager.Logger=new SmsLogger(); koduyla stratejimizi ayarladık SmsLogger i FileLogger vb şeylerle değiştiriğ stratejimizi düzenleyebilme imkanı tanıdık 
    // interfaceleri kullanarak temel implementasyon yaptık
    // interface tercih etme sebebim Databasede loglama ayrı kullanır, file da loglama kodu ayrıdır, smsde farklıdır.
    // //kullanan herkesin  ayrı ayrı implamantasyon yapması için bu şekilde yaptık ama boyle olmasaydı 
    // databaseler file e yazarken kodlar aynı olasydı sadece smste değişiyor olsaydı bunu virtual yapardık.
    //aynı şey abstractlar için de geçerli yani bir methodu herkes değiştirecek bir methodum heryerde aynı o zaman abstract yapardım
    // normalde bu işlem property ile değil CONSTRUCTOR İLE YAPILIR
}
