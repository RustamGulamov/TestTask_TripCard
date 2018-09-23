using System;
using System.Collections.Generic;

namespace TicketTestTask.UnitTest
{
    public class TripRoutesGetter
    {
        private static List<string> cities = new List<string>()
        {
            "Sankt Petersburg",
            "Moscow",
            "London",
            "Riga",
            "Praga",
            "Madrid",
            "Tokyo",
            "Sydney",
            "New York",
            "Paris"
        };

        /// <summary>
        /// Получить маршруты поездок.
        /// </summary>
        /// <returns>Маршруты.</returns>
        public static List<string> GetTripRoutes()
        {            
            var resultRoutes = new List<string>();

            for (var i = 0; i < cities.Count - 1; i++)
                resultRoutes.Add(cities[i] + "->" + cities[i + 1]);

            return resultRoutes;
        }

        /// <summary>
        /// Менять случайно порядок маршрутов.
        /// </summary>
        /// <param name="lst">Маршруты.</param>
        /// <returns>Случайный порядок маршрутов.</returns>
        public static List<string> RandomizeOrder(List<string> lst)
        {
            var lstRandomOrder = new List<string>();
            var newlst = new List<string>(lst);
            while (newlst.Count > 0)
            {
                var nextcity = newlst[(new Random()).Next(0, newlst.Count - 1)];
                lstRandomOrder.Add(nextcity);
                newlst.Remove(nextcity);
            }
            return lstRandomOrder;
        }
    }
}
