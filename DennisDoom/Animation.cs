using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DennisDoom
{
    public class Animation
    {
        public Texture2D Image { get; set; }
        public List<Frame> Frames = new List<Frame>();
        public Frame CurrentFrame { get; set; }
        public uint LoopCount { get; set; }
        public uint LoopCap { get; set; }
        public TimeSpan FrameRate;
        private int currentFrameIndex { get; set; }
        private TimeSpan timer = TimeSpan.Zero;

        public bool AnimationComplete => LoopCount == LoopCap;

        public Animation(Texture2D image, List<Frame> frames, TimeSpan frameRate, long loopCap = -1)
        {
            Image = image;
            Frames = frames;
            currentFrameIndex = 0;
            CurrentFrame = Frames[0];
            LoopCount = 0;
            FrameRate = frameRate;
            LoopCap = (uint)loopCap;
        }

        public void AddFrame(Frame frame)
        {
            Frames.Add(frame);
        }

        public void Animate(GameTime gameTime)
        {
            if (!AnimationComplete)
            {
                timer += gameTime.ElapsedGameTime;
                if (timer > FrameRate)
                {
                    timer = TimeSpan.Zero;
                    currentFrameIndex++;
                    if (currentFrameIndex >= Frames.Count)
                    {
                        LoopCount++;
                        currentFrameIndex = 0;
                    }
                    CurrentFrame = Frames[currentFrameIndex];
                }
            }
        }

        public void ResetAnimation()
        {
            LoopCount = 0;
        }

    }
}
