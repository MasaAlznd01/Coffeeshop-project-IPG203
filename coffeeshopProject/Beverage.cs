using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshopProject
{
      public  abstract class Beverage
    {
        // الخصائص المشتركة بين المشروبات 
        public string name { get; set; } // خاصية لتخزين أسم الشروب 
        public string Size { get; set; }//خاصية لتخزين حجم المشروب صغير او وسط او كبير 
        public double Price { get; private set; } // خاصية لتخزين السعر  للقراءة فقط من الخارج 

        public abstract void prepare(); // هذه الدالة ستصف طريقة تحضير كل المشروبات 

        public delegate void DrinkReadyHandler(string message);// delegate هو بمثابة مؤشر لدالة تستقبل رسائل نصية 
        public event DrinkReadyHandler DrinkReady;// الحدث الذي سيتم اطلاقه عندما يصبح المشروب جاهزاً
        protected void OnDrinkReady()// الدالة المساعدةلاطلاق الحدث 
        {
            CafeHelper.RecordSale();

            if (DrinkReady != null)
            {
                DrinkReady(" The drink is ready ");
            }
        }
    }
}
