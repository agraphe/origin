using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricObjects
{
  public class Rectangle  
  {
    // --------- Konstruktoren ---------------
    public Rectangle() : this(0, 0, 0, 0) { }

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
    private int _Length;
    public int Length
    {
      get { return _Length; }
      set {
        if (value >= 0)
          _Length = value;
        else
          Console.WriteLine("Unzulässige negative Länge.");
      }
    }

    private int _Width;
    public int Width
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

    public double XCoordinate { get; set; }
    public double YCoordinate { get; set; }

    // ---------- Klasseneigenschaft -----------------
    protected static int _CountRectangles;
    public static int CountRectangles
    {
        get { return _CountRectangles; }
    }

    // ---------- Instanzmethoden ----------
    public double GetArea()
    {
        return Length * Width;
    }

    public double GetCircumference()
    {
        return 2 * (Length + Width);
    }

    public int Bigger(Rectangle rect)
    {
        if (rect == null || GetArea() > rect.GetArea()) return 1;
        if (GetArea() < rect.GetArea()) return -1;
        return 0;
    }

    public void Move(double dx, double dy)
    {
        XCoordinate += dx;
        YCoordinate += dy;
    }

    public void Move(double dx, double dy, int dWidth, int dLength)
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

    public static double GetCircumfence(int length, int width)
    {
        return 2 * (length + width);
    }

    public static int Bigger(Rectangle rect1, Rectangle rect2)
    {
        if (rect1 == null && rect2 == null) return 0;
        if (rect1 == null) return -1;
        if (rect2 == null) return 1;
        if (rect1.GetArea() > rect2.GetArea()) return 1;
        if (rect1.GetArea() < rect2.GetArea()) return -1;
        return 0;
    }
  }
}
