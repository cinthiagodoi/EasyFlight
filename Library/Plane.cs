using System.ComponentModel.DataAnnotations;

namespace Library;

public class Plane
{
    private int _seatsPerRowFC;
    private int _seatsPerRowE;
    private int _numberRowsFC;
    private int _numberRowsEC;

    public int Id { get; set; }
    public string? Brand {get; set; }
    public string? Model { get; set; }  
    public int SeatsPerRowFirstClass
    {
        get => _seatsPerRowFC;
        set
        {
            if (value < 0 || value > 6) _seatsPerRowFC = 6;
            else _seatsPerRowFC = value;
        }
    }

    public int SeatsPerRowEconomy 
    { 
        get => _seatsPerRowE;
        set
        {;
            if (value < 0 || value > 9) _seatsPerRowE = 9;
            else _seatsPerRowE= value;
        }
    }
    public int NumberRowsFirstClass {
        get => _numberRowsFC;
        set
        {
            if (value < 0 || value > 10) _numberRowsFC = 10;
            else  _numberRowsFC = value;
        }
    }
    public int NumberRowsEconomy {
        get => _numberRowsEC;
        set
        {
            if (value < 0 || value > 50) _numberRowsEC = 50;
            else _numberRowsEC = value;
        }
    }

    public string? Status { get; set; }

    
    public string PlaneName
    {
        get
        {
            return $"{Id}-{Brand} {Model}";
        }
    }
    public string AviaoData
    {
        get
        {
            return $"{Id} {Brand} {Model} {SeatsPerRowFirstClass} {SeatsPerRowEconomy} {NumberRowsFirstClass}" +
                $"{NumberRowsEconomy} {Status}";
        }
    }

    public override string ToString()
    {
        return $"{Id},{Brand},{Model},{SeatsPerRowFirstClass},{SeatsPerRowEconomy},{NumberRowsFirstClass},{NumberRowsEconomy},{Status}";
    }

   
}