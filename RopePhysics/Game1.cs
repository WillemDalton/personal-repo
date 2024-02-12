using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct2D1.Effects;

namespace RopePhysics
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // creates two players
        private Player player1;
        private Player player2;

        //assets
        private Texture2D playerSprite;

        // playerKeys
        private Keys[] player1Keys;
 
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;        
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 1000; // set this value to the desired width
            _graphics.PreferredBackBufferHeight = 1000;   // set this value to the desired height
            _graphics.ApplyChanges();

            // TODO: Add your initialization logic here
            player1Keys = new Keys[] { Keys.W, Keys.A, Keys.S, Keys.D };

            player1 = new Player(new Vector2(100, 100), playerSprite, player1Keys);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            playerSprite = Content.Load<Texture2D>("smile");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            player1.Update(gameTime);
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(playerSprite, player1.Position,Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}