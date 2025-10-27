using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT11_Final_OOP {
    internal class Program {
        static void Main(string[] args)
        {
            Car fit = new Car("Honda", "Fit", 2001, 4);
            Car iq = new Car("Toyta", "Iq", 2016, 3);
            Motorcycle ninja = new Motorcycle("Kawasaki", "Ninga", 2014, false);
            Motorcycle ural = new Motorcycle("Ural", "M72", 1993, true);
            fit.StartEngine();
            fit.GetInfo();
            iq.StartEngine();
            iq.GetInfo();
            ninja.StartEngine();
            ural.GetInfo();
            ninja.Drive();
            iq.Drive();

        }
    }
    public interface IDrivable 
    {
        void Drive();
    }

    abstract public class Vehicle
    {
        protected string brand { get;}
        protected string model { get;}
        protected int year { get; }

        public Vehicle(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public abstract void StartEngine();
        public virtual void GetInfo()
        {
            Console.WriteLine($"brand:{brand}, model:{model}, year:{year}");
        }
    }

    public class Car : Vehicle, IDrivable {
        private int numberOfDoors;
        public Car(string brand, string model, int year,int numberOfDoors) : base (brand, model, year) 
        {
            this.numberOfDoors = numberOfDoors;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Двигатель автомобиля заведён");
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"numberOfDoors: {numberOfDoors}");
        }
        public void Drive()
        {
            Console.WriteLine($"Автомобиль {brand} {model} едет");
        }
    }
    public class Motorcycle : Vehicle, IDrivable {
        private bool hasSidecar;
        public Motorcycle(string brand, string model, int year, bool hasSidecar) : base(brand, model, year)
        {
            this.hasSidecar = hasSidecar;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Двигатель мотоцикла заведён");
        }
        public override void GetInfo()
        {
            base.GetInfo();
            if (hasSidecar) { Console.WriteLine("Коляска присутствует"); }
            else { Console.WriteLine("Коляска отсутствует"); }
        
        }
        public void Drive()
        {
            Console.WriteLine($"Мотоцикл {brand} {model} едет");
        }
    }
}
