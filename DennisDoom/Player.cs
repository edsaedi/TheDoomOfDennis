using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DennisDoom
{
    public class Player : MovingAnimatedSprite
    {
        //List<AnimatedSprite
        //Speed
        //List<Projectile>
        //Health
        public List<AnimatedSprite> Animations { get; set; }
        public List<Projectile> Projectiles { get; set; }
        bool IsAlive = true;
        public int Health;

        public Player(List<AnimatedSprite> animations, List<Projectile> projectiles, Vector2 position, Vector2 velocity, int startingHealth)
            : base(position, velocity)
        {
            //create all animations
            Health = startingHealth;
            Animations = animations;
            Projectiles = projectiles;
        }

        public override void Update(GameTime gameTime)
        {
            Position += Velocity;   //Moves the player

            Rotation = (float)Math.Atan2(Velocity.Y, Velocity.X);   //Rotates the player

            base.Update(gameTime); //animates the frames
        }


        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch); //draw the player

            //draw projectiles
            for (int i = 0; i < Projectiles.Count; i++)
            {
                Projectiles[i].Draw(batch);
            }
        }
    }
}
