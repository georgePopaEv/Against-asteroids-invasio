using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceShipGame
{
    class Ship
    {
        public Vector2 position = new Vector2(100,100);
        private int speed = 180;

        public void shipUpdate(GameTime gameTime)
        {
            KeyboardState kstate = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            
            if(kstate.IsKeyDown(Keys.Down))
            {
                position.Y += speed *dt;
            }
            if (kstate.IsKeyDown(Keys.Up))
            {
                position.Y -= speed * dt;
            }
            if (kstate.IsKeyDown(Keys.Right))
            {
                position.X += speed * dt;
            }
            if (kstate.IsKeyDown(Keys.Left))
            {
                position.X -= speed * dt;
            }
        }
    }
}
