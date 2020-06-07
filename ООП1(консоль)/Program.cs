using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ООП1_консоль_
{
    class Program
    {
        static void Main(string[] args)
        {
            int vibor = 0;
            link1:
                Console.WriteLine("\nвести \n покупателя-1 \n абонента-2 \n зоо магазин-3 \n выход-4");
                Console.Write("Ваш выбор:");
                vibor = Convert.ToInt32(Console.ReadLine());
                switch (vibor)
                {
                    case 1:pokupatel(); 
                        break;
                    case 2: abonent();
                        break;
                    case 3: zoomagazin();
                        break;
                }
                 if(vibor!=4) goto link1;
        
            void pokupatel()
            {
                Pokupatel pokupatel = new Pokupatel();
                pokupatel.Name = "" + Console.ReadLine();
                pokupatel.Fam = "" + Console.ReadLine();
                pokupatel.Otch = "" + Console.ReadLine();
                pokupatel.Adres = "" + Console.ReadLine();
                pokupatel.NumberCreditCard = "" + Console.ReadLine();
                pokupatel.NumberBankSchet = "" + Console.ReadLine();

                Console.WriteLine
                ("\nПокупатель:\n" + pokupatel.Name + " " + pokupatel.Fam + " " + pokupatel.Otch + " " + pokupatel.Adres + " " + pokupatel.NumberCreditCard + " " + pokupatel.NumberBankSchet);
            } 
            void abonent()
            {
                Abonent abonent = new Abonent();
                abonent.IndNumber = "" + Console.ReadLine();
                abonent.Name = "" + Console.ReadLine();
                abonent.Fam = "" + Console.ReadLine();
                abonent.Otch = "" + Console.ReadLine();
                abonent.Adres = "" + Console.ReadLine();
                abonent.TimeMCityTalk = "" + Console.ReadLine();
                abonent.TimeCityTalk = "" + Console.ReadLine();

                Console.WriteLine
                ("\nАбонент:\n" + abonent.IndNumber + " " + abonent.Name + " " + abonent.Fam + " " + abonent.Otch + " " + abonent.Adres + " " + abonent.NumberCreditCard + " " + abonent.TimeMCityTalk + " " + abonent.TimeCityTalk);
            }
            void zoomagazin()
            {
                ZooMagazin zooMagazin = new ZooMagazin();
                zooMagazin.Name = "" + Console.ReadLine();
                zooMagazin.Price = "" + Console.ReadLine();
                zooMagazin.Animal = "" + Console.ReadLine();
                zooMagazin.Gender = "" + Console.ReadLine();
                zooMagazin.Quantity = "" + Console.ReadLine();

                Console.WriteLine
               ("\nЗоо Магазин:\n" + zooMagazin.Name + " " + zooMagazin.Price + " " + zooMagazin.Animal + " " + zooMagazin.Gender + " " + zooMagazin.Quantity);

            }
        }
    
    }
        class Pokupatel
        {
            public string Name;
            internal string Fam;
            protected internal string Otch;
            public string Adres;
            public string NumberCreditCard;
            public string NumberBankSchet;
        }
        class Abonent
        {
            public string IndNumber;
            public string Name;
            internal string Fam;
            protected internal string Otch;
            public string Adres;
            public string NumberCreditCard;
            public string TimeMCityTalk;
            public string TimeCityTalk;
        }
        class ZooMagazin
        {
            public string Name;
            internal string Price;
            protected internal string Animal;
            internal string Gender;
            public string Quantity;
        }
    
}

