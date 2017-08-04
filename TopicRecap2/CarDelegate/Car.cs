using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Car
    {
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; }
        public string Petname { get; set; }


        private bool carIsDead;

        public Car()
        {

        }

        public Car(string name, int currSp)
        {
            this.CurrentSpeed = currSp;
            Petname = name; // a questo punto mi chiedo: quando si deve usare il this? 
        }

        public delegate void CarEngineHandler(string msgForCaller);

        private CarEngineHandler listOfHandlers;


        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            this.listOfHandlers += methodToCall; //la variabile del delegato. Direi che serve per creare un'istanza del delegato. In poche parole è un setter. Il libro dice che assegna un metodo (uno solo?)
            //il +=permette di aggiungere più metodi
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (listOfHandlers != null) //controlla sempre che non sia nulla. Infatti  nella classe car, sta al metodo helper RegisterWithCarEngine() settare un metodo.
                {
                    listOfHandlers("Sorry, this car is dead..."); // qui gli dico la stringa da passare al metodo. Ma Non abbiamo ancora un metodo
                    //Infatti ecco perchè non capivo dove gli dicesse di stampare questo messaggio. Glielo dice nel programma dove viene scritto il metodo onCarEngineEvent. RIBADISCO: qui viene passata solo una stringa, quello che ci faremo con questa stringa, dipende dal metodo che verrà passato al "setter" RegisterWithCarEngine.
                    //Perchè non è stato scritto qui il metodo onCarEngineEvent? Per fornire maggiore scalabilità. Nel senso che nella classe car noi predisponiamo che succeda qualcosa in determinate fasi (eventi); Nel metodo program, l'utente farà quello che vuole e in questo caso ha implementato il metodo onCarEngineEvent
                }
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy! gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine("CurretSpeed = {0}", CurrentSpeed);
                }
            }
        }
    }
}
