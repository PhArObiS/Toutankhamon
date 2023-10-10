using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toutankhamon
{
    internal class ItemManager
    {
        static Dictionary<string, TreasureItem> ItemBank
            = new Dictionary<string, TreasureItem>();

        internal void AddItem(TreasureItem item)
        {
            // Add an item to the dictionary:
            // Check the type of item
            if (item.Type == TreasureType.Cursed)
            {
                Console.WriteLine(
                    "This item is cursed, and cannot be added!");
                return;
            }

            // Extract the name to make it a key
            string nameKey = item.Name;

            // Add the TreasureItem (with its key)
            ItemBank.Add(nameKey, item);

            // Debug to make sure everything works
            if (ItemBank.ContainsKey(nameKey) == true)
            {
                Console.WriteLine(
                    $"Item '{nameKey}' added successfully!");
            }
        }

        internal void RemoveItem(string name)
        {
            // Remove an item from the dictionary
            // Check if the item is indeed present
            if (ItemBank.ContainsKey(name) == false)
            {
                Console.WriteLine(
                    $"Item '{name}' does not exist!");
                return;
            }

            // Remove the item with its key
            ItemBank.Remove(name);

            // Check if the item is indeed removed
            if (ItemBank.ContainsKey(name) == false)
            {
                Console.WriteLine(
                    $"Item '{name}' removed successfully!");
            }
        }

        internal void SearchAndDisplayTreasure(string name)
        {

            if (ItemBank.ContainsKey(name) == false)
            {
                Console.WriteLine(
                   $"Item '{name}' does not exist!");
                return;
            }

            // Find an item in the dictionary
            TreasureItem foundItem;

            foundItem = ItemBank.GetValueOrDefault(name);

            // Display its information
            Console.WriteLine($"Item name is : {foundItem.Name}");
            Console.WriteLine($"Item value is : {foundItem.Value}");
            Console.WriteLine($"Item weight is : {foundItem.Weight}");
            Console.WriteLine($"Item type is : {foundItem.Type}");
        }

        internal void UpdateTreasure(string name, TreasureItem newItem)
        {
            // Check if an item already exists in the dictionary
            if (ItemBank.ContainsKey(name) == false)
            {
                Console.WriteLine(
                   $"Item '{name}' does not exist!");
                return;
            }

            // Remove old item
            ItemBank.Remove(name);

            // Add new item object
            ItemBank.Add(newItem.Name, newItem);
        }
    }
}