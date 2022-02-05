using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars_Tasks
{
    public class Interval
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Interval(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


        public override string ToString()
        {
            return $"{this.X} | {this.Y}";
        }
    }
}
