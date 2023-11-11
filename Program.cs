using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        TrafficLight trafficLight = new TrafficLight();

        // Display initial color
        Console.WriteLine("Initial color: " + trafficLight.GetCurrentColor());

        // Change color and display
        trafficLight.ChangeColor();
        Console.WriteLine("New color: " + trafficLight.GetCurrentColor());

        // Change color again and display
        trafficLight.ChangeColor();
        Console.WriteLine("New color: " + trafficLight.GetCurrentColor());

        // You can continue changing colors as needed

        Console.ReadLine(); // To prevent the console window from closing immediately
    }
}

public enum TrafficLightColor
{
    Red,
    Yellow,
    Green
}

public class TrafficLight
{
    private Queue<TrafficLightColor> _queue;

    public TrafficLight()
    {
        _queue = new Queue<TrafficLightColor>();
        _queue.Enqueue(TrafficLightColor.Red);
        _queue.Enqueue(TrafficLightColor.Yellow);
        _queue.Enqueue(TrafficLightColor.Green);
    }

    public TrafficLightColor GetCurrentColor()
    {
        return _queue.Peek();
    }

    public void ChangeColor()
    {
        TrafficLightColor currentColor = _queue.Dequeue();
        _queue.Enqueue(currentColor);
    }
}
