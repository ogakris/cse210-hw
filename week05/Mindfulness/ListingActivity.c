
using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        public ListingActivity()
            : base("Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        private int _count = 0;

        public void Run()
        {
            DisplayStartingMessage();

            Random random = new Random();

            int index = random.Next(_prompts.Count);

            string prompt = _prompts[index];

            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {prompt} ---");

            Console.WriteLine();
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            _count = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string item = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(item))
                {
                    _count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"You listed {_count} items!");

            DisplayEndingMessage();
        }
    }
}
