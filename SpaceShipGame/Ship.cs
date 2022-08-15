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
        
        private int speed = 180;
        static public Vector2 defaultPosition = new Vector2(640, 360);
        public Vector2 position = defaultPosition;

        public void shipUpdate(GameTime gameTime, Controller gameController)
        {
            KeyboardState kstate = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (gameController.inGame)
            {
                if (kstate.IsKeyDown(Keys.Down) && position.Y <720 - 50)
                {
                    position.Y += speed * dt;
                }
                if (kstate.IsKeyDown(Keys.Up) && position.Y > 50)
                {
                    position.Y -= speed * dt;
                }
                if (kstate.IsKeyDown(Keys.Right) && position.X < 1280 -34)
                {
                    position.X += speed * dt;
                }
                if (kstate.IsKeyDown(Keys.Left) && position.X > 0 + 34)
                {
                    position.X -= speed * dt;
                }
                if (gameController.maxTime >= 1.0 && gameController.maxTime <= 1.5)
                    this.speed=300;
                else if (gameController.maxTime >= 0.7 && gameController.maxTime < 1)
                    this.speed=60;
                else if (gameController.maxTime >= 0.5 && gameController.maxTime < 7)
                    this.speed=300;
            }
        }

        
    }
}
