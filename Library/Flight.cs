using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Flight
{
    public int Id { get; set; }

    public string? Number { get; set; }

    public string? Origen { get; set; }

    public string? Destiny { get; set; }

    public string? Date { get; set; }

    public string? Time { get; set; }

    public double FirstClassPrice { get; set; }

    public double EconomyClassPrice { get; set; }
    
    public string? FlightStatus { get; set; }

    public Plane? UsePlane { get; set; }

    public override string ToString()
    {
        return $"{Id},{Number},{Origen},{Destiny},{Date},{Time},{FirstClassPrice},{EconomyClassPrice},{FlightStatus}";
    }
}
