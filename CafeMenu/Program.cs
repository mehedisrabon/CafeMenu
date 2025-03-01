using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeMenu
{
    class FoodMenu
    {
        private string[] foods = new string[5];

        // Manual indexer with hard-coded indices
        public string this[int index]
        {
            get
            {
                if (index == 0) return foods[0];
                else if (index == 1) return foods[1];
                else if (index == 2) return foods[2];
                else if (index == 3) return foods[3];
                else if (index == 4) return foods[4];
                return null;
            }
            set
            {
                if (index == 0) foods[0] = value;
                else if (index == 1) foods[1] = value;
                else if (index == 2) foods[2] = value;
                else if (index == 3) foods[3] = value;
                else if (index == 4) foods[4] = value;

            }
        }

        // Method to display the food menu
        public void DisplayMenu()
        {
            Console.WriteLine("Current Menu:");
            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {foods[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu menu = new FoodMenu();

            // Manually assign food items
            menu[0] = "Burger";
            menu[1] = "Meatbox";
            menu[2] = "Coffee";
            menu[3] = "Wedges";
            menu[4] = "Pizza";

            // Display the menu
            menu.DisplayMenu();

            // Update a food item
            Console.WriteLine("\nUpdating food item at index 1 to 'Sandwich'...");
            menu[1] = "Sandwich";

            // Display the updated menu
            menu.DisplayMenu();
        }
    }
}
