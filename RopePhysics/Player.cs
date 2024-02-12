using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RopePhysics
{
    internal struct Player
    {
        private Texture2D asset;

        private Vector2 position;
        private Vector2 velocity;
        private Vector2 direction;
        private Keys[] movementKeys; // GOES UP, LEFT, DOWN, RIGHT (WASD!)

        private int speed;
        private const int maxSpeed = 10;

        private const int acceleration = 1;
        private const int friction = 1;

        public Player(Vector2 position, Texture2D asset, Keys[] movementKeys)
        {
            this.position = position;
            this.asset = asset;
            this.movementKeys = movementKeys;

            // watch out for this, may only be referencing not copying
            velocity = Vector2.Zero;
            direction = new Vector2(1,1);
            speed = 1;
        }

        public Vector2 Position
        {
            get { return position; }
        }



        public void Update(GameTime gameTime) 
        {
            KeyboardState kbState = Keyboard.GetState();

            if (kbState.IsKeyDown(movementKeys[0]))
            {
                direction.Y = -1;
                speed += acceleration;
            }
            if (kbState.IsKeyDown(movementKeys[1]))
            {
                direction.X = -1;
                speed += acceleration;
            }
            if (kbState.IsKeyDown(movementKeys[2]))
            {
                direction.Y = 1;
                speed += acceleration;
            }
            if (kbState.IsKeyDown(movementKeys[3]))
            {
                direction.X = 1;
                speed += acceleration;
            }            

            direction.Normalize();
            speed -= friction;

            velocity = speed * direction;

            position += velocity;
        }
    }
}
