using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Activity running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Activity cycling = new Cycling(new DateTime(2024, 11, 26), 30, 15.0);
        Activity swimming = new Swimming(new DateTime(2025, 02, 20), 30, 20);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}