using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action.Ryu
{
    class Recuar : Action
    {
        public Recuar(IMoveable objMovimentavel)
            : base(objMovimentavel, "Recuar")
        {
            this.updateInterval = 350;
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_andando_para_atras");
           this.steps.Add(new Rectangle(378, 53, 85, 109));
            this.steps.Add(new Rectangle(969, 48, 73, 113));
            this.steps.Add(new Rectangle(1550, 46, 78, 116));

        }

        protected override void atualizarObjeto()
        {
                if (this.currentStep ==1)
                objMovimentavel.incrementCurrentPosition(35, 0);
        }

    }
}
