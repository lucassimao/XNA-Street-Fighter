using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action
{
    public abstract class Action
    {
        protected readonly String descricao;
        protected readonly IMoveable objMovimentavel;
        protected Texture2D spriteSheet;
        protected List<Rectangle> steps = new List<Rectangle>();
        protected ushort currentStep = 0;
        protected uint updateInterval = 350;
        protected int timeSinceLastFrame = 0;

        public Texture2D Texture
        {
            get
            {
                return spriteSheet;
            }
        }
        public Rectangle CurrentStep
        {
            get
            {
                return steps[currentStep];
            }
        }
        public virtual bool isRunning
        {
            get
            {
                return currentStep != steps.Count-1;
            }
        }

        public Action(IMoveable objMovimentavel, String descricao)
        {
            this.objMovimentavel = objMovimentavel;
            this.descricao = descricao;
        }

        public void update(GameTime gameTime)
        {
            this.timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (this.timeSinceLastFrame > this.updateInterval)
            {
                if (this.currentStep == this.steps.Count - 1)
                    this.currentStep = 0;
                else
                    this.currentStep++;

                atualizarPosicionamento();

                this.timeSinceLastFrame = 0;
            }
        }

        public virtual void reset()
        {
            this.timeSinceLastFrame = 0;
            this.currentStep = 0;
        }

        protected virtual void atualizarPosicionamento()
        {
           float deltaX = objMovimentavel.ReferenceSurface.Width - CurrentStep.Width ;
           float deltaY = objMovimentavel.ReferenceSurface.Height - CurrentStep.Height;

           objMovimentavel.toStartPosition();
           objMovimentavel.incrementCurrentPosition(deltaX, deltaY);
        }

        public override string ToString()
        {
            return this.descricao;
        }

    }
}
