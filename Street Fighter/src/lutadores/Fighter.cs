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
using FarseerGames.FarseerPhysics.Factories;
using FarseerGames.FarseerPhysics.Collisions;
using FarseerGames.FarseerPhysics.Dynamics;

namespace Street_Fighter
{
    public abstract class Fighter : IMoveable
    {
        protected List<Action> actions;
        protected Action currentAction;
        protected Action posicaoDeRepouso; // é a posição onde ele fica "gingando"
        protected Vector2 posicao;
        protected uint life;
        protected Body body;
        protected Geom geometry;

        public Action PosicaoDeRepouso
        {
            get { return this.posicaoDeRepouso; }
        }
        public Action CurrentAction
        {
            get
            {
                return currentAction;
            }
        }

        public Vector2 CurrentPosition
        {
            get { return posicao; }
        }



        void IMoveable.incrementCurrentPosition(float xInc, float yInc)
        {
            posicao.X += xInc;
            posicao.Y += yInc;
        }

        protected Fighter(Vector2 posicao)
        {
            this.actions = new List<Action>();
            this.life = 1000;
            this.posicao = posicao;
            this.posicao = posicao;
            this.currentAction = null;
            this.body = BodyFactory.Instance.CreateRectangleBody(50, 50, 10);
            this.geometry = GeomFactory.Instance.CreateRectangleGeom(this.body, 50, 50);
        }

        public abstract void update(GameTime gameTime);
    }
}
