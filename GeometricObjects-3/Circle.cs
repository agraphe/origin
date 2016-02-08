using System;

namespace GeometricObjects
{
    public class Circle : GeometricObject
    {
        // -------- Eigenschaft ----------
        protected int _Radius;
        public virtual int Radius
        {
            get { return _Radius; }
            set
            {
                if (value >= 0)
                    _Radius = value;
                else
                    Console.WriteLine("Unzulässiger negativer Radius.");
            }
        }

        // ---------- Klasseneigenschaft -----------------
        private static int _CountCircles;
        public static int CountCircles
        {
            get { return _CountCircles; }
        }

        // --------- Konstruktoren ---------------
        public Circle() : this(0, 0, 0) { }

        public Circle(int radius) : this(radius, 0, 0) { }

        public Circle(int radius, double x, double y)
        {
            Radius = radius;
            XCoordinate = x;
            YCoordinate = y;
            Circle._CountCircles++;
        }

        // ---------- Instanzmethoden ----------
        public override double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override double GetCircumference()
        {
            return 2 * Radius * Math.PI;
        }

        public virtual void Move(double dx, double dy, int dRadius)
        {
            Move(dx, dy);
            Radius += dRadius;
        }

        public override string ToString()
        {
            return "Circle, R=" + Radius + ",Fläche=" + GetArea();
        }

        // -------- Klassenmethoden ------------
        public static double GetArea(int radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public static double GetCircumference(int radius)
        {
            return 2 * radius * Math.PI;
        }
    }
}
