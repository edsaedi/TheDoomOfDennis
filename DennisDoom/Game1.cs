using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace DennisDoom
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Random random = new Random();

        Texture2D boom;
        List<Explosion> explosions;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            boom = Content.Load<Texture2D>("boom");

            explosions = new List<Explosion>();
            explosions.Add(new Explosion(boom, new Vector2(random.Next(0, GraphicsDevice.Viewport.Width), random.Next(0, GraphicsDevice.Viewport.Height))));
        }


        protected override void UnloadContent()
        {
        }
        protected override void Update(GameTime gameTime)
        {

            explosions.Add(new Explosion(boom, new Vector2(random.Next(0, GraphicsDevice.Viewport.Width), random.Next(0, GraphicsDevice.Viewport.Height))));

            for (int i = 0; i < explosions.Count; i++)
            {
                explosions[i].Update(gameTime);

                if (explosions[i].CurrentAnimation.AnimationComplete)
                {
                    explosions.RemoveAt(i);
                }
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();


            foreach (Explosion e in explosions)
            {
                e.Draw(spriteBatch);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
