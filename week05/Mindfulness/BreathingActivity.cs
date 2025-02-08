using System;
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int remainingTime = _duration;
        while (remainingTime > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            remainingTime -= 3;

            if (remainingTime <= 0) break;

            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            remainingTime -= 3;
        }

        DisplayEndingMessage();
    }
}