using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action.Ryu
{
    class Rasteira2 : Action
    {
        public Rasteira2()
            : base(null, "Rasteira2")
        {
            this.updateInterval = 100;
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_golpesRasteiros");
            this.steps.Add(new Rectangle(1836, 438, 111, 83));
            this.steps.Add(new Rectangle(90,618, 103, 79));
            this.steps.Add(new Rectangle(324, 616, 179, 87));
            this.steps.Add(new Rectangle(634, 618, 159,81));
            this.steps.Add(new Rectangle(922, 618, 159, 85));
            this.steps.Add(new Rectangle(1254, 624, 115, 71));
            this.steps.Add(new Rectangle(86, 88, 111, 79));

        }
    }
}

