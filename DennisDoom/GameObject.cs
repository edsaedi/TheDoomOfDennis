using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DennisDoom
{
    public abstract class GameObject
    {
        public Vector2 Position { get; set; }
        public Vector2 Scale { get; set; }
        public float Rotation { get; set; }
        public Color Tint { get; set; }
        public Vector2 Origin { get; set; }
        public SpriteEffects Effect { get; set; }
        public float LayerDepth { get; set; }

        public GameObject(Vector2 position) : this(position, Color.White, 0, Vector2.One, Vector2.Zero, SpriteEffects.None, 0) { }
        public GameObject(Vector2 position, Color tint, float rotation, Vector2 scale, Vector2 origin, SpriteEffects effect, float layerDepth)
        {
            Position = position;
            Tint = tint;
            Rotation = rotation;
            Scale = scale;
            Origin = origin;
            Effect = effect;
            LayerDepth = layerDepth;
        }

        public abstract void Draw(SpriteBatch batch);
    }
}
