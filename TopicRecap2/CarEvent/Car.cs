using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvent
{
    class Car
    {
        public int MaxSpeed { get; set; }
        public int CurrentSpeed { get; set; }
        public string Petname { get; set; }

        private bool carIsDead;

        public event EventHandler<CarEventArgs> Exploded;
        public event EventHandler<CarEventArgs> AboutToBlow;

        public Car(string name, int currSpd, int maxSpd)
        {
            this.Petname = name;
            this.CurrentSpeed = currSpd;
            this.MaxSpeed = maxSpd;
        }

        public void Accelerate (int delta)
        {
            if (carIsDead)
            {
                Exploded?.Invoke(this, new CarEventArgs("Sorry this car is dead..."));
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == (MaxSpeed - CurrentSpeed)) 
                {
                    AboutToBlow?.Invoke(this, new CarEventArgs("Careful buddy! Gonna blow!"));
                }
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }

    }
}
