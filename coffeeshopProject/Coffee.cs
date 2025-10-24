using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshopProject
{// يمثل مشروب القهوة 
   //هذه الفئة ترث الخصائص والسلوكيات الاساسية من الفئة المجرد (Beverage) وتطبق واجهات  الحليب والسكر 
   public class Coffee : Beverage,IHasMilk,IHasSuger
    {
       //الدالة البناءة (constructor) يتم استدعاءها عند إنشاء كائن جديد من القهوة 
       public Coffee(string size)
       {
           name = "قهوة";
           Size = size;
           if(size=="صغير")
           {
               Price = 2000;
           }
           else if (size == "وسط")
           {
               Price = 2500;
           }
           else {
               Price = 3000;
           }
       }
       //(Override) تطبيق الدالة المجردة  
       public override void prepare()
       {
           Console.WriteLine(" start make coffee");
           Console.WriteLine("1.Grinding Freash coffee beans");
           Console.WriteLine("2.Putting coffee in the coffee maker");
           Console.WriteLine("3.the coffe has been prepared");
           OnDrinkReady();
       }
       public void AddMilk()
       {
           Console.WriteLine("Add milk to coffee");
           this.Price += 500;
       
       }
       public void AddSuger()
       {
           Console.WriteLine("Add suger to coffee");
       }
    }
}
