using System;
using TrackItemAttribute;

namespace TrackItemAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seeding Sample Data for Visual Elements");
            Console.WriteLine("========================================\n");

            // Sample seed for Speed_Vector
            var speedVector = new Speed_Vector
            {
                Visibility = "Visible",
                Fg = EnumColor.Green,
                Bg = EnumColor.Black
            };
            Console.WriteLine("Speed_Vector:");
            Console.WriteLine(speedVector);

            // Sample seed for Leaderline
            var leaderline = new Leaderline
            {
                Fg = EnumColor.Blue,
                Bg = EnumColor.White
            };
            Console.WriteLine("\nLeaderline:");
            Console.WriteLine(leaderline);

            // Sample seed for Position_Symbol
            var positionSymbol = new Position_Symbol
            {
                Visibility = "Hidden",
                Fg = EnumColor.Red,
                Bg = EnumColor.Yellow,
                Shape_Of_Symbol = "Circle",
                Symbol_Action = () => Console.WriteLine("Symbol Action Executed!")
            };
            Console.WriteLine("\nPosition_Symbol:");
            Console.WriteLine(positionSymbol);
            Console.Write("Invoking Symbol_Action: ");
            positionSymbol.Symbol_Action();

            // Sample seed for History_Dots
            var historyDots = new History_Dots
            {
                Visibility = "Visible",
                Fg = EnumColor.White,
                Bg = EnumColor.Black,
                Symbol = "Dot"
            };
            Console.WriteLine("\nHistory_Dots:");
            Console.WriteLine(historyDots);

            Console.WriteLine("\nSample data seeding completed. Press any key to exit...");
            Console.ReadKey();
        }

    }
}
