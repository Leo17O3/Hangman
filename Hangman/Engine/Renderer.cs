using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class Renderer
    {
        private string[,] _sceneMatrix = new string[Console.WindowWidth, Console.WindowHeight];
        private int _maxRenderX = 0;
        private int _maxRenderY = 0;

        public void Render()
        {
            Console.Clear();

            StringBuilder stringBuilder = new StringBuilder();

            for (int y = 0; y < _maxRenderY + 1; y++)
            {
                for (int x = 0; x < _maxRenderX + 1; x++)
                {
                    stringBuilder.Append(_sceneMatrix[x, y] != null ? _sceneMatrix[x, y] : " ");
                }


                stringBuilder.Append("\n");
            }

            Console.WriteLine(stringBuilder);
        }

        public void AddGameObjectForRendering(GameObject gameObject)
        {
            _sceneMatrix[gameObject.Position.x, gameObject.Position.y] = gameObject.Value;

            if (gameObject.Position.x > _maxRenderX) _maxRenderX = gameObject.Position.x;
            if (gameObject.Position.y > _maxRenderY) _maxRenderY = gameObject.Position.y;
        }

        public void AddGameObjectsForRendering(List<GameObject> gameObjects)
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                AddGameObjectForRendering(gameObjects[i]);
            }
        }

        public void Reset()
        {
            _sceneMatrix = new string[Console.WindowWidth, Console.WindowHeight];
            _maxRenderX = 0;
            _maxRenderY = 0;
        }

        public bool IsGameObjectsForRenderingContainsGameObjectWithValue(string value)
        {
            for (int y = 0; y < _sceneMatrix.GetLength(1); y++)
            {
                for (int x = 0; x < _sceneMatrix.GetLength(0); x++)
                {
                    if (_sceneMatrix[x, y] == value) return true;
                }
            }

            return false;
        }
    }
}
