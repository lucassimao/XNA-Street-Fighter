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
using Street_Fighter.lutadores;

namespace Street_Fighter
{
    public class StreetFighterGame : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteManager manager;
        SpriteBatch spriteBatch;
        GifAnimation back = null;

        public StreetFighterGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            
        }

        protected override void Initialize()
        {
            ContentManagerFacade.buildGameContentManager(this);
            manager = new SpriteManager(this, new Ryu(new Vector2(440, 330)), null);
            Components.Add(manager);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            back = Content.Load<GifAnimation>(@"background\sfz2-vega-animated");
        }

        protected override void UnloadContent()
        {
  
        }

        protected override void Update(GameTime gameTime)
        {
            back.Update(gameTime.ElapsedGameTime.Ticks);
            manager.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(SpriteBlendMode.AlphaBlend, SpriteSortMode.BackToFront, SaveStateMode.None);
            
            spriteBatch.Draw(back.GetTexture(), new Rectangle(0, 0, Window.ClientBounds.Width, Window.ClientBounds.Height), null, Color.White, 0, Vector2.Zero, SpriteEffects.None, 1);
           
            manager.Draw(gameTime);
            
            spriteBatch.End();

            

            base.Draw(gameTime);
        }
    }
}
