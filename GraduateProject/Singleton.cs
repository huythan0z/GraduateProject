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
            var newConcrete = ConcreteDatas.Find(x => x.type == concrete.type);
            if (newConcrete == null)
            {
                ConcreteDatas.Add(concrete);
            }
            else
            {
                for (int i = 0; i < ConcreteDatas.Count; i++)
                {
                    if (concrete.type == ConcreteDatas[i].type)
                    {
                        ConcreteDatas[i] = concrete;
                    }
                }
            }

            var newSteel = SteelDatas.Find(x => x.type == steel.type);
            if (newSteel == null)
            {
                SteelDatas.Add(steel);
            }
            else
            {
                for (int i = 0; i < SteelDatas.Count; i++)
                {
                    if (steel.type == SteelDatas[i].type)
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
                if (type == ConcreteDatas[i].type)
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
                if (type == SteelDatas[i].type)
                {
                    return SteelDatas[i];
                }
            }
            MessageBox.Show($"Không có thông tin của vật liệu {type}");
            return new Steel();
        }
        public List<StructureData> structureDatas = new List<StructureData>();
        public void SaveData(StructureData data)
        {
            var newData = structureDatas.Find(x => x.ID == data.ID);
            if(newData != null)
            {
                for (int i = 0; i < structureDatas.Count; i++)
                {
                    if (newData.ID == structureDatas[i].ID)
                    {
                        structureDatas[i] = data;
                    }
                }
            }
            else
            {
                structureDatas.Add(data);
            }

        }
    }

}
