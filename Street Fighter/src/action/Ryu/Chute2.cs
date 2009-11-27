using System.Collections.Generic;
using Street_Fighter.interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Street_Fighter.action.Ryu
{
    class Chute2 : Action
    {
        public Chute2()
            : base(null, "Chute2")
        {
            this.updateInterval = 150;
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_pezadas1");
            this.steps.Add(new Rectangle(683, 237, 83, 103));
            this.steps.Add(new Rectangle(971, 238, 88, 102));
            this.steps.Add(new Rectangle(1542, 227, 88, 113));
            this.steps.Add(new Rectangle(1843, 234, 78, 103));
            this.steps.Add(new Rectangle(78, 397, 115, 120));
            this.steps.Add(new Rectangle(357, 399, 115, 116));
            this.steps.Add(new Rectangle(637, 402, 121, 115));
            this.steps.Add(new Rectangle(923, 415, 119, 100));
            this.steps.Add(new Rectangle(1250, 409, 78, 106));
            this.steps.Add(new Rectangle(1841, 409, 87, 108));
            this.steps.Add(new Rectangle(103, 589, 81, 107));
        }
    }
}
