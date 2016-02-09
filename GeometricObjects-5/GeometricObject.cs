using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometricObjects
{
  public abstract class GeometricObject : IComparable
  {
    // Statisches Feld
    protected static int _CountGeometricObjects;

    public static int CountGeometricObjects
    {
      get { return _CountGeometricObjects; }
    }

    // Konstruktor
    protected GeometricObject()
    {
      GeometricObject._CountGeometricObjects++;
    }

    // Eigenschaften
    public virtual double XCoordinate { get; set; }
    public virtual double YCoordinate { get; set; }

    // Abstrakte Methoden
    public abstract double GetArea();
    public abstract double GetCircumference();

    // Instanzmethoden
    public virtual int CompareTo(Object @object)
    {
      GeometricObject geoObject = @object as GeometricObject;
      if (geoObject != null)
      {
        if (GetArea() < geoObject.GetArea()) return -1;
        if (GetArea() == geoObject.GetArea()) return 0;
        return 1;
      }
      throw new ArgumentException("Ungültige Objektübergabe. Es wird der Typ 'GeometricObject' erwartet.");
    }

    public virtual void Move(double dx, double dy)
    {
      XCoordinate += dx;
      YCoordinate += dy;
    }

    // Klassenmethode
    public static int Bigger(GeometricObject object1, GeometricObject object2)
    {
        if (object1 == null || object2 == null) return 0;
        if (object1 == null) return -1;
        if (object2 == null) return 1;
        if (object1.GetArea() > object2.GetArea()) return 1;
        if (object1.GetArea() < object2.GetArea()) return -1;
        return 0;
    }
  }
}    
