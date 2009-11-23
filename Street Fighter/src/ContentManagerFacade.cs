using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Street_Fighter
{
    // Uma classe para encapsular uma instância de ContentManager para um determinado Game
    class ContentManagerFacade
    {
        private static ContentManager content;

        private ContentManagerFacade() { }

        public static void buildGameContentManager(Game game)
        {
            content = game.Content;
        }

        public static T Load<T>(String assetName)
        {
            return content.Load<T>(assetName);
        }
    }
}
