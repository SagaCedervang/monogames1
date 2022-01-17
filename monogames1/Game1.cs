using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogames1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        SpriteBatch spriteBatch;
        Texture2D parrotBild, duck_outline_yellowBild;
        
        //Vector2 parrotPosition = new Vector2(100, 200);
        Vector2 duck_outline_yellowPosition = new Vector2(300, 100);

        //Vector2 duck_outline_yellowHastighet = new Vector2(2, 1);

        MouseState mus;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            IsMouseVisible = true;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            spriteBatch = new SpriteBatch(GraphicsDevice);
            //parrotBild = Content.Load<Texture2D>("parrot");
            duck_outline_yellowBild = Content.Load<Texture2D>("duck_outline_yellow");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {

            mus = Mouse.GetState();

            duck_outline_yellowPosition.X = mus.X;
            duck_outline_yellowPosition.Y = mus.Y;
            /*
            duck_outline_yellowPosition += duck_outline_yellowHastighet;
            if (duck_outline_yellowPosition.X > 300 || duck_outline_yellowPosition.X < 0)
            {
                duck_outline_yellowHastighet *= -1;
            }
            */

            


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            //spriteBatch.Draw(parrotBild, parrotPosition, Color.White);
            spriteBatch.Draw(duck_outline_yellowBild, duck_outline_yellowPosition, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
