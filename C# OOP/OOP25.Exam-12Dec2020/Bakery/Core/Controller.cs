using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Bakery.Core.Contracts;
using Bakery.Models.BakedFoods;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables;
using Bakery.Models.Tables.Contracts;

namespace Bakery.Core
{
    public class Controller : IController
    {
        // field
        private List<IBakedFood> bakedFoods;
        private List<IDrink> drinks;
        private List<ITable> tables;
        private decimal totalIncome;

        // constructor
        public Controller()
        {
            bakedFoods = new List<IBakedFood>();
            drinks = new List<IDrink>();
            tables = new List<ITable>();
        }

        // method
        public string AddFood(string type, string name, decimal price)
        {

            if (type == nameof(Bread))
            {
                bakedFoods.Add(new Bread(name, price));
            }

            if (type == nameof(Cake))
            {
                bakedFoods.Add(new Cake(name, price));
            }

            return $"Added {name} ({type}) to the menu";
        }

        public string AddDrink(string type, string name, int portion, string brand)
        {

            if (type == nameof(Tea))
            {
                drinks.Add(new Tea(name, portion, brand));
            }

            if (type == nameof(Water))
            {
                drinks.Add(new Water(name, portion, brand));
            }

            return $"Added {name} ({brand}) to the drink menu";
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {

            if (type == nameof(OutsideTable))
            {
                tables.Add(new OutsideTable(tableNumber, capacity));
            }

            if (type == nameof(InsideTable))
            {
                tables.Add(new InsideTable(tableNumber, capacity));
            }

            return $"Added table number {tableNumber} in the bakery";
        }

        public string ReserveTable(int numberOfPeople)
        {
            var table = tables.FirstOrDefault(table => table.IsReserved == false && table.Capacity >= numberOfPeople);

            if (table == null)
            {
                return $"No available table for {numberOfPeople} people";
            }

            else
            {
                table.Reserve(numberOfPeople);
                return $"Table {table.TableNumber} has been reserved for {numberOfPeople} people";
            }

        }

        public string OrderFood(int tableNumber, string foodName)
        {
            var table = tables.FirstOrDefault(table => table.TableNumber == tableNumber);
            var food = bakedFoods.FirstOrDefault(food => food.Name == foodName);

            if (table == null)
            {
                return $"Could not find table {tableNumber}";
            }

            if (food == null)
            {
                return $"No {foodName} in the menu";
            }

            else
            {
                table.OrderFood(food);
                return $"Table {tableNumber} ordered {foodName}";
            }
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            var table = tables.FirstOrDefault(table => table.TableNumber == tableNumber);
            var drink = drinks.FirstOrDefault(drink => drink.Name == drinkName && drink.Brand == drinkBrand);

            if (table == null)
            {
                return $"Could not find table {tableNumber}";
            }

            if (drink == null)
            {
                return $"There is no {drinkName} {drinkBrand} available";
            }

            else
            {
                table.OrderDrink(drink);
                return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
            }
        }

        public string LeaveTable(int tableNumber)
        {
            var table = tables.FirstOrDefault(table => table.TableNumber == tableNumber);

            var text = new StringBuilder();
            var bill = table.GetBill();
            text.AppendLine($"Table: {tableNumber}");
            text.AppendLine($"Bill: {bill:f2}");

            totalIncome += bill;
            table.Clear();
            return text.ToString().TrimEnd();
        }

        public string GetFreeTablesInfo()
        {
            var freeTable = tables.Where(table => table.IsReserved == false).ToList();
            var result = new StringBuilder();

            foreach (var table in freeTable)
            {
                result.AppendLine(table.GetFreeTableInfo());
            }

            return result.ToString().TrimEnd();
        }

        public string GetTotalIncome()
        {
            var income = totalIncome;

            return $"Total income: {income:f2}lv";
        }
    }
}