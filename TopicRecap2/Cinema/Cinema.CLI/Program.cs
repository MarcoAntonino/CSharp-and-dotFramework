using Cinema.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.CLI
{
    class Program
    {
        private static List<ScreeningRoom> screeningRooms;
        //la console app è 

        private static int[] timeRanges = new int[] { 19, 22, 24 };

        private const int DELAY_TIME = 30;

        static void Main(string[] args)
        {
            loadScreeningRooms();
            loadSchedules();
        }

        private static void loadScreeningRooms()
        {
            screeningRooms = new List<ScreeningRoom>();
            //define room 1 and 2

            ScreeningRoom screeningRoom1 = new ScreeningRoom();
            screeningRoom1.Name = "1";
            screeningRoom1.NumberOfSeats = 150;
            screeningRooms.Add(screeningRoom1);

            ScreeningRoom screeningRoom2 = new ScreeningRoom();
            screeningRoom2.Name = "2";
            screeningRoom2.NumberOfSeats = 365;
            screeningRooms.Add(screeningRoom2);

            ScreeningRoom screeningRoom3 = new ScreeningRoom();
            screeningRoom3.Name = "3";
            screeningRoom3.NumberOfSeats = 289;
            screeningRooms.Add(screeningRoom3);
        }

        private static void loadSchedules()
        {
            Film powerRangersFilm = new Film();
            powerRangersFilm.Title = "Power Rangers";
            powerRangersFilm.Genre = FilmGenre.Action;
            powerRangersFilm.Duration = 125;
            powerRangersFilm.Is3D = false; //superfluo   

            Schedule PowerRangersSchedule = new Schedule();
            PowerRangersSchedule.Film = powerRangersFilm;
            PowerRangersSchedule.ScreeningRoom = getScreeningRoombyName("3");
            PowerRangersSchedule.SetHour(20, 05);
            PowerRangersSchedule.NumberOfAvailableSeats = PowerRangersSchedule.ScreeningRoom.NumberOfSeats;


            int startTime= timeRanges[0];
            for (int i=1; i<timeRanges.Length; i++)
            {
                //trova un metodo...
            }       

           
        }

        //metodo per ricerca sale per nome e la ritorna per assegnarle ai film
        private static ScreeningRoom getScreeningRoombyName(string name)
        {
            return screeningRooms.Find(sr => sr.Name.Equals(name));
            //sr è l'abbreviazione di screeningrooms e l'abbiamo deciso ora
            //la freccia sia può usare quando il metodo è un predicate, semplicemente per
            //comodità

            /*
             * L'alternativa a questo codice (lunga) è:
             * foreach (ScreeningRoom sr in screeningRooms)
             * {
             *  if (sr.Name.Equals(name))
             *  {
             *      return sr;
             *  }
             * }
             * return null; 
             */
        }
    }
}
