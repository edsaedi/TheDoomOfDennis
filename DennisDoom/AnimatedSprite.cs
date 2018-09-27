using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DennisDoom
{
    public class AnimatedSprite : GameObject
    {
        public Dictionary<AnimationState, Animation> Animations = new Dictionary<AnimationState, Animation>();
        public AnimationState AnimationState = AnimationState.None;
        public Rectangle? SourceRectangle { get; set; }
        public Animation CurrentAnimation
        {
            get
            {
                if (Animations.ContainsKey(AnimationState))
                {
                    return Animations[AnimationState];
                }
                return null;
            }
        }

        public AnimatedSprite(Vector2 position)
            : base(position)
        {
        }

        public void AddAnimation(AnimationState state, Animation animation)
        {
            Animations[state] = animation;
        }

        public virtual void Update(GameTime gameTime)
        {
            if (CurrentAnimation != null)
            {
                CurrentAnimation.Animate(gameTime);
            }
        }

        public override void Draw(SpriteBatch batch)
        {
            if (CurrentAnimation != null && !CurrentAnimation.AnimationComplete)
            {
                batch.Draw(CurrentAnimation.Image, Position, CurrentAnimation.CurrentFrame.Bounds, Tint, Rotation, CurrentAnimation.CurrentFrame.Origin, Scale, Effect, LayerDepth);
            }
        }
    }
}
