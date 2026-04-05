using System;
class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity b = new BreathingActivity();
                    b.Run();
                    break;

                case 2:
                    ReflectionActivity r = new ReflectionActivity();
                    r.Run();
                    break;

                case 3:
                    ListingActivity l = new ListingActivity();
                    l.Run();
                    break;
            }
        }
    }
}