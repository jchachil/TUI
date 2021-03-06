﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.DAL;

namespace TUIBackEnd.Test.Helper
{
    public static class Populate
    {
        /// <summary>
        /// Populate some flighs in database
        /// </summary>
        /// <param name="dbContext"></param>
        /// <returns></returns>
        public static List<Flight> PopulateFlights(this TUIEntities dbContext)
        {

            List<Flight> flights = dbContext.Flights.ToList();
            flights.Add(new Flight { DepartureAirportId = 1, DestinationAirportId = 20, FlightDistance = 1000, AirCratfFuelComsumpDistance = 1200, FlightTime = 1, TakeOffEffort = 100, FuelNeeded = 200 });
            flights.Add(new Flight { DepartureAirportId = 4, DestinationAirportId = 8, FlightDistance = 1500, AirCratfFuelComsumpDistance = 1000, FlightTime = 1, TakeOffEffort = 110, FuelNeeded = 250 });
            flights.Add(new Flight { DepartureAirportId = 1, DestinationAirportId = 6, FlightDistance = 1200, AirCratfFuelComsumpDistance = 1300, FlightTime = 1, TakeOffEffort = 120, FuelNeeded = 220 });
            flights.Add(new Flight { DepartureAirportId = 4, DestinationAirportId = 11, FlightDistance = 900, AirCratfFuelComsumpDistance = 1400, FlightTime = 1, TakeOffEffort = 90, FuelNeeded = 210 });

            dbContext.Flights.AddRange(flights);
            dbContext.SaveChanges();

            return flights;
        }

        /// <summary>
        /// Remove test data from database
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="listeFlight"></param>
        public static void DumpFlight(this TUIEntities dbContext, List<Flight> listeFlight)
        {
            List<Flight> listToDelete = new List<Flight>();

            listeFlight.ForEach(l =>
            {
                Flight fl = dbContext.Flights.FirstOrDefault(elt => elt.Id == l.Id);

                if (fl != null)
                {
                    listToDelete.Add(fl);
                }
            });

            dbContext.Flights.RemoveRange(listToDelete);
            dbContext.SaveChanges();
        }

        /// <summary>
        /// Remove All Flights from DB
        /// </summary>
        /// <param name="dbContext"></param>
        public static void RemoveAllFlights(this TUIEntities dbContext)
        {
            List<Flight> listToDelete = new List<Flight>();

            listToDelete = dbContext.Flights.ToList();

            dbContext.Flights.RemoveRange(listToDelete);
            dbContext.SaveChanges();
        }
    }
}
