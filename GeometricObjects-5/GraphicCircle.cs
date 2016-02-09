using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricObjects
{
    public class GraphicCircle : Circle, IDraw
    {
        // Konstruktoren
        public GraphicCircle() { }
        public GraphicCircle(int radius) : base(radius) { }
        public GraphicCircle(int radius, double x, double y) : base(radius, x, y) { }

        // Typspezifische Methode
        public virtual void Draw()
        {
            Console.WriteLine("Der Kreis wird gezeichnet");
        }
    }
}
