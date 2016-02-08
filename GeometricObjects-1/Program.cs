using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricObjects
{
  class Program
  {
    static void Main(string[] args)
    {
      Circle kreis1 = new Circle(10);
      Circle kreis2 = new Circle(15, -140, 440);
      // Allgemeine Daten ausgeben
      Console.WriteLine("Allgemeine Daten:");
      Console.WriteLine(new string('=', 17)); // 17x <=>
      Console.WriteLine("kreis1 - Radius:      {0}", kreis1.Radius);
      Console.WriteLine("       - XKoordinate: {0}", kreis1.XCoordinate);
      Console.WriteLine("       - YKoordinate: {0}", kreis1.YCoordinate);
      Console.WriteLine();
      Console.WriteLine("kreis2 - Radius:      {0}", kreis2.Radius);
      Console.WriteLine("       - XKoordinate: {0}", kreis2.XCoordinate);
      Console.WriteLine("       - YKoordinate: {0}", kreis2.YCoordinate);
      Console.WriteLine();

      // Anzahl der Circle-Objekte ausgeben
      Console.WriteLine("Anzahl 'Circle'-Objekte: {0}", Circle.CountCircles);
      Console.WriteLine();

      // Test: Fläche und Umfang
      Console.WriteLine("Fläche und Umfang des Objekts 'kreis1'");
      Console.WriteLine(new string('-', 40));
      Console.WriteLine("Fläche kreis1: {0}", kreis1.GetArea());
      Console.WriteLine("Umfang kreis1: {0}", kreis1.GetCircumference());
      Console.WriteLine();

      // Test: Verschiebung kreis1
      Console.WriteLine("Verschiebung des Objekts 'kreis1' um dx=150 / dy=400");
      Console.WriteLine(new string('-', 40));
      Console.WriteLine("X (alt): {0} / Y (alt): {1}", kreis1.XCoordinate, kreis1.YCoordinate);
      kreis1.Move(150, 400);
      Console.WriteLine("X (neu): {0} / Y (neu): {1}", kreis1.XCoordinate, kreis1.YCoordinate);
      Console.WriteLine();

      // Test: Größenvergleich
      if (kreis1.Bigger(kreis2) == 1)
          Console.WriteLine("Objekt 'kreis1' ist größer als Objekt 'kreis2'");
      else if (kreis1.Bigger(kreis2) == 0)
        Console.WriteLine("Objekt 'kreis1' ist gleich Objekt 'kreis2'");
      else
        Console.WriteLine("Objekt 'kreis1' ist kleiner Objekt 'kreis2'");

      Console.ReadLine();
    }
  }

}
