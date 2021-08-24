using Microsoft.Xna.Framework.Input;

namespace MonoGame_Project.Content
{
    class InputBindings
    {
        public static InputBindings Instance { get; } = new InputBindings();
        public Keys MoveRight { get; set; } = Keys.D;
        public Keys MoveLeft { get; set; } = Keys.A;
        public Keys MoveUp { get; set; } = Keys.W;
        public Keys MoveDown { get; set; } = Keys.S;
    }
}
