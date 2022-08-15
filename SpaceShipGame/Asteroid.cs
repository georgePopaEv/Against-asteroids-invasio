using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceShipGame
{
    class Asteroid
    {
        public Vector2 position;
        private int speed; // it is a good practice to not write or assign a value
        public int radius = 59;

        public Asteroid(int newSpeed)
        {
            this.speed = newSpeed;

            Random rand = new Random();

            this.position = new Vector2(1280+radius, rand.Next(0,720));
        }

        public void asteroidUpdate(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= dt * speed;
        }

        public int getSpeed()
        {
            return this.speed;
        }
    }
}
