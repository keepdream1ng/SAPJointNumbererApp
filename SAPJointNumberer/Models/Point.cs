using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPJointNumberer
{
    /// <summary>
    /// Model of SAP joint (point) object.
    /// </summary>
    public class Point
    {
        public string Name {  get; private set; }
        public double X {  get; private set; }
        public double Y {  get; private set; }
        public double Z {  get; private set; }

        public Point(string name)
        {
            Name = name;
            GetCoordinates();
        }

        private void GetCoordinates()
        {
            double xCoords = 0;
            double yCoords = 0;
            double zCoords = 0;
            if (SAP.Model.PointObj.GetCoordCartesian(Name, ref xCoords, ref yCoords, ref zCoords) == 0)
            {
                X = xCoords;
                Y = yCoords;
                Z = zCoords;
            }
        }

        public bool RenameTo(string newName)
        {
            if (SAP.Model.PointObj.ChangeName(Name, newName) == 0)
            {
                Name = newName;
                return true;
            } else
            {
                return false;
            }
        }
    }
}
