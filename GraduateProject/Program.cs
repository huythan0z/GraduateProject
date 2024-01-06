using Autodesk.Revit.Creation;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GraduateProject
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Program : IExternalCommand
    {
        private List<FrameData> framingDatas = new List<FrameData>();
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            GetAllItem(commandData);
            MainForm mainForm = new MainForm(framingDatas);
            mainForm.Show();
            return Result.Succeeded;
        }

        private void GetAllItem(ExternalCommandData commandData)
        {
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Singleton.Instance.commandData = commandData;
            FilteredElementCollector col = new FilteredElementCollector(uiDoc.Document);
            //Lấy danh sách dầm
            ElementCategoryFilter frames = new ElementCategoryFilter(BuiltInCategory.OST_StructuralFraming);
            IList<Element> frameList = col.WherePasses(frames).WhereElementIsNotElementType().ToElements();
            Singleton.Instance.listItem = frameList;


            foreach (Element item in frameList)
            {
                ElementType type = uiDoc.Document.GetElement(item.GetTypeId()) as ElementType;


                Parameter h = type.LookupParameter("h");
                Parameter b = type.LookupParameter("b");

                //Parameter l = item.LookupParameter("Volume");
                //MessageBox.Show(l.AsDouble().ToString());

                var data = new FrameData();
                data.Id = item.Id.IntegerValue;
                data.Level = item.LevelId.ToString();
                data.width = Math.Round(UnitUtils.Convert(b.AsDouble(),
                DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_MILLIMETERS), 2);
                data.height = Math.Round(UnitUtils.Convert(h.AsDouble(),
                DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_MILLIMETERS), 2);
                framingDatas.Add(data);
            }
        }
    }
}
