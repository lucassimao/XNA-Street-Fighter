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
        public Gingando(Game game):base(game,"Gingando")
        {
            this.spriteSheet = game.Content.Load<Texture2D>(@"Ryu\ryu_gingando");
            this.fases.Add(new Rectangle(103, 53, 86, 108));
            this.fases.Add(new Rectangle(390, 53, 86, 108));
        }

        public override void update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            this.timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (this.timeSinceLastFrame > this.updateInterval)
            {
                if (this.faseAtual == this.fases.Count-1)
                    this.faseAtual = 0;
                else
                    this.faseAtual++;
                this.timeSinceLastFrame = 0;
            }
        }
    }
}
