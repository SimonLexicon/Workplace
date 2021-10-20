using System;
using System.Collections.Generic;
using System.Text;

namespace Workplace.Models.Shape
{
    public abstract class Shape
    {
        public abstract string Type { get; }
        public abstract double Area { get; }
        public abstract string Color { get; }

        public virtual void VirtualTest()
        {
            Console.WriteLine("Im not good at my job. Please dont use me, " +
                "override please.");
        }

        // Cannot have a "body" {}, because of abstract.
        public abstract void AbstractTest();
        //{
        //    Console.WriteLine("Im not good at my job. Please dont use me, " +
        //        "override please.");
        //}
    }
}
