using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
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
            if (newData != null)
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
        public IList<Element> listItem;
        public Element GetItemSelectedByID(int itemId)
        {
            var item = listItem.ToList().Find(x => x.Id.IntegerValue == itemId);
            if(item != null)
            {
                return item;
            }
            else
            {
                MessageBox.Show($"Không tìm thấy phần tử có ID :{itemId}");
                return null;    
            }
        }

        public void GetFaces(int currentItemSelectID)
        {
            string outPut = "";
            var currentItem = Singleton.Instance.GetItemSelectedByID(currentItemSelectID);
            var getSelectElement = currentItem.get_Geometry(new Options());
            foreach (var item in getSelectElement)
            {
                if (item is Solid)
                {
                    Solid solid = item as Solid;
                    foreach (Face face in solid.Faces)
                    {
                        outPut = "Face Selected " + GetPointFomrFace(face);
                        //Todo: Vẽ Thép
                    }
                }
            }
            MessageBox.Show(outPut);
        }
        private IList<XYZ> GetPointFomrFace(Face face)
        {
            IList<XYZ> listPoint = new List<XYZ>();
            EdgeArrayArray edgeArrayA = face.EdgeLoops;
            foreach (EdgeArray items in edgeArrayA)
            {
                foreach (Edge edge in items)
                {
                    XYZ pointCompare1, pointCompare2;
                    pointCompare1 = edge.AsCurve().GetEndPoint(0);
                    pointCompare2 = edge.AsCurve().GetEndPoint(1);

                    if (listPoint.Count == 0)
                    {
                        listPoint.Add(pointCompare1);
                        listPoint.Add(pointCompare2);
                    }
                    else
                    {
                        bool checkPoint = false;
                        for (int i = 0; i < listPoint.Count; i++)
                        {
                            checkPoint = checkPoint || listPoint[i] == pointCompare1;
                        }
                        if (!checkPoint)
                        {
                            listPoint.Add(edge.AsCurve().GetEndPoint(0));
                        }
                        checkPoint = false;
                        for (int i = 0; i < listPoint.Count; i++)
                        {
                            checkPoint = checkPoint || listPoint[i] == pointCompare2;
                        }
                        if (!checkPoint)
                        {
                            listPoint.Add(edge.AsCurve().GetEndPoint(1));
                        }
                    }
                }
            }
            string log = "";
            for (int i = 0; i < listPoint.Count; i++)
            {
                log += listPoint[i] + "\n";
            }
            MessageBox.Show(log);
          
            return listPoint;
        }

        public ExternalCommandData commandData;
        public void SelectItemOnUI(int elementID)
        {
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            ElementId elementIdToSelect = new ElementId(elementID);
            Selection selection = uiDoc.Selection;
            selection.SetElementIds(new List<ElementId> { elementIdToSelect });
           //uiDoc.ShowElements(elementIdToSelect);
        }
    }
}