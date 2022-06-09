using System;
using CabInvoiceProblem;

public class Program
{
    public static void Main(String[]args)
    {
        Console.WriteLine("welcome to the program");
        bool check = true;
        while (check)
        {
            Console.WriteLine("1.Display Fair Of Cab\n2.Display Fair Cab Of Multiple Rides\n3.Display invoice summery");
            Console.WriteLine("Enter the Above Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CabInvoiceGenerator generator = new CabInvoiceGenerator(RideType.NORMAL);
                    double result = generator.calculateFair(15, 5);
                    Console.WriteLine("fair of cab" + result);
                    break;
               
                case 2:
                    CabInvoiceGenerator invoice = new CabInvoiceGenerator(RideType.PREMIER);
                    Ride[] rides = { new Ride(15, 5), new Ride(25, 10), new Ride(20, 20) };
                    double result1 = invoice.CalculateMultipleRide(rides);
                    Console.WriteLine("fair of cab multiple rides" + result1);
                    break;
                case 3:
                    CabInvoiceGenerator cabInvoice = new CabInvoiceGenerator(RideType.NORMAL);
                    Ride[] rides1 = { new Ride(15, 10), new Ride(35, 35), new Ride(25, 15), new Ride(15, 15), new Ride(50, 60) };
                    InvoiceSummery results = cabInvoice.CalculateMultipleRideSummery(rides1);
                    Console.WriteLine("total Number of Rides:->" + results.totalNumberOfRides + "\n" + "Total Fare of Cab:-> " + results.totalFair + "\n" + "Average Fare Of Cab :-> " + results.averageFair);
                    break;
                default: Console.WriteLine("enter correct option"); 
                    break;
            }
        }
    }
}