using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPJointNumberer
{
    public static class OrdererByCoordinates
    {
        public static int xCoordinateMultiplier { get; set; }
        public static int yCoordinateMultiplier { get; set; }
        public static int zCoordinateMultiplier { get; set; }

        public static List<Point> OrderByCoordinates(this List<Point> pointsList)
        {
            var result = pointsList.OrderBy(p => (p.X * xCoordinateMultiplier) + (p.Y * yCoordinateMultiplier) + (p.Z * zCoordinateMultiplier))
                .ToList();
            return result;
        }
    }
}
