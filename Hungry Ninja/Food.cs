using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Food : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get; set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        public string GetInfo()
        {
            return $"{ Name } (Food). Calories: { Calories }. Spicy?: { IsSpicy }, Sweet?: { IsSweet}";
        }
        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }

    class Buffet
    {
        public List<IConsumable> Menu;
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Pizza", 285, false, false),
                new Food("Cupcake", 131, false, true),
                new Food("Cheeseburger", 303, false, false),
                new Food("Hot Wings", 420, true, false),
                new Food("Brownie", 132, false, true),
                new Food("Fries", 365, false, false),
                new Food("Sushi", 300, true, false),
                new Food("Ice Cream",125, false, true),
                new Drink("Root Beer", 152, false, true),
                new Drink("Raspberry Iced Tea", 90, false, true),
                new Drink("Chocolate Milkshake", 300, false, true)
            };
        }

        public IConsumable Serve()
        {
            Random randFood = new Random();
            int randInt = randFood.Next(Menu.Count);
            return Menu[randInt];
        }
    }
}