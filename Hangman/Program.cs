﻿namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            GetSecretWordScene getSecretWordScene = new GetSecretWordScene();
            getSecretWordScene.Start(renderer, new Scene[] { new GetSecretWordScene(), new GameScene(), new WinScene() }, 0, null);
        }
    }
}
