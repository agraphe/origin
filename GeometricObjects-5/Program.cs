using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometricObjects
{
  class Program
  {
    static void Main(string[] args)
    {
        // Testen der Objektzähler
        Console.WriteLine("TEST DER OBJEKTZÄHLER");
        Console.WriteLine("----------------------------------");
        Rectangle rect1 = new Rectangle();
        Rectangle rect2 = new Rectangle();
        Rectangle rect3 = new Rectangle();
        Circle kreis1 = new Circle();
        Circle kreis2 = new Circle();
        rect1.Dispose();
        rect2.Dispose();
        kreis1.Dispose();
        Circle kreis3 = new Circle();
        Console.WriteLine("Alle Objekte: {0}", GeometricObject.CountGeometricObjects);
        Console.WriteLine("Alle Rectangle: {0}", Rectangle.CountRectangles);
        Console.WriteLine("Alle kreise: {0}", Circle.CountCircles);

        Console.WriteLine("\nTEST DER METHODE ARRAY.SORT");
        Console.WriteLine("----------------------------------");
        GeometricObject[] liste = new GeometricObject[5];
        liste[0] = new Circle(88);
        liste[1] = new Rectangle(12, 90);
        liste[2] = new GraphicCircle(50);
        liste[3] = new Rectangle(10, 96);
        liste[4] = new GraphicRectangle(3, 6);

        Array.Sort(liste);
        foreach (GeometricObject item in liste)
            Console.WriteLine(item.ToString());
      Console.ReadLine();
    }
  }
}
