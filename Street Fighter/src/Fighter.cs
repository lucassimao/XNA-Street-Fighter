using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using Street_Fighter.state;

namespace Street_Fighter
{
   public abstract class Fighter
    {
        protected List<State> states;
        protected State currentState;
        protected Vector2 posicao;
        protected uint updateInterval;
        protected uint life;
        protected Game game;

        public State CurrentState
        {
            get
            {
                return currentState;
            }
        }


        protected Fighter(Game game)
        {
            this.states = new List<State>();
            this.game = game;
            this.updateInterval = 50;
            this.life = 1000;
            this.posicao = Vector2.Zero;
            this.currentState = null;
        }

        public abstract void update(GameTime gameTime);
    }
}
