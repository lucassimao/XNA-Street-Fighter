using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Street_Fighter.action;
using Street_Fighter.action.Ryu;

namespace Street_Fighter.lutadores
{
    class Ryu : Fighter
    {
        private Random random;

        public Ryu(Vector2 posicao)
            : base(posicao)
        {
            this.random = new Random();
            this.PosicaoDeRepouso = new Gingando(this);

            actions.Add(this.PosicaoDeRepouso);
            actions.Add(new Chute1());
            actions.Add(new Chute2());
            actions.Add(new Chute3());
            actions.Add(new Chute4());
            actions.Add(new Recuar(this));
            actions.Add(new Avancar(this));
            actions.Add(new DefesaParaBaixo());
            actions.Add(new DefesaParaBaixo2());
            actions.Add(new DefesaPorCima(this));
            actions.Add(new SocoPorBaixo());
            actions.Add(new SocoDeBaixoParaCima());
            actions.Add(new Rasteira1());
            actions.Add(new Rasteira2());
            actions.Add(new Rasteira3());
            this.CurrentAction = actions[0];


        }

        public override void update(GameTime gameTime)
        {
            this.CurrentAction.update(gameTime);
           
            if (Keyboard.GetState().IsKeyDown(Keys.A))
                this.Body.ApplyImpulse(new Vector2(-250, -250));

            if (!this.CurrentAction.isRunning || this.CurrentAction == this.PosicaoDeRepouso)
            {
                KeyboardState state = Keyboard.GetState();
                int qtdeTeclas = state.GetPressedKeys().Length;

                switch (qtdeTeclas)
                {

                    case 1:
                        if (state.IsKeyDown(Keys.C))
                            this.CurrentAction = actions[this.random.Next(1, 5)];
                        else if (state.IsKeyDown(Keys.Right))
                            this.CurrentAction = actions[5];
                        else if (state.IsKeyDown(Keys.Left))
                            this.CurrentAction = actions[6];
                        else if (state.IsKeyDown(Keys.R))
                            this.CurrentAction = actions[this.random.Next(12, 15)];
                        else if (state.IsKeyDown(Keys.Down))
                            this.CurrentAction = actions[this.random.Next(7, 9)];
                        else if (state.IsKeyDown(Keys.Up))
                            this.CurrentAction = actions[9];

                        Console.WriteLine(this.CurrentAction);
                        

                        break;
                    case 2:
                        if (state.IsKeyDown(Keys.Down) && state.IsKeyDown(Keys.S))
                            this.CurrentAction = actions[10];
                        else if (state.IsKeyDown(Keys.Up) && state.IsKeyDown(Keys.S))
                            this.CurrentAction = actions[11];
                        break;

                }


                // se todas as "fases" da atual ação já foram renderizadas, voltemos à posição de repouso (gingando)
                if (!this.CurrentAction.isRunning)
                {
                   this.CurrentAction.reset();
                    this.CurrentAction = this.PosicaoDeRepouso;
                }
            }
        }
    }
}
