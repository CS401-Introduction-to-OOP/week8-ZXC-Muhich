namespace Week8;
using System;

class Program
{
    static void Main()
    {
        Letter letter1 = new Letter("322", 0.5);
        Parcel parcel1 = new Parcel("67", 15.5, "40x25x60");

        letter1.PrintInfo();
        parcel1.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();

        myCargo.AddItem(letter1);
        myCargo.AddItem(parcel1);

        Console.WriteLine("Повна вартість: " + myCargo.GetTotalCost() + "грн.");
    }
}