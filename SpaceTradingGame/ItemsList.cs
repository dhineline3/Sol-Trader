using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//List of all inventory items as well as possible purchases 
namespace SpaceTradingGame
{
    class ItemsList
    {
        public static void CurrentInventory()
        {
            List<string> Inventory = new List<string>();
            string[] InventoryArray =
            {
            "1. Freeze Dried Food: ",
            "2. Clothing: ",
            "3. Liquid Oxygen: ",
            "4. Droid Equipment: ",
            "5. Polymer: ",
            "6. Mega Seed: ",
            "7. Kalaxian Crystal: "
            };
            foreach(string s in InventoryArray)
            {
                Console.WriteLine(s);
            }

            }

        }

    }
}
