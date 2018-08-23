using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DennisDoom
{
    public struct Frame
    {
        public Rectangle Bounds { get; set; }
        public Vector2 Origin { get; set; }

        public Frame(Rectangle bounds) : this(bounds, new Vector2(bounds.Width / 2, bounds.Height / 2)) { }
        public Frame(Rectangle bounds, Vector2 origin)
        {
            Bounds = bounds;
            Origin = origin;
        }
    }
}
