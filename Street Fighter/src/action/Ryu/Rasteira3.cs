using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Street_Fighter.interfaces;

namespace Street_Fighter.action.Ryu
{
    class Rasteira3 : Action
    {
        public Rasteira3()
            : base(null, "Rasteira3")
        {
            this.updateInterval = 120;
            this.spriteSheet = ContentManagerFacade.Load<Texture2D>(@"Ryu\ryu_golpesRasteiros");
            this.steps.Add(new Rectangle(1536, 614, 131, 87));
            this.steps.Add(new Rectangle(1834,616, 85, 81));
            this.steps.Add(new Rectangle(30, 790, 167, 85));
            this.steps.Add(new Rectangle(326,786, 167,93));
            this.steps.Add(new Rectangle(626, 784, 133, 89));
            this.steps.Add(new Rectangle(928, 800, 121,69));
            this.steps.Add(new Rectangle(1538, 790, 91, 83));
            this.steps.Add(new Rectangle(1838, 788, 97, 83));
  
        }
    }
}

