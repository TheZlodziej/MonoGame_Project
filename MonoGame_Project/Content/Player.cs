using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame_Project.Content.Components;

namespace MonoGame_Project.Content
{
    class Player : Drawable
    {
        public Player(Texture2D texture) : base(texture)
        {
            Components.Add<BoxCollider>();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

        public override void Update(GameTime deltaTime)
        {
            KeyboardInput(deltaTime);
            base.Update(deltaTime);
        }
        
        private void KeyboardInput(GameTime deltaTime)
        {
            var transformComponent = Components.GetComponent<Transform>();
            float directionalSpeed = 100f * (float)deltaTime.ElapsedGameTime.TotalSeconds;
            KeyboardState kState = Keyboard.GetState();

            if (kState.IsKeyDown(InputBindings.Instance.MoveLeft))
            {
                transformComponent.Position.X -= directionalSpeed;
            }

            if (kState.IsKeyDown(InputBindings.Instance.MoveRight))
            {
                transformComponent.Position.X += directionalSpeed;
            }

            if (kState.IsKeyDown(InputBindings.Instance.MoveUp))
            {
                transformComponent.Position.Y -= directionalSpeed;
            }

            if (kState.IsKeyDown(InputBindings.Instance.MoveDown))
            {
                transformComponent.Position.Y += directionalSpeed;
            }
        }
    }
}
