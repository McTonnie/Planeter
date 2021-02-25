using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeter
{
    class Program
    {
        static void Main(string[] args)
        {
            planet merkur = new planet("Merkur",0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, false);

            planet venus = new planet("Venus", 4.87,12104,5243,8.9,-5832.5,2802.0,108.2,224.7,35.0,464,0,false);

            planet jorden = new planet("Jorden",5.97,12756,5514,9.8,23.9,24.0,149.6,365.2,29.8,15,1,false);

            planet mars = new planet("Mars",0.642,6792,3933,3.7,24.6,24.7,227.9,687.0,24.1,-65,2,false);

            planet jupiter = new planet("Jupitor", 1898,142984,1326,23.1,9.9,9.9,778.6,4331,13.1,-110,67,true);

            planet saturn = new planet("Saturn", 568,120536,687,9.0,10.7,10.7,1433.5,10747,9.7,-140,62,true);

            planet uranus = new planet("Uranus", 86.8,51118,1271,8.7,-17.2,17.2,2872.5,30589,6.8,-195,27,true);

            planet neptun = new planet("Neptun", 102,49528,1638,11.0,16.1,16.1,4495.1,59.8,5.4,-200,14,true);

            planet pluto = new planet("Pluto", 0.0146,2370,2095,0.7,-153.3,153.3,5906.4,90.56,4.7,-225,5,false);

            // eksempel på hvordan man ændre herfra pluto.Name = "Mickey";
            
            List<planet> planets = new List<planet>() { merkur, jorden, mars, jupiter, saturn, uranus, neptun, pluto };

            foreach (planet planet in planets)
            {
                Console.WriteLine(planet.Name);
            }


            planets.Insert(1, venus);

            Console.WriteLine();
            Console.WriteLine("Efter venus insat");
            Console.WriteLine();


            foreach (planet planet in planets)
            {
                Console.WriteLine(planet.Name);
            }

            planets.RemoveAt(8);

            Console.WriteLine();
            Console.WriteLine("Efter Pluto fjernet");
            Console.WriteLine();

            foreach (planet planet in planets)
            {
                Console.WriteLine(planet.Name);
            }

            planets.Add(pluto);

            Console.WriteLine();
            Console.WriteLine("Efter Pluto insat igen   ");
            Console.WriteLine();

            foreach (planet planet in planets)
            {
                Console.WriteLine(planet.Name);
            }


            Console.WriteLine();
            Console.WriteLine("der er nu " + planets.Count() + " planeter");

            List<planet> planets_0 = new List<planet>();

            foreach (planet planet in planets)
            {
                if (planet.Mean_temperature < 0)
                {
                    planets_0.Add(planet);
                }
            }

            Console.WriteLine();
            Console.WriteLine("planeter med mean temperatur under 0");
            Console.WriteLine();

            foreach (planet planet in planets_0)
            {
                Console.WriteLine(planet.Name);
            }




            List<planet> planets_diameter = new List<planet>();

            foreach (planet planet in planets)
            {
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                {
                    planets_diameter.Add(planet);
                }
            }

            Console.WriteLine();
            Console.WriteLine("planeter med Diameter over 10000 og under 50000");
            Console.WriteLine();

            foreach (planet planet in planets_diameter)
            {
                Console.WriteLine(planet.Name);
            }

            planets.Clear();

            Console.WriteLine();
            Console.WriteLine("efter alle planeter skille være fjernet");
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine("der er nu " + planets.Count() + " planeter i listen planets");

            Console.ReadKey();
        }





           
    }
}
