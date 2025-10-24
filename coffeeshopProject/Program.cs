using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshopProject
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("Welcome To Almafarq Cafe");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

            List<Beverage> orderList=new List<Beverage>();//
            Coffee coffee = new Coffee("وسط");//
            Tea tea = new Tea("كبير ");
            Juice juice = new Juice("برتقال","كبير ");
            Soda soda = new Soda("peapsi","كبير");

         //   أضافة مشروبات إلى الطلبات 
            orderList.Add(coffee);
            orderList.Add(tea);
            orderList.Add(juice);
            orderList.Add(soda);

            //المرور على كل مشروب في القائمة لتحضيره
            Console.WriteLine(" start make orders");
            foreach(Beverage drink in orderList)
            {
                drink.DrinkReady += OnDrinkReadyListener ;
                drink.prepare();
                Console.WriteLine("================================");
                Console.WriteLine("cllick  any key to exit");
                Console.ReadKey();
            }}
                public static void OnDrinkReadyListener (string message)
                {
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("have a happy day!");
                    Console.ResetColor();
                }

            
            
        
        }
    
    
    
    }

