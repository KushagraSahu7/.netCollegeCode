using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Shopkeeper
    {
        int id,loyalPoints,bill;
        String name, address;

        Shopkeeper()
        {
            bill = 0;
            loyalPoints = 0;
        }
        void getData()
        {
            Console.WriteLine("Enter id,name and address");
            id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            address = Console.ReadLine();
        }

        void printData()
        {
            Console.WriteLine("ID" + id);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Address:" + address);

        }

        void doShopping()
        {
            Console.WriteLine("Enter total bill?");

            bill = Convert.ToInt32(Console.ReadLine());
            if (bill > 2000)
            {
                loyalPoints += 10;
            }

            if (loyalPoints > 100)
            {
                Console.WriteLine("Discount of 10% applied since loyality points>100");
                bill -= (bill / 10);
                loyalPoints -= 100;
            }


        }

        void showPoints()
        {
            Console.WriteLine("Current Loyal Points" + loyalPoints);
        }

        static void Main(string[] args)
        {
            Shopkeeper s = new Shopkeeper();
            s.getData();

            int choice=1;

            while(choice!=0)
            {

            Console.WriteLine("1.View Details 2.Show Credits 3.DoShopping 0.Exit");
            choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: 
                    s.printData();           
                    break;
                case 2: 
                    s.showPoints();
                    break;
                case 3: 
                    s.doShopping();
                    break;
    
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

            }

        }
    }
}
