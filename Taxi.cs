using System;

namespace taxi
{
    class Taxi
    {
        public string DriveName {get; set;} = default!;
        public bool OnDuty {get;set;} = default!;
        public int NumPassenger {get;set;} = default!;

        public void TaxiInfo()
        {
            string duty;

            if(OnDuty)
            {
                duty = "Yes";
            }else
            {
                duty = "No";
            }

            Console.WriteLine("DriveName : {0}", DriveName);
            Console.WriteLine("OnDuty : {0}", duty);
            Console.WriteLine("Number of Passenger : {0}",NumPassenger);
            Console.WriteLine();
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang",DriveName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang",DriveName);
        }
    }
}