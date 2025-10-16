using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5 {
    internal class Program {
        static void Main(string[] args)
        {
        }
    }

    public class Movie
    {
        public string Name { get; set; };
        public string Duration { get; set; };
        public static List<Movie> Movies { get; set; } = new List<Movie>();
    }
    public class Seat
    {
        public int Number { get; set; }
        public bool IsReserve { get; private set; }

        public void Reserve()
        {
            if (!IsOccupied)
            {
                IsReserve = true;
                Console.WriteLine($"Место {Number} забранировано")
            }
            else 
            { 
                Console.WriteLine($"Место {Number} занято, выберите другое место"
            }

        }


    }
    public class BookingService
    {
        public List<Movie> GetSeat()
        {
           return List<Movie>
        }
    }
    public class CinemaHall
    {

    }



}
