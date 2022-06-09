using System;
using CabInvoiceProblem;

public class Program
{
    public static void Main(String[]args)
    {
        CabInvoiceGenerator problem = new CabInvoiceGenerator(RideType.NORMAL);
        double Result = problem.calculateFair(15, 5);
        Console.WriteLine(Result);
    }
}