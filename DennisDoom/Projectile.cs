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
        public Projectile(Vector2 position, Vector2 velocity)
            : base(position, velocity)
        {
            //create all animations for our Projectiles
            //If you decide to have the projectiles specific to characters, have the child class declare the animations
        }

        public override void Update(GameTime gameTime)
        {
            Position += Velocity;   //Moves

            Rotation = (float)Math.Atan2(Velocity.Y, Velocity.X);   //Rotates

            base.Update(gameTime); //Updates the frames for drawing
        }


    }
}
