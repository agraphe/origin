using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricObjects
{
  public class Rectangle : GeometricObject
  {
    // --------- Konstruktoren ---------------
    public Rectangle() { }

    public Rectangle(int length, int width) : this(length, width, 0, 0) { }

    public Rectangle(int length, int width, double x, double y) 
    {
      Length = length;
      Width = width;
      XCoordinate = x;
      YCoordinate = y;
      Rectangle._CountRectangles++;
    }

    // -------- Eigenschaften ----------
    protected int _Length;
    public virtual int Length
    {
      get { return _Length; }
      set {
        if (value >= 0)
          _Length = value;
        else
          Console.WriteLine("Unzulässige negative Länge.");
      }
    }

    protected int _Width;
    public virtual int Width
    {
        get { return _Width; }
        set
        {
            if (value >= 0)
                _Width = value;
            else
                Console.WriteLine("Unzulässige negative Breite.");
        }
    }

    // ---------- Klasseneigenschaft -----------------
    private static int _CountRectangles;
    public static int CountRectangles
    {
        get { return _CountRectangles; }
    }

    // ---------- Instanzmethoden ----------
    public override double GetArea()
    {
        return Length * Width;
    }

    public override double GetCircumference()
    {
        return 2 * (Length + Width);
    }

    public virtual void Move(double dx, double dy, int dWidth, int dLength)
    {
        Move(dx, dy);
        Width += dWidth;
        Length += dLength;
    }

    public override string ToString()
    {
      return "Rectangle, L=" + Length + ",B=" + Width + ",Fläche=" + GetArea();
    }

    // -------- Klassenmethoden ------------
    public static double GetArea(int length, int width)
    {
        return length * width;
    }   

    public static double GetCircumference(int length, int width)
    {
        return 2 * (length + width);
    }
  }
}
