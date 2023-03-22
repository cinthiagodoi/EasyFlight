using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Library;

public class LoadFiles
{
    /// <summary>
    /// Load the planes files list
    /// </summary>
    /// <returns></returns>
    public List<Plane> LoadPlanesList()
    {
        List<Plane> Planes = new List<Plane>();
        string fileName = @"avioes.txt";

        StreamReader sr;
        Plane addPlane;

        if (File.Exists(fileName))
        {
            sr = File.OpenText(fileName);

            string line = "";

            while ((line = sr.ReadLine()!) != null)
            {
                string[] items = new string[8];

                items = line.Split(",");

                addPlane = new Plane
                {
                    Id = Convert.ToInt32(items[0]),
                    Brand = items[1],
                    Model = items[2],
                    SeatsPerRowFirstClass = Convert.ToInt32(items[3]),
                    SeatsPerRowEconomy = Convert.ToInt32(items[4]),
                    NumberRowsFirstClass = Convert.ToInt32(items[5]),
                    NumberRowsEconomy = Convert.ToInt32(items[6]),
                    Status = items[7],
                };
                Planes.Add(addPlane);
            }
            sr.Close();
        }
        return Planes;
    }

    /// <summary>
    /// Load aiports file
    /// </summary>
    /// <returns></returns>
    public List<Airport> LoadAiportList()
    {
        List<Airport> Airports = new List<Airport>();
        string fileName = @"aeroportos.txt";

        StreamReader sr;
        Airport addAirport;

        if (File.Exists(fileName))
        {
            sr = File.OpenText(fileName);

            string line = "";

            while ((line = sr.ReadLine()!) != null)
            {
                string[] items = new string[3];

                items = line.Split(",");

                addAirport = new Airport
                {
                    name = items[0],
                    iata_code = items[1],
                    country_code = items[2],
                };
                Airports.Add(addAirport);
            }
            sr.Close();
        }
        return Airports;
    }

    /// <summary>
    /// load flight file
    /// </summary>
    /// <param name="Avioes"></param>
    /// <returns></returns>
    public List<Flight> LoadFlightlList(List<Plane>Avioes)
    {
        List<Flight> Flights = new List<Flight>();
        string fileName = @"voos.txt";

        StreamReader sr;
        Flight addFlight;

        if (File.Exists(fileName))
        {
            sr = File.OpenText(fileName);

            string line = "";

            while ((line = sr.ReadLine()!) != null)
            {
                string[] items = new string[9];

                items = line.Split(",");

                addFlight = new Flight
                {
                    Id = Convert.ToInt32(items[0]),
                    Number = items[1],
                    Origen = items[2],
                    Destiny = items[3],
                    Date = items[4],
                    Time = items[5],
                    FirstClassPrice = Convert.ToDouble(items[6]),
                    EconomyClassPrice = Convert.ToDouble(items[7]),
                    FlightStatus = ReturnFlightStatus(items[4], items[8]),
                    UsePlane = ReturnPlaneById(Convert.ToInt32(items[9]), Avioes)
                };
                Flights.Add(addFlight);
            }
            sr.Close();
        }
        return Flights;
    }

    /// <summary>
    /// check if the flight date is in the past and change the state
    /// </summary>
    /// <param name="flightDay"></param>
    /// <param name="status"></param>
    /// <returns></returns>
    private string ReturnFlightStatus(string flightDay, string status)
    {
        if (status == "Confirmado")
        {
            if (DateTime.Parse(flightDay).Date.CompareTo(DateTime.Now.Date) > 0) return "Confirmado";
            else return "Realizado";
        }
        else return status;
    
       
    }
    /// <summary>
    /// return the plane Id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="Planes"></param>
    /// <returns></returns>
    private Plane ReturnPlaneById(int id, List<Plane>Planes)
    {
        Plane flightPlane = Planes.Where(flight => flight.Id == id).FirstOrDefault()!;
        return flightPlane;
    }

    /// <summary>
    /// load the ticket file
    /// </summary>
    /// <param name="Flights"></param>
    /// <returns></returns>
    public List<Ticket> LoadTicketList(List<Flight> Flights) 
    {
        List<Ticket> Tickets = new List<Ticket>();
        string fileName = @"tickets.txt";

        StreamReader sr;
        Ticket addTicket;

        if (File.Exists(fileName))
        {
            sr = File.OpenText(fileName);

            string line = "";

            while ((line = sr.ReadLine()!) != null)
            {
                string[] items = new string[10];

                items = line.Split(",");

                addTicket = new Ticket
                {
                    Id = Convert.ToInt32(items[0]),
                    Name = items[1],
                    Email = items[2],
                    Seat = items[3],
                    PaymentMethod = items[4],
                    SelectedClass = items[5],
                    PhoneNumber = Convert.ToInt32(items[6]),
                    Nif = Convert.ToInt32(items[7]),
                    TicketStatus = items[8],
                    FlightBought = ReturnFlightById(Convert.ToInt32(items[9]), Flights)
                };
                Tickets.Add(addTicket);
            }
            sr.Close();
        }
      

        return Tickets;
    }

    /// <summary>
    /// return flight id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="Fligths"></param>
    /// <returns></returns>
    private Flight ReturnFlightById(int id, List<Flight> Fligths)
    {
        Flight flightTicket = Fligths.Where(flight => flight.Id == id).FirstOrDefault()!;
        return flightTicket;
    }

}       




