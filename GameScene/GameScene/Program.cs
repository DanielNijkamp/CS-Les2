using System;

namespace GameScene
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }
        
    }
    class GameScene
    {
        public void StartGameScene()
        {
            SceneRenderer newRenderer = new SceneRenderer();
            SceneLogic newSceneLogic = new SceneLogic();
        }
        public void DoFrame(float frametime)
        {
            
        }
        
    }
    class SceneRenderer
    {

    }
    class SceneLogic
    {

    }
}
