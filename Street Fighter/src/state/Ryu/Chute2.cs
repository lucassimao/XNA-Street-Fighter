using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Street_Fighter.state.Ryu
{
    class Chute2 : State
    {
        public Chute2(Game game)
            : base(game, "Chute2")
        {
            this.updateInterval = 400;
            this.spriteSheet = game.Content.Load<Texture2D>(@"Ryu\ryu_pezadas1");
            this.fases.Add(new Rectangle(683, 237, 83, 103));
            this.fases.Add(new Rectangle(971, 238, 88, 102));
            this.fases.Add(new Rectangle(1542, 227, 88, 113));
            this.fases.Add(new Rectangle(1843, 234, 78, 103));
            this.fases.Add(new Rectangle(78, 397, 115, 120));
            this.fases.Add(new Rectangle(357, 399, 115, 116));
            this.fases.Add(new Rectangle(637, 402, 121, 115));
            this.fases.Add(new Rectangle(923, 415, 119, 100));
            this.fases.Add(new Rectangle(1250, 409, 78, 106));
            this.fases.Add(new Rectangle(1841, 409, 87, 108));
            this.fases.Add(new Rectangle(103, 589, 81, 107));
        }

    }
}
