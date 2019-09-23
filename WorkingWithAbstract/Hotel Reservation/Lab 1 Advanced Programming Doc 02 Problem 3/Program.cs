using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Lab_1_Advanced_Programming_Doc_02_Problem_3
{

    class Program
    {
        public static void Main(string[] args)
        {     
            Console.WriteLine("Seasons List:\n Spring \n Summer \n Autumn \n Winter \n \n");
            Console.WriteLine("List of Discount Type: \n VIP \n SecondVisit \n \n");
            Console.WriteLine("Enter ''Price Per Day'', ''Number of Days'', ''Season'', " +
                "and then ''(Discount type)'' to get the total price: \n");
            string command = Console.ReadLine();
            string[] commandArgs = command.Split();
            decimal PricePerDay = Convert.ToDecimal(commandArgs[0]);
            int NumberOfDays = Convert.ToInt32(commandArgs[1]);
            int SeasonPrice;
            switch (commandArgs[2])
            {
                case "Autumn":
                    SeasonPrice = 1;
                    break;
                case "Spring":
                    SeasonPrice = 2;
                    break;
                case "Winter":
                    SeasonPrice = 3;
                    break;
                case "Summer":
                    SeasonPrice = 4;
                    break;
                default:
                    SeasonPrice = 1;
                    break;
            }
            double DiscountPrice;
            switch (commandArgs[3])
            {
                case "VIP":
                    DiscountPrice = 0.2;
                    break;
                case "SecondVisit":
                    DiscountPrice = 0.1;
                    break;
                default:
                    DiscountPrice = 0;
                    break;
            }
            double basisPrice = Convert.ToDouble(PricePerDay) * NumberOfDays * SeasonPrice;
            double totalPrice = basisPrice - (basisPrice * DiscountPrice);
            Console.WriteLine("Totol Price is: {0}", totalPrice);
            Console.ReadKey();
        }
    }
}
