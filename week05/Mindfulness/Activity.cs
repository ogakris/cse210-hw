
using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        protected Activity(string name, string description)
        {
            _name = name;
            _description = description;
            _duration = 0;
        }

        protected int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        protected void DisplayStartingMessage()
        {
            Console.Clear();

            Console.WriteLine($"Welcome to the {_name}.");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();

            Console.Write("How long, in seconds, would you like for your session? ");

            int duration;

            while (!int.TryParse(Console.ReadLine(), out duration)
                   || duration <= 0)
            {
                Console.Write("Please enter a positive number of seconds: ");
            }

            _duration = duration;

            Console.Clear();

            Console.WriteLine("Get ready...");
            ShowSpinner(3);

            Console.WriteLine();
        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            ShowSpinner(2);

            Console.WriteLine();
            Console.WriteLine($"You have completed the {_name}.");
            Console.WriteLine($"You spent {_duration} seconds on this activity.");

            ShowSpinner(3);
        }

        protected void ShowSpinner(int seconds)
        {
            char[] spinner = { '|', '/', '-', '\\' };

            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            int index = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write(spinner[index % spinner.Length]);
                Thread.Sleep(250);
                Console.Write("\b");

                index++;
            }
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public abstract void RunActivity();
    }
}
