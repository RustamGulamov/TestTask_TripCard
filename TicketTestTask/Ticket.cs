using System;

namespace TicketTestTask
{
    /// <summary>
    /// Билет.
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Конструктор <see cref="TripCard"/>.
        /// </summary>
        /// <param name="departure">Пункт отправления.</param>
        /// <param name="destanation">Пункт назначения.</param>
        public Ticket(string departure, string destanation)
        {
            if (departure.IsEmptyOrWhiteSpace())
                throw new ArgumentException("Пункт отправления не может быть пустым.");

            if (destanation.IsEmptyOrWhiteSpace())
                throw new ArgumentException("Пункт назначения не может быть пустым.");

            Departure = departure ?? throw new ArgumentNullException(nameof(departure));
            Destanation = destanation ?? throw new ArgumentNullException(nameof(destanation));
        }

        /// <summary>
        /// Пункт отправления.
        /// </summary>
        public string Departure { get; }

        /// <summary>
        /// Пункт назначения.
        /// </summary>
        public string Destanation { get; }
    }
}