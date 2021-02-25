using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeter
{
        public class planet
    {
        

        // propfull tap tap for nedestående
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //nedestående stoppet
        

        private double mass;
        public double Mass
        {
            get { return Mass; }
            set { Mass = value; }
        }


        private double diameter;
        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        

        private double density;
        public double Density
        {
            get { return density; }
            set { density = value; }
        }



        private double gravity;
        public double Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }



        private double rotation;
        public double Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }


        private double daylength;
        public double Daylength
        {
            get { return daylength; }
            set { daylength = value; }
        }


        private double distance_sun;
        public double Distance_sun
        {
            get { return distance_sun; }
            set { distance_sun = value; }
        }



        private double orbital_days;
        public double Orbital_days
        {
            get { return orbital_days; }
            set { orbital_days = value; }
        }




        private double orbital_velocity;
        public double Orbital_velocity
        {
            get { return orbital_velocity; }
            set { orbital_velocity = value; }
        }

        private double mean_temperature;
        public double Mean_temperature
        {
            get { return mean_temperature; }
            set { mean_temperature = value; }
        }



        private int number_of_moons;
        public int Number_of_moons
        {
            get { return number_of_moons; }
            set { number_of_moons = value; }
        }



        private bool ring_system;
        public bool Ring_system
        {
            get { return ring_system; }
            set { ring_system = value; }
        }



        public planet(string name, double mass, double diameter, double density, double gravity, double rotation, double daylength, double distance_sun, double orbital_days, double orbital_velocity, double mean_temperature, int number_of_moons, bool ring_system)
        {

            this.name = name;
            this.mass = mass;
            this.diameter = diameter;
            this.density = density;
            this.gravity = gravity;
            this.rotation = rotation;
            this.daylength = daylength;
            this.distance_sun = distance_sun;
            this.orbital_days = orbital_days;
            this.orbital_velocity = orbital_velocity;
            this.mean_temperature = mean_temperature;
            this.number_of_moons = number_of_moons;
            this.ring_system = ring_system;
        }

 



    }
}
