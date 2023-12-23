using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduateProject
{
    public class Singleton
    {
        private static Singleton instance;
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public List<Concrete> ConcreteDatas = new List<Concrete>();
        public List<Steel> SteelDatas = new List<Steel>();
        public void AddMaterialToData(Concrete concrete, Steel steel)
        {
            var newConcrete = ConcreteDatas.Find(x => x.concreteType == concrete.concreteType);
            if (newConcrete == null) 
            {
                ConcreteDatas.Add(concrete);
            }
            else
            {
                for (int i = 0; i < ConcreteDatas.Count; i++)
                {
                    if (concrete.concreteType == ConcreteDatas[i].concreteType)
                    {
                        ConcreteDatas[i] = concrete;
                    }
                }
            }
           
            var newSteel = SteelDatas.Find(x => x.steelType == steel.steelType);
            if (steel == null)
            {
                SteelDatas.Add(steel);
            }
            else
            {
                for (int i = 0; i < SteelDatas.Count; i++)
                {
                    if (steel.steelType == SteelDatas[i].steelType)
                    {
                        SteelDatas[i] = steel;
                    }
                }
            }
        }
        public Concrete GetConcreteByType(ConcreteType type)
        {
            for (int i = 0; i < ConcreteDatas.Count; i++)
            {
                if (type == ConcreteDatas[i].concreteType)
                {
                    return ConcreteDatas[i];
                }
            }
            MessageBox.Show($"Không có thông tin của vật liệu {type}");
            return new Concrete();
        }
        public Steel GetSteelByType(SteelType type)
        {
            for (int i = 0; i < ConcreteDatas.Count; i++)
            {
                if (type == SteelDatas[i].steelType)
                {
                    return SteelDatas[i];
                }
            }
            MessageBox.Show($"Không có thông tin của vật liệu {type}");
            return new Steel();
        }
    }

}
