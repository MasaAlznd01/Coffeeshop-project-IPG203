using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshopProject
{ // هذه الفئة خاصة بالشاي
   public class Tea : Beverage,IHasMilk,IHasSuger
   {
   public Tea(string size)
       {
           name = "شاي";
           Size = size;
           if(size=="صغير")
           {
               Price = 1000;
           }
           else if (size == "وسط")
           {
               Price = 1500;
           }
           else {
               Price = 2000;
           }
       }
       //(Over) تطبيق الدالة المجردة  
       public override void prepare()
       {
           Console.WriteLine(" start make tea");
           Console.WriteLine("1.boil water");
           Console.WriteLine("2.Put the tea bag in the cup");
           Console.WriteLine("3.the tea has been prepared");
           OnDrinkReady();
       }
       public void AddMilk()
       {
           Console.WriteLine("Add milk to tea");
           this.Price += 500;
       
       }
       public void AddSuger()
       {
           Console.WriteLine("add suger to the tea");
       }
   }
    
    
}
