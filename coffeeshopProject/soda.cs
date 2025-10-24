using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshopProject
{ // يمثل مشروب غازي  معلباً
     public class Soda: Beverage 
    {
         public Soda(string sodaName,string size)
             {
                 name = sodaName;// اسم المشروب الغازي 
                 Size = size;
                 Price = 2500;// سعر موحد للمشروبات الغازية 


         }

         // تطبيق دالة المجردة(override) 
         public override void prepare()
         {
             Console.WriteLine(" start prepare the soda you want");
             Console.WriteLine("1. bring the soda from the fridge");
             Console.WriteLine("2.open the soda and put it in a cup with ice ");
             Console.WriteLine("3.the soda is prepared");
             OnDrinkReady();
         }
    }
}
