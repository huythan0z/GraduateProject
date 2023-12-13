using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduateProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void setMaterialButton_Click(object sender, EventArgs e)
        {
            SetMaterialForm setMaterial = new SetMaterialForm();
            setMaterial.Show();
            
        }

        private void selectSteelButton_Click(object sender, EventArgs e)
        {
            Caculate caculate = new Caculate();
            caculate.Show();
            
        }
    }
}
