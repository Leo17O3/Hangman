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
    }
}
