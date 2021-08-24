using MonoGame_Project.Content.Components;

namespace MonoGame_Project.Content
{
    abstract class GameObject
    {
        public ObjectComponents Components;

        public GameObject()
        {
            Components = new ObjectComponents(this);
        }
    }
}
