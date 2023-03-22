using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class SaveFiles
{
    public void SavePlanesList(List<Plane> planes)
    {
        string file = @"avioes.txt";
        using (TextWriter tw = new StreamWriter(file))
        {
            foreach(var item in planes)
            {
                tw.WriteLine(item.ToString());
            }tw.Close();
        }
    }

    public void SaveFligthsList(List<Flight>Flights, List<Plane> Planes)
    {
        string file = @"voos.txt";

        using (TextWriter tw = new StreamWriter(file))
        {
            foreach (var voo in Flights)
            {
                string[] aviaoId = voo.UsePlane.ToString().Split(",");
                string id = aviaoId[0];
          
                tw.WriteLine(voo.ToString() + "," + id);
            }
            tw.Close();
        }
    }

    public void SaveTicketsList(List<Ticket>Tickets, List<Flight> Flights)
    {
        string file = @"tickets.txt";
        using(TextWriter tw = new StreamWriter(file))
        {
            foreach(var ticket in Tickets)
            {
                string[]flightId = ticket.FlightBought!.ToString().Split(",");
                string id = flightId[0];

                tw.WriteLine(ticket.ToString() + "," + id);
            }tw.Close();
        }
    }

}