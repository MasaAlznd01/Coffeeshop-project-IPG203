using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshopProject
{
    //يمثل مشروب عصير طازج وترث هذه الفئم من  Beverage 
    // لايوجد هنا حليب او سكر 
   public class Juice : Beverage
    {
       string fruitType;
       public Juice( string size,string fruit)
       {
           fruitType = fruit;
           name = "juice";
           Size = size;

           if (size=="صغير ")
           {
               Price = 3000;

           }
           else if (size == "")
           {
               Price = 3500;

           }
           else {
               Price = 4000;
           }
       }
       // تطبيق الدالة المجردة  (override)
       public override void prepare()
       {
           Console.WriteLine(" start make the cup of juice");
           Console.WriteLine("1. prepare fresh fruits");
           Console.WriteLine("2.putting freash fruit in a juicer");
           Console.WriteLine("3.the juice has been prepared");

           OnDrinkReady();
       }
    
   }
}
