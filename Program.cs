using System;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //Membuat objek taxi
        Taxi taxi = new Taxi();

        //Pengaturan Properties
        taxi.DriveName = "Jono";
        taxi.OnDuty = true;
        taxi.NumPassenger = 10;

        //Pemanggilan Method
        taxi.TaxiInfo();
        taxi.PickUpPassenger();
        taxi.DropOffPassenger();

        Console.ReadKey();
        }
    }
}
