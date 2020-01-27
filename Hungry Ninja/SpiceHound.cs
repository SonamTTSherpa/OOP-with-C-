using System;

namespace Hungry_Ninja
{
    class SpiceHound : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1200)
                {
                    return true;
                }
                return false;
            }
        }

        public override void Consume(IConsumable item)
        {
            if (IsFull == false)
            {
                if (item.IsSpicy)
                {
                    calorieIntake -= 5;
                }
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                item.GetInfo();
            }
            else
            {
                Console.WriteLine("The SpiceHound is full and can't eat another bite!");
            }
        }
    }
}