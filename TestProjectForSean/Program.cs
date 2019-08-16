using System;
using System.Collections.Generic;
using BusinessPackage;

namespace TestProjectForSean {
    class Program {
        static void Main(string[] args) {
            var ball = new Ball();

            Console.Write("Enter color: ");
            var color = Console.ReadLine();
            Console.Write("Enter size: ");
            var size = Console.ReadLine();
            var ball1 = new Ball() { Color = color, Size = size };
            var ball2 = new Ball("Red", "Lrg");
            Ball[] balls = new Ball[3];
            balls[0] = ball;

            List<Ball> balls2 = new List<Ball>();
            balls2.Add(ball1); 
        }
    }
}
