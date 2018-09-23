using System;
using System.Collections.Generic;

namespace TicketTestTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //List<string> routes = new List<string>()
            //{
            //    "Moscow->London",
            //    "Riga->Praga",
            //    "Praga->Madrid",
            //    "London->Riga",
            //    "Sankt Petersburg->Moscow"
            //};

            List<string> routes = new List<string>(args);
            TripRoutesSorter sorter = new TripRoutesSorter();            
            var sortedTripRoutes = sorter.GetSortedTripRoutes(routes);

            sortedTripRoutes.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}