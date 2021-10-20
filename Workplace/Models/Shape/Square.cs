using System;
using System.Collections.Generic;
using System.Text;

namespace Workplace.Models.Shape
{
    public class Square : Shape
    {
        public Square(string color, double side)
        {
            this.color = color;
            this.side = side;
        }
        public double side;
        public string color;
        public override double Area
        {
            get { return Math.Pow(side, 2); }
        }
        public override string Color { get { return color; } }
        public override string Type { get { return "I am a Square"; } }

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
