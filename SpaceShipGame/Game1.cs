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

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            //_graphics.PreferredBackBufferWidth = 1280;
            //_graphics.PreferredBackBufferHeight = 720;
            //_graphics.PreferredBackBufferWidth = GraphicsDevice.Adapter.CurrentDisplayMode.Width;
            //_graphics.PreferredBackBufferHeight = GraphicsDevice.Adapter.CurrentDisplayMode.Height;
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            asteroid = Content.Load<Texture2D>("asteroid");
            ship = Content.Load<Texture2D>("ship");
            space_background = Content.Load<Texture2D>("space");
            timerFont = Content.Load<SpriteFont>("timerFont");
            defaultFont = Content.Load<SpriteFont>("spaceFont");

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            

            _spriteBatch.Begin();

            _spriteBatch.Draw(space_background, new Vector2(0, 0), Color.White);

            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
