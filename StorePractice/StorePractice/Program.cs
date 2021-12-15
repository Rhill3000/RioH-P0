// See https://aka.ms/new-console-template for more information
using System;

namespace Stores

{
    class Program
    {


        public static void Main(String[] args)
        {

            int orders;
            string? names;
            


            Console.WriteLine("Who do I have the pleasure of assisting, your name please?");
            names = Console.ReadLine();

          

            Console.WriteLine("Good Day, how many orders will you be placing today?");
            
            //use a try catch, or try parse
            bool isInt = int.TryParse(Console.ReadLine(), out orders);

           

            if(!isInt || orders < 0|| orders > 500 )
            

            {
                 Console.WriteLine(" please input a valid number of orders ");
            }
              



            Console.WriteLine("alright, please select the menu option number 1. Shirts   2. Pants   3. Belts   4.  Coats");
            int menuSelection = Convert.ToInt32(Console.ReadLine());
            if (menuSelection == 0)
            {
                Console.WriteLine("invalid response");
            }
            else if (menuSelection != 0)
            {



                if (menuSelection == 1)
                {
                    Console.WriteLine("you have selected Shirts");

                    Console.WriteLine($"Thank you {names} for your {orders} orders of shirts ");
                }
                else if (menuSelection == 2)
                {
                    Console.WriteLine("you have selected Pants");
                    Console.WriteLine($"Thank you {names} for your {orders} orders of pants ");
                }

                else if (menuSelection == 3)
                {
                    Console.WriteLine("you have selected Belts");
                    Console.WriteLine($"Thank you {names} for your {orders} orders of belts ");
                }

                else if (menuSelection == 4)
                {
                    Console.WriteLine("you have selected Coats");
                    Console.WriteLine($"Thank you {names} for your {orders} orders of coats ");
                }
                

                Console.WriteLine("to which Vintage Apparel store location will you be shipping to?");
                
                
            }
        }
    }
}


