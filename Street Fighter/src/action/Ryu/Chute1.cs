using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action.Ryu
{
    class Chute1 : Action
    {
        public Chute1()
            : base(null, "Chute1")
        {

            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_pezadas1");
            this.steps.Add(new Rectangle(400, 48, 76, 115));
            this.steps.Add(new Rectangle(680, 48, 90, 118));
            this.steps.Add(new Rectangle(911,54 ,162 ,107 ));
            this.steps.Add(new Rectangle(1210,53 ,152 ,109 ));
            this.steps.Add(new Rectangle(1520,50 ,129 ,111 ));
            this.steps.Add(new Rectangle(1841,52 ,93 ,109 ));
            this.steps.Add(new Rectangle(113,226,74 ,113 ));
        }

    }
}
