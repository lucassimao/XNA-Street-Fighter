using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Street_Fighter.action.Ryu
{
    class Chute4 : Action
    {
        public Chute4(Game game)
            : base(game, "Chute4")
        {
            this.spriteSheet = game.Content.Load<Texture2D>(@"Ryu\ryu_pezadas2");
            this.fases.Add(new Rectangle(97, 56, 70, 103));
            this.fases.Add(new Rectangle(348, 52, 111, 108));
            this.fases.Add(new Rectangle(644, 49, 105, 111));
            this.fases.Add(new Rectangle(961, 54, 76, 107));
            this.fases.Add(new Rectangle(1264, 50, 69, 112));
            this.fases.Add(new Rectangle(1550, 53, 86, 110));
        }

    }
}
