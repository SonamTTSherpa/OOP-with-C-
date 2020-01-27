using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
             Buffet yummy = new Buffet();
             SweetTooth dylan = new SweetTooth();
             SpiceHound dude = new SpiceHound();
             while (!dylan.IsFull)
             {
                 dylan.Consume(yummy.Serve());
             }
             while (!dude.IsFull)
             {
                 dude.Consume(yummy.Serve());
             }
             if (dylan.ConsumptionHistory.Count > dude.ConsumptionHistory.Count)
             {
                 Console.WriteLine($"SweetTooth had the most items consumed with {dylan.ConsumptionHistory.Count} items!");
             }
             else
             {
                 Console.WriteLine($"SpiceHound had the most items consumed with {dude.ConsumptionHistory.Count} items!");
             }
        }
    }
}
