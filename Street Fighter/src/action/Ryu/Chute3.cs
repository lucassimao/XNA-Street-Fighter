using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action.Ryu
{
    class Chute3 : Action
    {
        public Chute3()
            : base(null, "Chute3")
        {
            this.updateInterval = 250;
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_pezadas2");
            this.steps.Add(new Rectangle(95, 405, 95, 112));
            this.steps.Add(new Rectangle(388, 407, 91, 105));
            this.steps.Add(new Rectangle(690, 409, 80, 107));
            this.steps.Add(new Rectangle(977, 415, 83, 101));
            this.steps.Add(new Rectangle(1196, 413, 178, 103));
            this.steps.Add(new Rectangle(1508, 417, 154, 100));
            this.steps.Add(new Rectangle(70, 594, 134, 100));
            this.steps.Add(new Rectangle(383, 589, 106, 107));
            this.steps.Add(new Rectangle(677, 582, 92, 105));

        }
    }
}
