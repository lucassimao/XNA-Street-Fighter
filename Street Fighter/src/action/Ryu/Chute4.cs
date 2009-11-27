using System.Collections.Generic;
using Street_Fighter.interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Street_Fighter.action.Ryu
{
    class Chute4 : Action
    {
        public Chute4()
            : base(null, "Chute4")
        {
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_pezadas2");
            this.steps.Add(new Rectangle(97, 56, 70, 103));
            this.steps.Add(new Rectangle(348, 52, 111, 108));
            this.steps.Add(new Rectangle(644, 49, 105, 111));
            this.steps.Add(new Rectangle(961, 54, 76, 107));
            this.steps.Add(new Rectangle(1264, 50, 69, 112));
            this.steps.Add(new Rectangle(1550, 53, 86, 110));
        }

    }
}
