using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action.Ryu
{
    class DefesaParaBaixo : Action
    {
        public DefesaParaBaixo()
            : base(null, "DefesaParaBaixo")
        {
            this.updateInterval = 200;
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_defesa_para_baixo");
            this.steps.Add(new Rectangle(99, 68, 87, 93));
            this.steps.Add(new Rectangle(385, 87, 92, 75));
            this.steps.Add(new Rectangle(1258, 81, 90, 81));
            this.steps.Add(new Rectangle(99, 68, 87, 93));

        }
    }
}
  
