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
using Street_Fighter.interfaces;
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

            Vector2 posicao = lutador1.CurrentPosition;

            float rightLowerXCorner = posicao.X + lutador1.PosicaoDeRepouso.CurrentStep.Width*2;
            float rightLowerYCorner = posicao.Y + lutador1.PosicaoDeRepouso.CurrentStep.Height*2;

            float wrongNewRightLowerXCorner = posicao.X + lutador1.CurrentAction.CurrentStep.Width*2;
            float wrongNewRightLowerYCorner = posicao.Y + lutador1.CurrentAction.CurrentStep.Height*2;


            Vector2 posicaoCorrigida = new Vector2();

            posicaoCorrigida.X = posicao.X - (wrongNewRightLowerXCorner - rightLowerXCorner);
            posicaoCorrigida.Y = posicao.Y - (wrongNewRightLowerYCorner - rightLowerYCorner);

            spriteBatch.Draw(lutador1.CurrentAction.Texture, posicaoCorrigida, lutador1.CurrentAction.CurrentStep,
                Color.White, 0, Vector2.Zero, 2, SpriteEffects.None, 0);

            spriteBatch.End();


        }
    }
}