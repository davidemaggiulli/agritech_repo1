using GeomLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem
{
    internal class Planet 
    {
        //Stato Interno
        //private string name;
        //public string GetName()
        //{
        //    return name;
        //}
        public string Name { get;}
        public float Mass { get; }
        public float Radius { get; }
        public float DistanceFromSun { get; }
        public Point2D Position { get; }

        public static Planet operator+ (Planet p1, Planet p2)
        {
            return new Planet(p1.Name + " - " + p2.Name, new Point2D(p1.Position.GetX() + p2.Position.GetX(), p1.Position.GetY() + p2.Position.GetY()));
        }

        public Planet(string name, float mass, float radius, float dist)
        {
            Name = name;
            Mass = mass;
            Radius = radius;
            DistanceFromSun = dist;
            Position = new Point2D(dist, 0);
        }

        public override string ToString()
        {
            return $"Nome: {Name}, Mass: {Mass}, Radius: {Radius}, Distance: {DistanceFromSun}, Position: {Position}";
        }

        public double GetGravity(Planet p)
        {
            double distance = PointLib.GetDistance(this.Position, p.Position);
            return 6.674E-11 * (this.Mass * p.Mass) / Math.Pow(distance, 2);
        }

        public static double GetGravity(Planet p1, Planet p2)
        {
            double distance = PointLib.GetDistance(p1.Position, p2.Position);
            return 6.674E-11 + (p1.Mass * p2.Mass) / Math.Pow(distance, 2);
        }

    }
}
