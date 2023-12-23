using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GraduateProject
{
    public partial class SetMaterialForm : Form
    {
        public SetMaterialForm()
        {

            InitializeComponent();
        }
        public SetMaterialForm(string name) : this()
        {
            foreach (var item in Enum.GetValues(typeof(ConcreteType)))
            {
                typeConcreteCbb.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(SteelType)))
            {
                typeSteelCbb.Items.Add(item);
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
                  
        }
        private void saveMaterial_Click(object sender, EventArgs e)
        {
            Steel steel = new Steel();
            steel.type = (SteelType)Enum.Parse(typeof(SteelType), typeSteelCbb.SelectedItem.ToString());
            Concrete concrete = new Concrete();
            concrete.type = (ConcreteType)Enum.Parse(typeof(ConcreteType), typeConcreteCbb.SelectedItem.ToString());
            Singleton.Instance.AddMaterialToData(concrete, steel);
        }

        private void typeConcreteCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void typeSteelCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
