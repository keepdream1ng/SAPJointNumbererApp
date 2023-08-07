using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP2000v1;

namespace SAPJointNumberer
{
    public static class PointManager
    {
        public static string pointPrefix { get; set; } = string.Empty;
        public static int pointStartNumber { get; set; } = 1;

        public static void RenameSelectedPointsByCoordinates()
        {
            List<Point> pointList = GetSelectedPointsList();
            RenamePointInCoordsOrder(pointList);
        }

        public static string[] GetSelectedPointsNames()
        {
            int objNum = 0;
            int[] objectTypes = null;
            string[] objNames = null;
            if ((SAP.Model.SelectObj.GetSelected(ref objNum, ref objectTypes, ref objNames) != 0) ||
                (objNum == 0))
            {
                return null;
            }
            int pointNum = objectTypes.Where(x => x == 1).Count();
            if (pointNum == objNum)
            {
                return objNames;
            }
            // Some other objects rathen then points are selected, so we filter points with objectType 1.
            string[] pointNames = new string[pointNum];
            for (int i = 0; i < objNum; i++)
            {
                if (objectTypes[i] == 1)
                {
                    pointNames[--pointNum] = objNames[i];
                }
            }
            return pointNames;
        }
        public static List<Point> GetSelectedPointsList()
        {
            string[] pointNames = GetSelectedPointsNames();
            if (pointNames is null) { return null; }
            List<Point> pointList = pointNames.Select(name => new Point(name)).ToList();
            return pointList;
        }

        public static void RenamePointInCoordsOrder(List<Point> pointsList)
        {
            var result = pointsList.OrderByCoordinates()
                .Select(p => p.Name)
                .ToArray();
            RenamePointsWithNames(result);
        }

        public static void RenamePointsWithNames(string[] pointNames)
        {
            if (pointNames is null) { return; }
            int result = 0;
            int startNum = pointStartNumber;
            // Check for same names as needed in the selection, to avoid overlaping.
            string[] overlapingNames = pointNames.Select((str, index) => $"{pointPrefix}{index}").Intersect(pointNames).ToArray();
            if (overlapingNames.Length > 0)
            {
                string tempName;
                foreach (string name in overlapingNames)
                {
                    // Giving temporary name to the overlaping points.
                    tempName = Guid.NewGuid().ToString();
                    SAP.Model.PointObj.ChangeName(name, tempName);
                    pointNames[Array.IndexOf(pointNames, name)] = tempName;
                }
            }

            for (int i = 0; i < pointNames.Length; i++)
            {
                result = SAP.Model.PointObj.ChangeName(pointNames[i], $"{pointPrefix}{startNum}");
                if (result != 0)
                {
                    // Renaming failed probably because same name exists outside of selection, so we keep renaming with a postfix till it works.
                    int j = 1;
                    while (SAP.Model.PointObj.ChangeName(pointNames[i], $"{pointPrefix}{startNum}_{j++}") != 0) { }
                }
                startNum++;
            }
        }
    }
}
