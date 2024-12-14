using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
