using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceShipGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D asteroid;
        private Texture2D ship;
        private Texture2D space_background;
        private SpriteFont timerFont;
        private SpriteFont defaultFont;
        private Texture2D logo;
        private Ship player = new Ship();
        Asteroid tAsteroid = new Asteroid(100);
        Controller gameController = new Controller();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.IsMouseVisible = true;
            
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            

            //Resize the resolution
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            asteroid = Content.Load<Texture2D>("asteroid");
            ship = Content.Load<Texture2D>("ship");
            space_background = Content.Load<Texture2D>("space");
            timerFont = Content.Load<SpriteFont>("timerFont");
            defaultFont = Content.Load<SpriteFont>("spaceFont");


            //scale = new Vector2(targetX / (float)logo.Width, targetX / (float)logo.Width);
            //targetY = logo.Height * scale.Y;



            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            player.shipUpdate(gameTime);
            tAsteroid.asteroidUpdate(gameTime);
            gameController.conUpdate(gameTime);

            for(int i = 0; i < gameController.asteroids.Count; i++)
            {
                gameController.asteroids[i].asteroidUpdate(gameTime);
            }
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            _spriteBatch.Begin();

            _spriteBatch.Draw(space_background, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(ship, new Vector2(player.position.X - 34 , player.position.Y - 50), Color.White);
            //_spriteBatch.DrawString(timerFont, gameTime.ElapsedGameTime.TotalSeconds.ToString(), new Vector2(300, 300), Color.White);
            
            for (int i = 0; i < gameController.asteroids.Count; i++)
            {
                Vector2 tempPos = gameController.asteroids[i].position;
                int radius = gameController.asteroids[i].radius;
                _spriteBatch.Draw(asteroid, new Vector2(tempPos.X - radius, tempPos.Y - radius), Color.White);
                
            }
            //_spriteBatch.Draw(logo, new Vector2(0,0), scale:scale, Color.White);
            //_spriteBatch.Draw(logo, new Vector2(700,300), null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
