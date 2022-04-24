using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCalculate
{
    internal class Class1
    {
        public static void discount()
        {
            Console.WriteLine("Enter the amount of goods:");
            int amount= int.Parse(Console.ReadLine());
            int discount;

            if (amount >= 30000)
            {
                discount = amount * 30 / 100;
            }
            else if (amount >=20000)
            {
                discount= amount * 20 / 100;
            }
            else if(amount >=10000)
            {
                discount= amount * 15 / 100;
            }
            else
            {
                discount= amount* 6/100;
            }
            Console.WriteLine("Congratulations....You Got Discount of :  {0} Rupees", discount);
            Console.ReadLine();
        }
    }
}
