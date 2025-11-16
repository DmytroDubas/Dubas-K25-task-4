using System;
using System.Collections.Generic;

namespace GeoObjectsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            River dnipro = new River(30.5234, 50.4501, "Дніпро", "Головна річка України", 120, 2201);
            Mountain hoverla = new Mountain(24.5000, 48.1549, "Говерла", "Найвища гора України", 2061);

            List<GeographicObject> geoObjects = new List<GeographicObject>();
            geoObjects.Add(dnipro);
            geoObjects.Add(hoverla);

            foreach (var geoObject in geoObjects)
            {
                Console.WriteLine(geoObject.GetInfo());
                Console.WriteLine("--------------------");
            }

            Console.ReadKey();
        }
    }
}