using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action.Ryu
{
    class DefesaPorCima : Action
    {
        public DefesaPorCima(IMoveable objMovimentavel)
            : base(objMovimentavel, "DefesaPorCima")
        {
            this.updateInterval = 120;
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_escapando_por_cima");
            this.steps.Add(new Rectangle(104, 34, 82, 130));
            this.steps.Add(new Rectangle(393, 33, 81,133));
            this.steps.Add(new Rectangle(682, 39, 80, 111));
            this.steps.Add(new Rectangle(971, 45, 78, 94));
            this.steps.Add(new Rectangle(1261, 47, 82, 88));
            this.steps.Add(new Rectangle(1557, 42, 77, 89));
            this.steps.Add(new Rectangle(1893, 43, 83, 94));

        }

        protected override void atualizarObjeto()
        {
            if (this.currentStep <= 3)
                objMovimentavel.incrementCurrentPosition(0,-45);
            else
                objMovimentavel.incrementCurrentPosition(0,45);
        }
    }
}

