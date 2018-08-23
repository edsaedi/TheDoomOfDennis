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
            List<Frame> frames = new List<Frame>();

            int size = 9;

            int dy = 0;
            for (int y = 0; y < size; y++)
            {
                int dx = 0;
                for (int x = 0; x < size; x++)
                {
                    frames.Add(new Frame(new Rectangle(dx, dy, image.Width / size, image.Height / size)));
                    dx += image.Width / size;
                }
                dy += image.Height / size;
            }


            Animations.Add(AnimationState.Explode, new Animation(image, frames, TimeSpan.Zero, 1));
            AnimationState = AnimationState.Explode;
        }

    }
}
