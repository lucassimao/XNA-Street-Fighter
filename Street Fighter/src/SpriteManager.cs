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

    public class SpriteManager : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        Fighter lutador1;
        Fighter lutador2;

        public SpriteManager(Game game, Fighter lutador1, Fighter lutador2)
            : base(game)
        {
            this.lutador1 = lutador1;
            this.lutador2 = lutador2;
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);    
            lutador1.update(gameTime);
                
            
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
                spriteBatch.Begin(SpriteBlendMode.AlphaBlend, SpriteSortMode.BackToFront, SaveStateMode.None);
                
                spriteBatch.Draw(lutador1.CurrentState.CurrentTexture, new Vector2(440, 330), lutador1.CurrentState.CurrentFase,
                    Color.White, 0, Vector2.Zero, 2, SpriteEffects.None, 0);
                spriteBatch.End();

               
   
        }
    }
}