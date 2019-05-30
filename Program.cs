using System;

namespace ClassCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car FF1 = new Car("Ford", "Ford Focus", 2016 );
            FF1.CarName("Maly");
            FF1.CarColor("Red");

            Car FT2= new Car("Ford","Ford Toyota", 2019);
            FT2.CarName("Clayton");
            FT2.CarColor("Black");
        }
    }

    public class Car
    {
        public string _name { set; get; }
        public string _model { set; get; }
        public int _year { set; get; }

        public Car(string name, string model, int year)
        {
            _name = name; 
            _model = model;
            _year = year;

            Console.WriteLine("Car have been created!");
            Console.WriteLine("The Car name is {0}!", name);
            Console.WriteLine("{0} Model is a : {1}", name, model);
            Console.WriteLine("The {0} was born on this year, year {1}, {2} was happy to make money from the buyer.",model, year,name);
        }

        public void CarName(string pCar)
        {
            Console.WriteLine("Who bought the car from Ford?: {0}", pCar); 
        }

        public void CarColor(string cCar)
        {
            Console.WriteLine("{0} is the color of the car.", cCar);
        }
    }
}