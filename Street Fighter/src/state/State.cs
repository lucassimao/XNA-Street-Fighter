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
        protected uint updateInterval = 700;
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
        public virtual bool isRunning
        {
            get
            {
                return faseAtual != fases.Count-1;
            }
        }


        public State(Game game, String descricao)
        {
            this.game = game;
            this.descricao = descricao;
        }

        public void update(GameTime gameTime)
        {
            this.timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (this.timeSinceLastFrame > this.updateInterval)
            {
                if (this.faseAtual == this.fases.Count - 1)
                    this.faseAtual = 0;
                else
                    this.faseAtual++;
                this.timeSinceLastFrame = 0;
            }
        }

        public virtual void reset()
        {
            this.timeSinceLastFrame = 0;
            this.faseAtual = 0;
        }

    }
}
