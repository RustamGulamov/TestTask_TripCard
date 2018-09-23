using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicketTestTask.UnitTest
{
    /// <summary>
    /// Тест для класса <see cref="TripRoutesSorter"/>.
    /// </summary>
    [TestClass]
    public class TripRoutesSorter_Tests
    {
        /// <summary>
        /// Тест.
        /// </summary>
        [TestMethod]        
        public void TripRoutesSorting_Test()
        {
            List<string> orderedRoutes = TripRoutesGetter.GetTripRoutes();
            var randomOrderRoutes = TripRoutesGetter.RandomizeOrder(orderedRoutes);

            TripRoutesSorter sorter = new TripRoutesSorter();
            var sortedRoutesResult = sorter.GetSortedTripRoutes(randomOrderRoutes);

            Assert.IsTrue(sortedRoutesResult.SequenceEqual(orderedRoutes));
        }        
    }
}
