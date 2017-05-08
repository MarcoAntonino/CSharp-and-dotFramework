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
                                                     //19   //21    //24
       // private static int[] timeRanges = new int[] { 1140, 1320, 1440 };

        private const int DELAY_TIME = 30;
        private const int FIRST_PROJECTION = 1080;
        private const int LAST_PROJECTION = 1470;
        private const int PREFERRED_START = 1140;


        static void Main(string[] args)
        {
            LoadScreeningRooms();
            LoadSchedules();
        }

        private static void LoadScreeningRooms()
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

        private static void LoadSchedules()
        {
            Film powerRangersFilm = new Film();
            powerRangersFilm.Title = "Power Rangers";
            powerRangersFilm.Genre = FilmGenre.Action;
            powerRangersFilm.Duration = 125;
            powerRangersFilm.Is3D = false; //superfluo   

            Film DancesWithWolfesFilm = new Film();
            DancesWithWolfesFilm.Title = "Dances With Wolfes";
            DancesWithWolfesFilm.Genre = FilmGenre.Action;
            DancesWithWolfesFilm.Duration = 236;
            DancesWithWolfesFilm.Is3D = false; //superfluo  

            Schedule PowerRangersSchedule = new Schedule();
            PowerRangersSchedule.Film = powerRangersFilm;
            PowerRangersSchedule.ScreeningRoom = GetScreeningRoombyName("3");
            PowerRangersSchedule.SetHour(timeRanges[timeRanges.Length],0);
            PowerRangersSchedule.NumberOfAvailableSeats = PowerRangersSchedule.ScreeningRoom.NumberOfSeats;


           
            int maxLenght = LAST_PROJECTION - FIRST_PROJECTION;
            if(maxLenght/(DancesWithWolfesFilm.Duration+30)+1>=3)
                if(FIRST_PROJECTION+(DancesWithWolfesFilm.Duration+30)*2<LAST_PROJECTION)
                {

                }

           
        }

        //metodo per ricerca sale per nome e la ritorna per assegnarle ai film
        private static ScreeningRoom GetScreeningRoombyName(string name)
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
