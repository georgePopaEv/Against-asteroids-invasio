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
        public double maxTime = 2;
        public int nextSpeed = 245;
        public bool inGame = false;
        public float totalTime = 0.0f;

        public void conUpdate(GameTime gameTime)
        {
            if (inGame)
            {
                timer -= gameTime.ElapsedGameTime.TotalSeconds;
                totalTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else
            {
                KeyboardState kstate = Keyboard.GetState();
                if (kstate.IsKeyDown(Keys.Enter)) 
                { 
                    inGame = true;
                    maxTime = 2;
                    nextSpeed = 245;
                    timer = 2;
                    totalTime = 0.0f;
                }

            
            }   
            

            if (timer <= 0)
            {
                asteroids.Add(new Asteroid(300));
                timer = maxTime;
                if (maxTime > 0.5)
                {
                    maxTime -= 0.1;
                }
                
                if (nextSpeed < 720)
                {
                    nextSpeed += 4;
                }
            }

        }
    }
}
