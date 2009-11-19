using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using XNAGifAnimationLibrary;

namespace Street_Fighter
{
    public class StreetFighterGame : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteManager manager;
        SpriteBatch spriteBatch;
        Texture2D t1;
        Texture2D t2;
        GifAnimation back = null;

        public StreetFighterGame()
        {
            graphics = new GraphicsDeviceManager(this);
            //graphics.IsFullScreen = true;
            Content.RootDirectory = "Content";
        
        }

        protected override void Initialize()
        {
            manager = new SpriteManager(this);
            Components.Add(manager);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            t1 = Content.Load<Texture2D>(@"Ryu\ryu_win");
            t2 = Content.Load<Texture2D>(@"Ryu\ryu_haduken");
            back = Content.Load<GifAnimation>(@"background\sfz2-vega-animated");
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

           spriteBatch.Begin(SpriteBlendMode.AlphaBlend,SpriteSortMode.BackToFront,SaveStateMode.None);

           spriteBatch.Draw(back.GetTexture(), new Rectangle(0, 0, 800, 600), null, Color.White, 0, Vector2.Zero, SpriteEffects.None, 1);
           spriteBatch.Draw(t2, new Rectangle(300,250,400,300), new Rectangle(649,63,137,100), Color.White, 0, Vector2.Zero, SpriteEffects.None, 0);
            //spriteBatch.Draw(t2, Vector2.Zero, null, Color.White, 0, Vector2.Zero, 0, SpriteEffects.None, 0);
            spriteBatch.End();

            back.Update(gameTime.ElapsedGameTime.Ticks);

            base.Draw(gameTime);
        }
    }
}
