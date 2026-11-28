
using System;
using System.Threading;

namespace MindfulnessApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
            : base(
                "Breathing Activity",
                "This activity will help you relax by walking you through " +
                "breathing in and out slowly. Clear your mind and focus " +
                "on your breathing.")
        {
        }

        public override void RunActivity()
        {
            DisplayStartingMessage();

            DateTime startTime = DateTime.Now;

            while ((DateTime.Now - startTime).TotalSeconds < Duration)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(4);

                if ((DateTime.Now - startTime).TotalSeconds >= Duration)
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Breathe out...");
                ShowCountdown(4);

                Console.WriteLine();
            }

            DisplayEndingMessage();
        }
    }
}
