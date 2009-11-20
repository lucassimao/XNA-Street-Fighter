using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Street_Fighter.state;
using Street_Fighter.state.Ryu;

namespace Street_Fighter
{
    class Ryu: Fighter
    {
        public Ryu(Game game):base(game)
        {
            states.Add(new Gingando(game));
            this.currentState = states[0];
       

        }

        public override void update(GameTime gameTime)
        {
            foreach (State s in states)
                s.update(gameTime);
          

        }
    }
}
