using Microsoft.Xna.Framework;
using System;
using System.Diagnostics;

namespace MonoGame_Project.Content.Components
{
    class BoxCollider : Component
    {
        public Rectangle Hitbox;
        public BoxCollider() : base() 
        {
            
        }
        protected override void OnOwnerSet()
        {
            Hitbox = Owner is Drawable drawable ? drawable.Texture.Bounds : new Rectangle();
        }
    }
}
