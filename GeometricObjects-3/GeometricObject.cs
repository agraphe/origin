using System;

namespace GeometricObjects
{
    public abstract class GeometricObject
    {
        // Statische Eigenschaft
        private static int _CountGeometricObjects;
        public static int CountGeometricObjects
        {
            get { return _CountGeometricObjects; }
        }

        // Konstruktor
        protected GeometricObject()
        {
            _CountGeometricObjects++;
        }

        // Eigenschaften
        public virtual double XCoordinate { get; set; }
        public virtual double YCoordinate { get; set; }

        // Abstrakte Methoden
        public abstract double GetArea();
        public abstract double GetCircumference();

        // Instanzmethoden
        // Die virtuelle Methode ist allgemein formuliert und gilt daher
        // sowohl für die Klasse <Circle> wie <Rectangle>
        public virtual int Bigger(GeometricObject @object)
        {
            if (@object == null || GetArea() > @object.GetArea()) return 1;
            if (GetArea() < @object.GetArea()) return -1;
            return 0;
        }

        public virtual void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }


        // Klassenmethode
        //     return  1 wenn Objekt 1 größer ist
        //     return -1 wenn Objekt 2 größer ist
        public static int Bigger2(GeometricObject object1, GeometricObject object2)
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
