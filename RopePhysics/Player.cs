using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RopePhysics
{
    internal struct Player
    {
        private Texture2D asset;

        private Vector2 position;
        private Vector2 velocity;
        private Vector2 direction;

        private int speed;
        private const int maxSpeed = 10;

        private const int acceleration = 1;
        private const int friction = 1;

        public Player(Vector2 position, Texture2D asset)
        {
            this.position = position;
            this.asset = asset;

            // watch out for this, may only be referencing not copying
            velocity = Vector2.Zero;
            direction = Vector2.Zero;

            speed = 0;
        }

        
        
        
    }
}
