using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Street_Fighter.action.Ryu
{
    class Chute1 : Action
    {
        public Chute1(Game game)
            : base(game, "Chute1")
        {
            this.spriteSheet = game.Content.Load<Texture2D>(@"Ryu\ryu_pezadas1");
            this.fases.Add(new Rectangle(400, 48, 76, 115));
            this.fases.Add(new Rectangle(680, 48, 90, 118));
            this.fases.Add(new Rectangle(911,54 ,162 ,107 ));
            this.fases.Add(new Rectangle(1210,53 ,152 ,109 ));
            this.fases.Add(new Rectangle(1520,50 ,129 ,111 ));
            this.fases.Add(new Rectangle(1841,52 ,93 ,109 ));
            this.fases.Add(new Rectangle(113,226,74 ,113 ));
        }

    }
}
