using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace SharkFramework.Core
{
    public class Game
    {
        public Game()
        {
            var window = new RenderWindow(new VideoMode(800, 600), "Teste");

            var square = new RectangleShape(new Vector2f(32, 32));
            square.Position = new Vector2f(window.GetViewport(window.GetView()).Width / 2,
                window.GetViewport(window.GetView()).Height / 2);

            window.Closed += (sender, args) => window.Close(); 
            
            
            while (window.IsOpen)
            {
                window.DispatchEvents();
                
                window.Clear(Color.Black);
                window.Draw(square);
                window.Display();
            }

            window.Close();
        }
    }
}