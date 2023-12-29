using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateProject
{

    public class FrameData
    {
        public int Id;
        public string Level;
        public double width;
        public double height;
    }
    public static class DataMaterial
    {
        
    }
    public class Concrete
    {
        public ConcreteType type = ConcreteType.B10;
        public float Rb = 0;
        public float Rbt = 0;
        public float Eb = 0;
    }

    public class Steel
    {
        public SteelType type = SteelType.CB300V;
        public float Rs = 0;
        public float Rsc = 0;
        public float Es = 0;
    }
    public enum ConcreteType
    {
        B10,
        B15,
        B20,
        B25,
    }
    public enum SteelType
    {
        CB300V,
        CB400V,
    }
    public class StructureData
    {
        public int ID;
        public int Level;
        public double MomenEdge;
        public int QuantityEdge;
        public int RadiusEdge;
        public double AsEdgeSelect;
        public double AsEdge;
        public double MomenCenter;
        public int QuantityCenter;
        public int RadiusCenter;
        public double AsCenterSelect;
        public double AsCenter;
    }
}
