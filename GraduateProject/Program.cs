using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
            {
                MainForm mainForm = new MainForm();
                mainForm.StartPosition = FormStartPosition.CenterScreen;
                mainForm.Show();
                return Result.Succeeded;


            }
            private IEnumerator Coroutine()
            {
                float startTime = 0;
                float endTime = 10;
                while(startTime < endTime)
                {
                    //startTime += Time
                    yield return null;

                }
            }
        }

    }

}
