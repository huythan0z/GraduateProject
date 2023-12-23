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
        public int Level;
        public double width;
        public double height;
    }
    public static class DataMaterial
    {
        
    }
    public class Concrete
    {
        public ConcreteType concreteType;
        public float Rb = 0;
        public float Rbt = 0;
        public float Eb = 0;
    }

    public class Steel
    {
        public SteelType steelType;
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
}
