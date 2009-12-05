using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action.Ryu
{
    class DefesaParaBaixo2 : Action
    {
        public DefesaParaBaixo2()
            : base(null, "DefesaParaBaixo2")
        {
            this.updateInterval = 350;
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_defesa_por_baixo");
            this.steps.Add(new Rectangle(93, 82, 95, 82));
            this.steps.Add(new Rectangle(383, 84, 96, 75));
            this.steps.Add(new Rectangle(677, 85, 90, 76));
            this.steps.Add(new Rectangle(965, 81, 93, 81));
            this.steps.Add(new Rectangle(1257, 81, 90, 80));

        }
    }
}

