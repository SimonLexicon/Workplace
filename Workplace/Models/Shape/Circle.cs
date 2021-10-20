using System;
using System.Collections.Generic;
using System.Text;

namespace Workplace.Models.Shape
{
    public class Circle : Shape
    {
        public Circle(string color, double radius)
        {
            this.color = color;
            this.radius = radius;
        }
        public double radius;
        public string color;

        public override double Area
        {
            get { return Math.Round(Math.PI * Math.Pow(radius, 2), 2); }
        }
        public override string Color { get { return color; } }
        public double Diameter { get { return radius * 2; } }
        public override string Type { get { return "I am a Circle"; } }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        //public override string ToString()
        //{
        //    return base.ToString();
        //}

        // From parent class Shape
        public override void VirtualTest()
        {
            base.VirtualTest();
        }

        // From parent class Shape
        public override void AbstractTest()
        {
            throw new NotImplementedException();
        }
    }
}
