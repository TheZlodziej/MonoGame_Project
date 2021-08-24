using Microsoft.Xna.Framework;

namespace MonoGame_Project.Content.Components
{
    class Transform : Component
    {
        public Vector2 Position = Vector2.Zero;
        public Vector2 Origin = Vector2.Zero;
        public Vector2 Scale = Vector2.One;
        public float Rotation = 0f;
        public Transform() : base() { }
    }
}
