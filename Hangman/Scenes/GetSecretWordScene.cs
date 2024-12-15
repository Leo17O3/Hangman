using System;
using System.Collections.Generic;

namespace Hangman
{
    class GetSecretWordScene : Scene
    {
        private readonly GameObject _helloText = new GameObject("Добро пожаловать в игру 'Виселица'!",
            new Vector2(Math.Abs(Console.WindowWidth / 2 - "Добро пожаловать в игру 'Виселица'!".Length / 2), 0));
        private readonly GameObject _pleaseWriteSecretWord = new GameObject("Введите слово, которое хотите загадать:", new Vector2(0, 1));
        private readonly GameScene _nextScene = new GameScene();
        private Renderer _renderer;
        private string _word;

        public override void Start(Renderer renderer, string word)
        {
            GameObjectsInScene = new List<GameObject>() { _helloText, _pleaseWriteSecretWord };
            base.Start(renderer);

            string input = InputReader.GetInput();

            _renderer = renderer;
            _word = input;

            ChangeScene();
        }

        public override void ChangeScene()
        {
            _nextScene.Start(_renderer, _word);
        }
    }
}
