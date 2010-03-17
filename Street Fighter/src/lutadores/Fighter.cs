using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using Street_Fighter.action;
using Street_Fighter.interfaces;
using FarseerGames.FarseerPhysics;
using FarseerGames.FarseerPhysics.Factories;
using FarseerGames.FarseerPhysics.Collisions;
using FarseerGames.FarseerPhysics.Dynamics;

namespace Street_Fighter
{
    public abstract class Fighter : IMoveable
    {
        protected List<Action> actions;
        protected uint life;

        // é a posição onde ele fica "gingando"
        public Action PosicaoDeRepouso { get; protected set; }
        public Action CurrentAction { get; protected set; }

        public Body Body {  get;private set; }

        public Geom Geometry { get; private set; }

        public Vector2 CurrentPosition {   get { return Body.Position; }  }


        protected Fighter(Vector2 posicao)
        {
            this.actions = new List<Action>();
            this.life = 1000;
            Body = BodyFactory.Instance.CreateRectangleBody(88, 10, 90);
            Body.Position = posicao;
            Geometry = GeomFactory.Instance.CreateRectangleGeom(Body, 88, 10);
                     
        }
        void IMoveable.incrementCurrentPosition(float xInc, float yInc)
        {
            Body.Position = new Vector2(Body.Position.X + xInc, Body.Position.Y + yInc);
        }
        public abstract void update(GameTime gameTime);
    }
}
