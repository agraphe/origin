using System;

namespace GeometricObjects
{
  public class Circle
  {
    // -------- Eigenschaften / Datenelemente ----------
    //          vereinfachte Schreibweise
    //          automatisch "implementierte Eigenschaften", S. 153
    public double XCoordinate { get; set; }
    public double YCoordinate { get; set; }

    //          Eigenschaftsmethode = diese prüft die Eigenschaft des Datenelements
    private int _Radius;
    public int Radius
    {
      get { return _Radius; }
      set {
        if (value >= 0)  // <value> standard-impliziter Parameter
          _Radius = value;
        else
          Console.WriteLine("Unzulässiger negativer Radius.");
      }
    }

    // ---------- Klasseneigenschaft -----------------
    //   - schreibgeschützt: kein <set>
    //     private = kann nicht von außen manipuliert werden
    //     Programmlogik liegt im Konstruktor

    private static int _CountCircles; // = Klassenvariable
    public static int CountCircles
    {
        get { return _CountCircles; }
    }

    // --------- Konstruktoren ---------------
    //
    //  a) erzeugt Kreis, Radius= 0
    //     this = Übergabe an vollständigen Kreis
    //     Zweck ist keine Parameter zu übergeben und das später zu tun.
    public Circle() : this(0, 0, 0)
    { }

    //  b) erzeugt Kreis mit Übergabe Radius
    //     this = Übergabe an vollständigen Kreis
    public Circle(int radius) : this(radius, 0, 0)
    { }

    //  c) Übergabe aller Parameter
    public Circle(int radius, double x, double y)
    {    
        Radius = radius;
        XCoordinate = x;
        YCoordinate = y;
        Circle._CountCircles++;
    }

    // ---------- Instanzmethoden ----------
    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    public int Bigger(Circle kreis)
    {
        if (kreis == null || Radius > kreis.Radius) return 1;
        if (Radius < kreis.Radius) return -1;
        else return 0;
    }

    public void Move(double dx, double dy) // 1. Überladung <Move>
    { 
        XCoordinate += dx;
        YCoordinate += dy;
    }

    public void Move(double dx, double dy, int dRadius)
    {                                      // 2. Überladung <Move>
        Move(dx, dy);
        Radius += dRadius;
    }

//     -------- Klassenmethoden ------------
//  erkennbar an <static>

    public static double GetArea(int radius)
    {
        return Math.Pow(radius, 2) * Math.PI;
    }

    public static double GetCircumference(int radius)
    {
        return 2 * radius * Math.PI;
    }

    public static int Bigger(Circle kreis1, Circle kreis2)
    {
        if (kreis1 == null && kreis2 == null) return 0;
        if (kreis1 == null) return -1;
        if (kreis2 == null) return 1;
        if (kreis1.Radius > kreis2.Radius) return 1;
        if (kreis1.Radius < kreis2.Radius) return -1;
        return 0;
    }
  }
}

//  Klassenmethode wozu?
