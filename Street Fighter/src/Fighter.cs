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

namespace Street_Fighter
{
   public abstract class Fighter
    {
       protected List<Street_Fighter.action.Action> states;
       protected Street_Fighter.action.Action currentState;
        protected Vector2 posicao;
        protected uint life;
        protected Game game;

        public Street_Fighter.action.Action CurrentState
        {
            get
            {
                return currentState;
            }
        }


        protected Fighter(Game game)
        {
            this.states = new List<Street_Fighter.action.Action>();
            this.game = game;
            this.life = 1000;
            this.posicao = Vector2.Zero;
            this.currentState = null;
        }

        public abstract void update(GameTime gameTime);
    }
}
