namespace Hangman
{
    class GameObject
    {
        public readonly string Value;
        public readonly Vector2 Position;

        public GameObject(string value, Vector2 position)
        {
            Value = value;
            Position = position;
        }
    }
}
