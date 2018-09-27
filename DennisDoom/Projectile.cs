using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace DennisDoom
{
    public class Projectile : MovingAnimatedSprite
    {


        //Speed
        public Projectile(Vector2 position, Vector2 velocity)
            : base(position, velocity)
        {
        }


        //update
        //move and rotate

        public override void Update(GameTime gameTime)
        {
            Position += Velocity;

            Rotation = (float)Math.Atan2(Velocity.Y, Velocity.X);

            base.Update(gameTime); //updates the frames for drawing
        }
    }
}
