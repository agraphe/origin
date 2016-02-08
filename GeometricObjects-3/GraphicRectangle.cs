using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricObjects
{
    public class GraphicRectangle : Rectangle
    {
        // --------- Konstruktoren ---------------
        public GraphicRectangle() : base(0, 0, 0, 0) { }
        public GraphicRectangle(int length, int width) : base(length, width, 0, 0) { }
        public GraphicRectangle(int length, int width, double x, double y) : base(length, width, x, y) { }

        // Typspezifische Methode
        public virtual void Draw()
        {
            Console.WriteLine("Das Rechteck wird gezeichnet");
        }
    }

}
