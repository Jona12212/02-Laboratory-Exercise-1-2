using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataTypesApp
{
    internal class DataTypesProgram
    {
        static void Main(string[] args)
        {
            //To enter number of Apples
            Console.Write("Enter the pieces of apple: ");
            int numApples = Convert.ToInt32(Console.ReadLine());
            //To enter number of Apples 
            Console.Write("Enter total price of " + numApples + " apple(s): ");
            Double priceApples = Convert.ToDouble(Console.ReadLine());
            //display original price
            Console.WriteLine("The value of original price is " + priceApples);
            int appConvertedPrice = (int) priceApples;
            //display converted price
            Console.WriteLine("The value of converted price is "+ appConvertedPrice);
            //equation for individual price of apple 
            double oneApple = ((double) priceApples/numApples );
            double Quotient = Math.Round(oneApple, 2);
            //display for individual price of apple
            Console.WriteLine("The price of one apple is " + Quotient);
        }
    }
}
