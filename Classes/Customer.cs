using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        // prop yaz tab tuşuna iki kere bas bu çıkacaktır. 
        // bu bir müşterinin özelliklerini tutmak için kullandığımız nesnedir.


        //ENCAPSULATION
        // bu aşağıdakiler property - özellik 
        // bir kullanıcı first name i set edince başına ms gibi yazı yazılması gerekebilir bunu yazmak için get bloğu daha açık yazılır
        // set için de aynı şekilde daha detaylı yazılmalıdır. 
        // bir field üzerinde değeri verirken (get) veya değeri okurken ( set ) ederken başka bir şey yapmak istersen  aşağıdaki şekilde MRS Eklendiği gibi düzenleme yapılır
        // bu implementasyon detayının gizlenmesidir Bu da encapsulation denen tekniktir. (24-30 satırlar)
        // ancak genellikle bu şekilde yapılmaz. bu işlemler yerine 
        // Auto Property yapılır. Yani orjinal haliyle get set şeklinde yazılır 
        // bir özellik eklenmesi gerekirse bu şekilde düzenlenir. 
        // ilk yazılan orjinal haller 42-45. satırda başlıyor.
        /*
        public int Id { get; set; }

        /*
        private string _firstName;
        public string FirsName
        {
            get { return "Mrs." + _firstName; }
            set { _firstName = value; }
        }

        

        public string LastName { get; set; }
        public string City { get; set; }
        */

        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }



        // bu aşağıdaki field'dır 
        // public string FirstName;
    }
}
