using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer menu";
            summerMenu.AddMenuItem("Salmon", "Norwegian fresh salmon with butter", 25.50);
            summerMenu.AddMenuItem("Taco", "Spicy meat with cheese", 15.00);
            summerMenu.HospitalDirection = "Right around the corner at 5th street";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Dont drink and drive";
            try
            {
                outsideDrinks.AddMenuItem("Cube Libre", "A classic", 5.00);
                outsideDrinks.AddMenuItem("Pepsi", "Control yourself", 3.50);
                outsideDrinks.AddMenuItem("Pepsi", "Control yourself", -3.50);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Order hungryGuest = new Order();
            foreach (var item in summerMenu.items)
            {
                hungryGuest.items.Add(item);
            }

            Console.WriteLine("Total price is: " + hungryGuest.Total);

            Console.ReadKey();
        }
    }
}
