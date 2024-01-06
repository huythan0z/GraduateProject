using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateProject
{
    static class MathHelper
    {
        public static XYZ ConvertPoint(XYZ point)
        {
            double x, y, z;
            x = point.X; 
            y = point.Y;
            z = point.Z;
            x = ConvertFeetToMili(x);
            y = ConvertFeetToMili(y);
            z = ConvertFeetToMili(z);
            point = new XYZ(x, y, z);
            return point;
        }

        public static double ConvertFeetToMili(double value)
        {
            value = Math.Round(UnitUtils.Convert(value, DisplayUnitType.DUT_DECIMAL_FEET,
                            DisplayUnitType.DUT_MILLIMETERS), 2);
            return value;
        }
    }
}
