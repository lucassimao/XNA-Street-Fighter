using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action.Ryu
{
    class Avancar : Action
    {
        public Avancar(IMoveable objMovimentavel)
            : base(objMovimentavel, "Avancar")
        {
            this.updateInterval = 550;
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_andando_para_frente");
            this.steps.Add(new Rectangle(1261, 49, 96, 109));
            this.steps.Add(new Rectangle(1549, 49, 90, 113));
 
        }

        protected override void atualizarObjeto()
        {
            if (this.currentStep == 1)
                objMovimentavel.incrementCurrentPosition(-35, 0);
        }

    }
}
