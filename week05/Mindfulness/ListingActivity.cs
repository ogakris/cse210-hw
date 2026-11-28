
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _items;
        private Random _random;

        public ListingActivity()
            : base(
                "Listing Activity",
                "This activity will help you reflect on the good things " +
                "in your life by having you list as many things as you " +
                "can in a certain area.")
        {
            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            _items = new List<string>();
            _random = new Random();
        }

        public override void RunActivity()
        {
            DisplayStartingMessage();

            string prompt = _prompts[_random.Next(_prompts.Count)];

            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine();

            Console.WriteLine("You may begin in...");
            ShowCountdown(5);

            Console.WriteLine();
            Console.WriteLine("Start listing:");

            Stopwatch stopwatch = Stopwatch.StartNew();

            while (stopwatch.Elapsed.TotalSeconds < Duration)
            {
                Console.Write("> ");

                string item = Console.ReadLine();

                if (stopwatch.Elapsed.TotalSeconds >= Duration)
                {
                    break;
                }

                if (!string.IsNullOrWhiteSpace(item))
                {
                    _items.Add(item);
                }
            }

            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine($"You listed {_items.Count} items!");

            DisplayEndingMessage();
        }
    }
}
