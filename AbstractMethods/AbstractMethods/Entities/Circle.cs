﻿using AbstractMethods.Entities.Enum;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethods.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
        }

        public Circle(Color color, double radius) 
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
