using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace Street_Fighter
{
   abstract class Fighter
    {
        protected List<Texture2D> spriteSheets;
        protected Texture2D currentSpriteSheet;
        protected Rectangle currentSprite;
        protected Vector2 posicao;
        protected uint updateInterval;
        protected uint life;
    }
}
