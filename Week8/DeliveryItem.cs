namespace Week8;
using System;

public abstract class DeliveryItem
{
    public string TrackingNumber { get; }
    public double Weight { get; }

    public DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine("Номер: " + TrackingNumber);
        Console.WriteLine("Вага: " + Weight);
    }
}