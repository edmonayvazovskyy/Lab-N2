using System;

namespace Laboratorka2
{
    class Address

    {

        public string index; // индекс

        public string country;     // Страна

        public string city;     // город

        public string street;     // улица

        public int house;     //номер улицы

        public int apartment;     // квартира

        public void GetInfo()

        {

            Console.WriteLine($"index: {index} \ncountry: {country} \ncity: {city} \nstreet: {street} \nhouse: {house} \napartment: {apartment}");

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Address home = new Address();

            home.index = "02059";

            home.country = "Ukraine";

            home.city = "Kiev";

            home.street = "Bdjilki";

            home.house = 2;

            home.apartment = 526;

            home.GetInfo();  

            Console.ReadKey();

        }

    }
}
