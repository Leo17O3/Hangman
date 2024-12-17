using System;
using System.Collections.Generic;

namespace Hangman
{
    class WinScene : Scene
    {
        private Renderer _renderer;

        public override void Start(Renderer renderer, Scene[] scenes, int index, string word = null)
        {
            _renderer = renderer;

            GameObjectsInScene = new List<GameObject>();
            GameObjectsInScene.Add(new GameObject(word, new Vector2(Console.WindowWidth / 4, 0)));
            base.Start(renderer, scenes, index, word);

            Console.ReadKey();
            ChangeScene(scenes, index);
        }

        public override void ChangeScene(Scene[] scenes, int index)
        {
            scenes[0].Start(_renderer, scenes, 0, null);
        }
    }
}
