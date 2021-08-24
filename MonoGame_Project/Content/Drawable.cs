using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame_Project.Content.Components;

namespace MonoGame_Project.Content
{
    abstract class Drawable : GameObject
    {
        public readonly Texture2D Texture;
        public Color Color { get; set; } = Color.White;
        public Drawable(Texture2D texture) : base() => Texture = texture;

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            var transformComponent = Components.GetComponent<Transform>();
            spriteBatch.Draw(
                Texture,
                transformComponent.Position,
                null,
                Color,
                transformComponent.Rotation,
                transformComponent.Origin,
                transformComponent.Scale,
                SpriteEffects.None,
                0f
            );
        }
        public virtual void Update(GameTime deltaTime)
        {
            
        }
    }
}
