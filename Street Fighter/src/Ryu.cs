using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Street_Fighter.action;
using Street_Fighter.action.Ryu;

namespace Street_Fighter
{
    class Ryu : Fighter
    {
        private Random random;

        public Ryu(Game game)
            : base(game)
        {
            this.random = new Random();
            states.Add(new Gingando(game));
            states.Add(new Chute1(game));
            states.Add(new Chute2(game));
            states.Add(new Chute3(game));
            states.Add(new Chute4(game));
            this.currentState = states[0];


        }

        public override void update(GameTime gameTime)
        {

                KeyboardState state = Keyboard.GetState();
                if ((!this.currentState.isRunning ||  this.currentState == states[0]) && state.IsKeyDown(Keys.C))
                    this.currentState = states[this.random.Next(1, 5)];

                if (!this.currentState.isRunning)
                {
                    this.currentState.reset();
                    this.currentState = states[0];
                }

                this.currentState.update(gameTime);


        }
    }
}
