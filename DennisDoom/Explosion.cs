using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DennisDoom
{
    public class Explosion : AnimatedSprite
    {
        public Explosion(Texture2D image, Vector2 position) : base(position)
        {
            AnimationState = AnimationState.Explode;
            AddAnimation(AnimationState, new Animation(image, null, TimeSpan.Zero, 1));

            int size = 9;
            int dy = 0;
            for (int y = 0; y < size; y++)
            {
                int dx = 0;
                for (int x = 0; x < size; x++)
                {
                    Animations[AnimationState].AddFrame(new Frame(new Rectangle(dx, dy, image.Width / size, image.Height / size)));
                    dx += image.Width / size;
                }
                dy += image.Height / size;
            }
        }

    }
}
