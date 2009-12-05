using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action.Ryu
{
    class Rasteira1 : Action
    {
        public Rasteira1()
            : base(null, "Rasteira1")
        {
            this.updateInterval = 350;
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_golpesRasteiros");
            this.steps.Add(new Rectangle(104, 442, 84, 80));
            this.steps.Add(new Rectangle(386, 445, 98, 72));
            this.steps.Add(new Rectangle(632, 446, 139,73));
            this.steps.Add(new Rectangle(923, 445, 139, 73));
            this.steps.Add(new Rectangle(1250, 445, 102, 73));
            this.steps.Add(new Rectangle(1547, 436, 92, 82));

        }
    }
}

