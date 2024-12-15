using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class GameScene : Scene
    {
        private readonly DiedPerson _diedPerson = new DiedPerson();
        private readonly GameObject _uncorrectText = new GameObject("Неправильно введённые буквы:", new Vector2(0, 7));
        private List<char> _uncorrectLetters = new List<char>(4);
        private int _attempts = 0;
        private readonly WinScene _nextScene = new WinScene();
        private string _resultText;
        private Renderer _renderer;

        public override void Start(Renderer renderer, string word)
        {
            _renderer = renderer;
            GameObjectsInScene = new List<GameObject>();
            List<GameObject> diedPersonParts = _diedPerson.GetDiedPersonParts();

            for (int i = 0; i < word.Length; i++)
            {
                GameObjectsInScene.Add(new GameObject("_ ", new Vector2(i, 0)));
            }

            base.Start(renderer);
            for (; _uncorrectLetters.Count < 5; )
            {
                string input = InputReader.GetInput(1);
                ++_attempts;

                if (word.Contains(input))
                {

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (input == null) break;
                        if (word[i] == input.ToCharArray()[0])
                            renderer.AddGameObjectForRendering(new GameObject(input, GameObjectsInScene[i].Position));
                    }

                    if (!renderer.IsGameObjectsForRenderingContainsGameObjectWithValue("_ "))
                    {
                        _resultText = $"Поздравляем с победой! Вы отгадали слово за столько ходов: {_attempts}\nДля продолжения нажмите любую клавишу...";
                        ChangeScene();
                    }
                }
                else if (!_uncorrectLetters.Contains(input.ToCharArray()[0]))
                {
                    _uncorrectLetters.Add(input.ToCharArray()[0]);

                    if (_uncorrectLetters.Count == 1)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            GameObjectsInScene.Add(diedPersonParts[i]);
                            renderer.AddGameObjectForRendering(diedPersonParts[i]);
                        }
                    }
                    else
                    {
                        GameObjectsInScene.Add(diedPersonParts[_uncorrectLetters.Count + 6]);
                        renderer.AddGameObjectForRendering(diedPersonParts[_uncorrectLetters.Count + 6]);
                    }

                    StringBuilder uncorrectLettersText = new StringBuilder(_uncorrectText.Value + "\n");

                    for (int i = 0; i < _uncorrectLetters.Count; i++)
                    {
                        uncorrectLettersText.Append($"{_uncorrectLetters[i]} ");
                    }

                    renderer.AddGameObjectForRendering(new GameObject(uncorrectLettersText.ToString(), _uncorrectText.Position));
                }

                renderer.Render();
            }

            _resultText = $"Сожалеем, Вы проиграли! Надеемся, в следующий раз у Вас всё получится!\nДля продолжения нажмите любую клавишу...";
            ChangeScene();
        }

        public override void ChangeScene()
        {
            new WinScene().Start(_renderer, _resultText);
        }
    }
}
