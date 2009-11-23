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

namespace Street_Fighter
{
    public abstract class Fighter : IMoveable
    {
        protected List<Action> actions;
        protected Action currentAction;
        protected Action posicaoDeRepouso; // é a posição onde ele fica "gingando"
        protected Vector2 posicao;
        protected readonly Vector2 startPosition;
        protected uint life;

        public Action CurrentAction
        {
            get
            {
                return currentAction;
            }
        }

        Vector2 IMoveable.CurrentPosition
        {
            get { return posicao; }
        }

        void IMoveable.toStartPosition() {
            this.posicao = startPosition;
        }

        Rectangle IMoveable.ReferenceSurface { get { return posicaoDeRepouso.CurrentStep; } }

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
            this.startPosition = posicao;
            this.posicao = posicao;
            this.currentAction = null;
        }

        public abstract void update(GameTime gameTime);
    }
}
