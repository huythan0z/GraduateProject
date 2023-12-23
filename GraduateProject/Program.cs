using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GraduateProject
{
    internal static class Program
    {
        [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
        public class Class1 : IExternalCommand
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
                FilteredElementCollector col = new FilteredElementCollector(uiDoc.Document);
                //Lấy danh sách dầm
                ElementCategoryFilter frames = new ElementCategoryFilter(BuiltInCategory.OST_StructuralFraming);
                IList<Element> frameList = col.WherePasses(frames).WhereElementIsNotElementType().ToElements();
                //Log check 
                StringBuilder outPut = new StringBuilder($"Số lượng : {frameList.Count} \n");
                foreach (Element item in frameList)
                {
                    string elementName = item.Id.IntegerValue.ToString();
                    ElementType type = uiDoc.Document.GetElement(item.GetTypeId()) as ElementType;
                    Parameter h = type.LookupParameter("h");
                    Parameter b = type.LookupParameter("b");
                    outPut.Append(elementName);
                    outPut.AppendLine();
                    var data = new FrameData()
                    {
                        Id = item.Id.IntegerValue,
                        Level = item.LevelId.IntegerValue,
                        width = ConvertFeetToMili(b.AsDouble()),
                        height = ConvertFeetToMili(h.AsDouble())
                    };
                    framingDatas.Add(data);
                }
                MessageBox.Show(outPut.ToString());
            }
            private double ConvertFeetToMili(double value)
            {
                double newValue = Math.Round(UnitUtils.Convert(value, DisplayUnitType.DUT_DECIMAL_FEET, DisplayUnitType.DUT_MILLIMETERS), 2);
                return newValue;
            }

        }

    }

}
