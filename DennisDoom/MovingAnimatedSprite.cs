using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace DennisDoom
{
    public class MovingAnimatedSprite : AnimatedSprite
    {
        public Vector2 Velocity { get; set; }
        public float X_Velocity
        {
            get { return Velocity.X; }
            set { Velocity = new Vector2(value, Velocity.Y); }
        }
        public float Y_Velocity
        {
            get { return Velocity.Y; }
            set { Velocity = new Vector2(Velocity.X, value); }
        }

        public MovingAnimatedSprite(Vector2 position, Vector2 velocity)
            : base(position)
        {
            this.Velocity = velocity;
        }
    }
}
