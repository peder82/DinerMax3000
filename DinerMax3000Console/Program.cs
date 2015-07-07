using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business;
using DinerMax3000.Business.dsDinerMax3000TableAdapters;


namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Menu> menusFromDatabase = Menu.GetAllMenus();
            Menu firstMenu = menusFromDatabase[0];

            //firstMenu.SaveNewMenuItem("Lasanga", "Perfect if you are cold and hungry", 18);
            //menusFromDatabase = Menu.GetAllMenus();
                        
            Order hungryGuest = new Order();

            foreach (var currentMenu in menusFromDatabase)
            {
                foreach (var currentMenuItem in currentMenu.items)
                {
                    hungryGuest.items.Add(currentMenuItem);
                }
            }
            
            Console.WriteLine("Total price is: " + hungryGuest.Total);

            Console.ReadKey();
        }
    }
}
