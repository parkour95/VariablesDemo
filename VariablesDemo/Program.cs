using System;

namespace VariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Ronaldo";

            int dogAge = 3;

            char initial = 'R';

            bool knowsTricks = true;

            double height = 2.5;

            decimal weight = 35.6m;

            Console.WriteLine($"My dog's name is {dogName}. He is {dogAge}. It's {knowsTricks} that he knows tricks. ");
            Console.WriteLine($"He is {height} feet tall, and weighs {weight} pounds. We call {dogName}, {initial} for short.");
        }
    }
}
