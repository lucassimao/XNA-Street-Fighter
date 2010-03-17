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
using FarseerGames.FarseerPhysics;
using FarseerGames.FarseerPhysics.Factories;
using FarseerGames.FarseerPhysics.Collisions;
using FarseerGames.FarseerPhysics.Dynamics;

namespace Street_Fighter
{

    public class SpriteManager : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        Fighter lutador1;
        Fighter lutador2;
        PhysicsSimulator simulador;
        Body groundBody;
        Geom groundGeom;
        Texture2D barra;
       

        public SpriteManager(Game game, Fighter lutador1, Fighter lutador2)
            : base(game)
        {
            this.lutador1 = lutador1;
            this.lutador2 = lutador2;
            simulador = new PhysicsSimulator(new Vector2(0, 10));
            //simulador.Add(lutador1.Body);
            //simulador.Add(lutador1.Geometry);


           
            groundBody = BodyFactory.Instance.CreateRectangleBody( 800, 10, 1);
            groundGeom = GeomFactory.Instance.CreateRectangleGeom(groundBody, 800, 10);
            groundBody.Position = new Vector2(0, 550);
            groundBody.IsStatic = true;
            groundGeom.RestitutionCoefficient = .2f;
            groundGeom.FrictionCoefficient = .2f;
            
            barra = ContentManagerFacade.Load<Texture2D>("barra");
            simulador.Add(groundBody);
            simulador.Add(groundGeom);
        
           
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
            //simulador.Update(gameTime.ElapsedGameTime.Milliseconds * .001f);
            lutador1.update(gameTime);


        }

        private Vector2 getPosicaoCorrigida(ref Fighter lutador)
        {
            Vector2 posicao = lutador.CurrentPosition;

            float rightLowerXCorner = posicao.X + lutador.PosicaoDeRepouso.CurrentStep.Width * 2;
            float rightLowerYCorner = posicao.Y + lutador.PosicaoDeRepouso.CurrentStep.Height * 2;

            float wrongNewRightLowerXCorner = posicao.X + lutador.CurrentAction.CurrentStep.Width * 2;
            float wrongNewRightLowerYCorner = posicao.Y + lutador.CurrentAction.CurrentStep.Height * 2;

            Vector2 posicaoCorrigida = new Vector2();

            posicaoCorrigida.X = posicao.X - (wrongNewRightLowerXCorner - rightLowerXCorner);
            posicaoCorrigida.Y = posicao.Y - (wrongNewRightLowerYCorner - rightLowerYCorner);

            return posicaoCorrigida;

        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

            spriteBatch.Begin(SpriteBlendMode.AlphaBlend, SpriteSortMode.BackToFront, SaveStateMode.None);

            Vector2 posicaoCorrigida = getPosicaoCorrigida(ref lutador1);

            spriteBatch.Draw(lutador1.CurrentAction.Texture, posicaoCorrigida, lutador1.CurrentAction.CurrentStep,
                Color.White, 0, Vector2.Zero, 2, SpriteEffects.None, 0);

            spriteBatch.Draw(barra, groundBody.Position, null, Color.White, 
                groundBody.Rotation, Vector2.Zero, 1, SpriteEffects.None, 0);

            spriteBatch.End();


        }
    }
}