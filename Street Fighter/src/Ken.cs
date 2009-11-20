using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Street_Fighter
{
    class Ken : Fighter
    {
        public Ken(Game game):base(game)
        {
            ContentManager cm = game.Content;
        }

        public override void update(GameTime gameTime)
        {

        }
    }
}
