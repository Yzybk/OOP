using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class CustomerManager
    {
        public void Add()  //bu bir method
        {
            Console.WriteLine("Customer Added!");
            // burada customer added yazdırıyoruz bunu CustomerManager
            // clasında add methodunun içinde yapıyoruz.
        }
        public void update() // yeni bir method ekledik 
        {
            Console.WriteLine("Customer Updated!");
            // bu yeni methoda bir mesaj ekledik
        }
        // 1 class oluştuduk  ve 2 method var bu şekilde kullanmak için bir örnek oluşturulmalı
        // BU ÖRNEK - REFERANS satır 13 de 


        /// BURADA CLASSI yeni bir dosya olarak ekledik bu şekilde ayrı bir yerde de yazarak çalıştırabiliriz. CLASSES SAĞ TIKLA ADD VE CLASS.
    }
}
