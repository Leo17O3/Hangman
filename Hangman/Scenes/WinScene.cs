using System;
using System.Collections.Generic;

namespace Hangman
{
    class WinScene : Scene
    {
        private Renderer _renderer;

        public override void Start(Renderer renderer, string word = null)
        {
            _renderer = renderer;

            GameObjectsInScene = new List<GameObject>();
            GameObjectsInScene.Add(new GameObject(word, new Vector2(Console.WindowWidth / 4, 0)));
            base.Start(renderer, word);

            InputReader.GetInput(1);
            ChangeScene();
        }

        public override void ChangeScene()
        {
            new GetSecretWordScene().Start(_renderer, null);
        }
    }
}
