using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateProject
{
    public static class DataMaterial
    {
        
    }
    public class Concrete
    {
        public ConcreteType concreteType;
        public float Rb;
        public float Rbt;
        public float Eb;
    }

    public class Steel
    {
        public SteelType steelType;
        public List<float> Rs = new List<float> {5,10,15, 20};
        public float Rsc;
        public float Es;
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
