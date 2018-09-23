using System;
using System.Collections.Generic;

namespace TicketTestTask
{
    /// <summary>
    /// Класс для сортировки маршрутов поездки.
    /// </summary>
    public class TripRoutesSorter
    {
        private readonly Dictionary<string, string> routesBackward = new Dictionary<string, string>();
        private readonly Dictionary<string, string> routesForward = new Dictionary<string, string>();

        /// <summary>
        /// Получить отсортированные маршрутов поездки.
        /// </summary>
        /// <param name="tripRoutes">Машруты.</param>
        /// <returns>Результат сортировки.</returns>
        public List<string> GetSortedTripRoutes(List<string> tripRoutes)
        {
            if (tripRoutes == null)
                throw new ArgumentNullException(nameof(tripRoutes));

            var tickets = new List<Ticket>();

            foreach (var route in tripRoutes)
            {
                var citesOfRoute = route.Split(new[] { "->" }, StringSplitOptions.None);
                tickets.Add(new Ticket(citesOfRoute[0].Trim(), citesOfRoute[1].Trim()));
            }

            var sortedTickets = GetSortedTickets(tickets);
            var orderedTripRoutes = new List<string>();

            foreach (var ticket in sortedTickets)
            {
                orderedTripRoutes.Add($"{ticket.Departure}->{ticket.Destanation}");
            }

            return orderedTripRoutes;
        }

        private List<Ticket> GetSortedTickets(List<Ticket> tickets)
        {
            var sortedTickets = new List<Ticket>();

            if (tickets.Count > 0)
            {
                foreach (var ticket in tickets)
                {
                    routesForward.Add(ticket.Departure, ticket.Destanation);
                    routesBackward.Add(ticket.Destanation, ticket.Departure);
                }

                sortedTickets.Add(tickets[0]);

                var searchCity = sortedTickets[0].Destanation;
                while (routesForward.ContainsKey(searchCity))
                {
                    sortedTickets.Add(new Ticket(searchCity, routesForward[searchCity]));
                    searchCity = routesForward[searchCity];
                }

                searchCity = sortedTickets[0].Departure;
                while (routesBackward.ContainsKey(searchCity))
                {
                    sortedTickets.Insert(0, new Ticket(routesBackward[searchCity], searchCity));
                    searchCity = routesBackward[searchCity];
                }

                routesForward.Clear();
                routesBackward.Clear();
            }

            return sortedTickets;
        }
    }
}