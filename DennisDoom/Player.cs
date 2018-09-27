using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DennisDoom
{
    public class Player : AnimatedSprite
    {
        //List<AnimatedSprite
        //Speed
        //List<Projectile>
        //Health
        bool IsAlive = true;
        public Vector2 Speed { get; set; }

        public Player(Vector2 position, Vector2 speed) : base(position)
        {
            //create all animations
        }

        //Update
        //move player with input
        public override void Update(GameTime gameTime)
        {
            //movement stuff

            base.Update(gameTime); //animates the frames
        }


        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch); //draw the player

            //draw projectiles
        }
    }
}
