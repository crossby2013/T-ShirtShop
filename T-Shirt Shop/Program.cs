using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_ShirtShop
{
    class Program
    {
        static void Main(string[] args)
        {
            TShirt order1 = new TShirt(TShirtSize.S,TShirtColor.Green); 
            TShirt order2 = new TShirt(TShirtSize.L,TShirtColor.Blue);
            TShirt order3 = new TShirt(TShirtSize.M, TShirtColor.Red);

            Console.WriteLine("Customer 1 ordered:" + (int)order1.Size + " " + order1.Color);
            Console.WriteLine("Customer 2 ordered:" + (int)order2.Size + " " + order2.Color);
            Console.WriteLine("Customer 3 ordered:" + (int)order3.Size + " " + order3.Color);
         
        }
         
    }
       
   
}
