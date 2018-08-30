using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DennisDoom
{
    public class Player : Sprite
    {
        //Speed
        //List<Projectile>
        //Health
        bool IsAlive = true;

        public Player(Texture2D image, Vector2 position)
            : base(image, position)
        {
        }

        public Player(Texture2D image, Vector2 position, Color tint, float rotation, Vector2 scale, Vector2 origin, SpriteEffects effect, float layerDepth)
            : base(image, position, tint, rotation, scale, origin, effect, layerDepth)
        {
        }

        //Update
        //move player with input

    }
}
