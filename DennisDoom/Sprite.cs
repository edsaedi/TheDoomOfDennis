using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DennisDoom
{
    public class Sprite : GameObject
    {
        public Texture2D Image { get; set; }

        public Vector2 CenterOrigin
        {
            get
            {
                return new Vector2(Image.Width / 2, Image.Height / 2);
            }
        }

        public Sprite(Texture2D image, Vector2 position) : base(position)
        {
            Image = image;
            Origin = CenterOrigin;
        }

        public Sprite(Texture2D image, Vector2 position, Color tint, float rotation, Vector2 scale, Vector2 origin, SpriteEffects effect, float layerDepth)
            : base(position, tint, rotation, scale, origin, effect, layerDepth)
        {
            Image = image;
        }

        public override void Draw(SpriteBatch batch)
        {
            batch.Draw(Image, Position, null, Tint, Rotation, Scale, Origin, Effect, LayerDepth);
        }
    }
}
