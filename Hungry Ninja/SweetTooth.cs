using System;

namespace Hungry_Ninja
{
    class SweetTooth : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1500)
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
                if (item.IsSweet)
                {
                    calorieIntake += 10;
                }
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                item.GetInfo();
            }
            else
            {
                Console.WriteLine("SweetTooth is full and can't eat another bite!");
            }
        }
    }
}