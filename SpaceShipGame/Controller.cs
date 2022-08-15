using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceShipGame
{
    class Controller
    {
        public List<Asteroid> asteroids = new List<Asteroid>();
        public double timer = 2;

        public void conUpdate(GameTime gameTime)
        {
            timer -= gameTime.ElapsedGameTime.TotalSeconds;

            if (timer <= 0)
            {
                asteroids.Add(new Asteroid(250));
                timer = 2d;
            }

        }
    }
}
