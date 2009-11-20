using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Street_Fighter.state.Ryu
{
    class Gingando: State
    {
        public override bool isRunning
        {
            get
            {
                return true;
            }
        }

        public Gingando(Game game):base(game,"Gingando")
        {
            this.spriteSheet = game.Content.Load<Texture2D>(@"Ryu\ryu_gingando");
            this.fases.Add(new Rectangle(103, 53, 86, 108));
            this.fases.Add(new Rectangle(390, 53, 86, 108));
        }
    }
}
