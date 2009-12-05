using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action.Ryu
{
    class SocoPorBaixo : Action
    {
        public SocoPorBaixo()
            : base(null, "SocoPorBaixo")
        {
            this.updateInterval = 350;
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_golpesRasteiros");
            this.steps.Add(new Rectangle(96, 91, 93, 72));
            this.steps.Add(new Rectangle(353, 86, 123, 81));
            this.steps.Add(new Rectangle(962, 90, 97, 74));
            this.steps.Add(new Rectangle(1247, 88, 102, 75));

        }
    }
}

