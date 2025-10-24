using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshopProject
{
   public static class CafeHelper
    {  //هذه الخاصية مشتركة على مستوى المشروع كلو
       //عداد لتتبع إجمالي عدد المشروبات التي تم بيعها  يمكن قرائتها من أي مكان لكن لا يمكن تعديها ألا من هذه الفئة 
       public static int TotalDrinksSold { get; private set;}
       static CafeHelper()
       {
           TotalDrinksSold = 0;
       }

       //وأيضاً دالة لتسجيل عمليات البيع الجديدة وزيادة العداد
       public static void RecordSale()
       {
       TotalDrinksSold++;// لزياد العداد واحد 
       
       }
    }
}
