using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action.Ryu
{
    class SocoDeBaixoParaCima : Action
    {
        public SocoDeBaixoParaCima()
            : base(null, "SocoDeBaixoParaCima")
        {
            this.updateInterval = 80;
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_golpesRasteiros");
            this.steps.Add(new Rectangle(1545, 81, 91, 83));
            this.steps.Add(new Rectangle(1834, 77, 90, 86));
            this.steps.Add(new Rectangle(93, 240, 91, 96));
            this.steps.Add(new Rectangle(387,204, 82, 136));
            this.steps.Add(new Rectangle(683, 213, 80, 126));
            this.steps.Add(new Rectangle(972, 213, 80, 128));
            this.steps.Add(new Rectangle(1259, 227, 84, 112));
            this.steps.Add(new Rectangle(1546, 237, 86, 103));
            this.steps.Add(new Rectangle(1839, 253, 88, 85));

        }
    }
}

