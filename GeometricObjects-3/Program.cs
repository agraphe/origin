using System;
using System.Collections;
using System.Linq;
using System.Text;

//         Classes
//                                  GeometricObjects
//                                   |            |
//                               Circles      Rectangles
//                                   |            |
//                         GraphicCircles    GraphicRectangles

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
            Console.WriteLine(new string('=', 17)); // zeichnet Linie
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

            // Test: Fläche und Umfang ==  kreis2
            Console.WriteLine("Fläche und Umfang des Objekts 'kreis2'");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Fläche kreis2: {0}", kreis2.GetArea());
            Console.WriteLine("Umfang kreis2: {0}", kreis2.GetCircumference());
            Console.WriteLine();

            
            // Test: Verschiebung kreis1
            Console.WriteLine("Verschiebung des Objekts 'kreis1' um dx=150 / dy=400");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("X (alt): {0} / Y (alt): {1}", kreis1.XCoordinate, kreis1.YCoordinate);
            kreis1.Move(150, 400);
            Console.WriteLine("X (neu): {0} / Y (neu): {1}", kreis1.XCoordinate, kreis1.YCoordinate);
            Console.WriteLine();

            // Test: Verschiebung kreis1 zum 2. Mal
            Console.WriteLine("Verschiebung des Objekts 'kreis1' zzum 2. Mal um dx=350 / dy=600");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("X (alt): {0} / Y (alt): {1}", kreis1.XCoordinate, kreis1.YCoordinate);
            kreis1.Move(350, 600);
            Console.WriteLine("X (neu): {0} / Y (neu): {1}", kreis1.XCoordinate, kreis1.YCoordinate);
            Console.WriteLine();


            // Test: Größenvergleich
            if (kreis1.Bigger(kreis2) == 1)
                Console.WriteLine("Objekt 'kreis1' ist größer als Objekt 'kreis2'");
            else if (kreis1.Bigger(kreis2) == 0)
                Console.WriteLine("Objekt 'kreis1' ist gleich Objekt 'kreis2'");
            else
                Console.WriteLine("Objekt 'kreis1' ist kleiner Objekt 'kreis2'");

            Console.WriteLine();

            // Test Anzahl Kreisobjekte (Listung 4.3)
            GraphicCircle gc = new GraphicCircle();
            Console.WriteLine("Anzahl 'Circle'-Objekte mit zusätzlich GraphicCircle: {0}", Circle.CountCircles);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("============ Rectangles ===============================");
            Console.WriteLine();
            
            Rectangle rect1 = new Rectangle(10, 200);
            Rectangle rect2 = new Rectangle(50, 400, 5, -100);

            // Daten von Rect1
            Console.WriteLine("Allgemeine Daten Rectangles:");
            Console.WriteLine(new string('-', 28)); // zeichnet Linie
            Console.WriteLine("Rect1 - Length:       {0}", rect1.Length);
            Console.WriteLine("..... - Width:        {0}", rect1.Width);
            Console.WriteLine("      - XKoordinate: {0}", rect1.XCoordinate);
            Console.WriteLine("      - YKoordinate: {0}", rect1.YCoordinate);
            Console.WriteLine();

            // Test: Fläche und Umfang
            Console.WriteLine("Fläche und Umfang des Objekts 'rect1'");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Fläche rect1: {0}", rect1.GetArea());
            Console.WriteLine("Umfang rect1: {0}", rect1.GetCircumference());
            Console.WriteLine();


            // Daten von Rect2
            Console.WriteLine("Rect2 - Length and Width:       {0} and {1}", rect2.Length, rect2.Width);
            Console.WriteLine("      - XKoordinate and YKoordinate:  {0}, {1}", rect2.XCoordinate, rect2.YCoordinate);
            Console.WriteLine();

            // Test: Fläche und Umfang
            Console.WriteLine("Fläche und Umfang des Objekts 'rect2'");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Fläche rect2: {0}", rect2.GetArea());
            Console.WriteLine("Umfang rect2: {0}", rect2.GetCircumference());
            Console.WriteLine();

            // Test: Verschiebung Rect1
            Console.WriteLine("Verschiebung des Objekts 'Rect1' um dx=150 / dy=400");
            Console.WriteLine(new string('-', 51));
            Console.WriteLine("X (alt): {0} / Y (alt): {1}", rect1.XCoordinate, rect1.YCoordinate);
            rect1.Move(150, 400);
            Console.WriteLine("X (neu): {0} / Y (neu): {1}", rect1.XCoordinate, rect1.YCoordinate);
            Console.WriteLine();

            // Anzahl der Rectangle-Objekte ausgeben
            Console.WriteLine("Anzahl 'Rectangle-'-Objekte: {0}", Rectangle.CountRectangles);
            Console.WriteLine();


// ======== Rectangles und Kreise der Größe nach vergleichen

            Console.WriteLine("Vergleich kreis1, rect1 ergibt:  {0}", GeometricObject.Bigger2(kreis1, rect1));
            Console.WriteLine();
            Console.WriteLine("Vergleich kreis2, kreis1 ergibt: {0}", GeometricObject.Bigger2(kreis2, kreis1));

            //
            Console.ReadLine();
        }
    }

}

