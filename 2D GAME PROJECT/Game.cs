// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Hello Mohawk Game 2D!");
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            //clear background
            Window.ClearBackground(Color.Black);
            //draw a rectangle
            Draw.FillColor = Color.Black;
            Draw.LineColor = Color.Red;
            Draw.LineSize = 5;


            Vector2 rectanglePosition = new Vector2(300, 100);
            Vector2 rectangleSize = new Vector2(250, 100);

            //vector2 rectanglePosition - newVector2(300, 200);
            
            Draw.Rectangle(Input.GetMousePosition() - rectangleSize/ 2, rectangleSize);


        }
    }

}


