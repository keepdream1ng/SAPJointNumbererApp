using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPJointNumberer
{
    public static class OrdererByCoordinates
    {
        private static int _xCoordinateMultiplier;
        private static int _yCoordinateMultiplier;
        private static int _zCoordinateMultiplier;
        public static int xCoordinateMultiplier
        {
            get => _xCoordinateMultiplier;
            set {  _xCoordinateMultiplier = value * (int)Math.Pow(10, Math.Abs(value)); }
        }
        public static int yCoordinateMultiplier
        {
            get => _yCoordinateMultiplier;
            set {  _yCoordinateMultiplier = value * (int)Math.Pow(10, Math.Abs(value)); }
        }
        public static int zCoordinateMultiplier
        {
            get => _zCoordinateMultiplier;
            set {  _zCoordinateMultiplier = value * (int)Math.Pow(10, Math.Abs(value)); }
        }

        public static List<Point> OrderByCoordinates(this List<Point> pointsList)
        {
            var result = pointsList.OrderBy(p => (p.X * xCoordinateMultiplier) + (p.Y * yCoordinateMultiplier) + (p.Z * zCoordinateMultiplier))
                .ToList();
            return result;
        }
    }
}
