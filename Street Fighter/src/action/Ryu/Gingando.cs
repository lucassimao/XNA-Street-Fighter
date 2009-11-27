using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action.Ryu
{
    class Gingando: Action
    {
        public override bool isRunning
        {
            get
            {
                return true;
            }
        }

        public Gingando(IMoveable objMovimentavel)
            : base(objMovimentavel, "Gingando")
        {
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_gingando");
            this.steps.Add(new Rectangle(103, 53, 88, 108));
            this.steps.Add(new Rectangle(390, 53, 88, 108));
        }

        protected override void atualizarObjeto()
        {
            if (this.currentStep == 0)
                objMovimentavel.incrementCurrentPosition(5, 0);
            else
                objMovimentavel.incrementCurrentPosition(-5, 0);
        }
    }
}
