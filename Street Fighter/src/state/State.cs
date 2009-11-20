using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Street_Fighter.state
{
    public abstract class State
    {
        protected String descricao;
        protected Game game = null;
        protected Texture2D spriteSheet = null;
        protected List<Rectangle> fases = new List<Rectangle>();
        protected ushort faseAtual = 0;
        protected uint updateInterval = 1000;
        protected int timeSinceLastFrame = 0;
        public Texture2D CurrentTexture
        {
            get
            {
                return spriteSheet;
            }
        }
        public Rectangle CurrentFase
        {
            get
            {
                return fases[faseAtual];
            }
        }

        public State(Game game,String descricao)
        {
            this.game = game;
            this.descricao = descricao;
        }

        public abstract void update(GameTime gameTime);
        
    }
}
