using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricObjects
{
  public class Rectangle : GeometricObject, IDisposable
  {
    // ---------- Felder -------------
    protected int _Length;
    protected int _Width;
    private bool disposed;

    // --------- Statisches Feld -----------
    protected static int _CountRectangles;

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

    // -------- Eigenschaftsmethoden ----------
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

   // Finalisierung
    public void Dispose()
    {
      if (!disposed)
      {
        Rectangle._CountRectangles--;
        GeometricObject._CountGeometricObjects--;
        GC.SuppressFinalize(this);
        disposed = true;
      }
    }

    // Destruktor
    ~Rectangle()
    {
      Dispose();
    }
  }
}
