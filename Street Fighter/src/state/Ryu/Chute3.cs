using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Street_Fighter.state.Ryu
{
    class Chute4 : State
    {
        public Chute4(Game game)
            : base(game, "Chute4")
        {
            this.updateInterval = 250;
            this.spriteSheet = game.Content.Load<Texture2D>(@"Ryu\ryu_pezadas2");
            this.fases.Add(new Rectangle(95, 405,95, 112));
            this.fases.Add(new Rectangle(388, 407, 91, 105));
            this.fases.Add(new Rectangle(690, 409, 80, 107));
            this.fases.Add(new Rectangle(977, 415, 83, 101));
            this.fases.Add(new Rectangle(1196, 413, 178, 103));
            this.fases.Add(new Rectangle(1508, 417, 154, 100));

            this.fases.Add(new Rectangle(70,594, 134, 100));
            this.fases.Add(new Rectangle(383, 589, 106, 107));
            this.fases.Add(new Rectangle(677, 582, 92, 112));
 
        }

    }
}
