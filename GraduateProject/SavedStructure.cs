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
    public partial class SavedStructure : Form
    {
        public SavedStructure()
        {
            InitializeComponent();
        }
        public SavedStructure(List<StructureData> structureDatas) : this()
        {
            for (int i = 0; i < structureDatas.Count; i++)
            {
                dataGridView1.Rows.Add(structureDatas[i]);
                dataGridView1.Rows[i].Cells[0].Value = structureDatas[i].ID;
                dataGridView1.Rows[i].Cells[1].Value = structureDatas[i].Level;
                dataGridView1.Rows[i].Cells[2].Value = structureDatas[i].MomenEdge;
                dataGridView1.Rows[i].Cells[3].Value = structureDatas[i].QuantityEdge;
                dataGridView1.Rows[i].Cells[4].Value = structureDatas[i].RadiusEdge;
                dataGridView1.Rows[i].Cells[5].Value = structureDatas[i].AsEdgeSelect;
                dataGridView1.Rows[i].Cells[6].Value = structureDatas[i].AsEdge;
                dataGridView1.Rows[i].Cells[7].Value = structureDatas[i].MomenCenter;
                dataGridView1.Rows[i].Cells[8].Value = structureDatas[i].QuantityCenter;
                dataGridView1.Rows[i].Cells[9].Value = structureDatas[i].RadiusCenter;
                dataGridView1.Rows[i].Cells[10].Value = structureDatas[i].AsCenterSelect;
                dataGridView1.Rows[i].Cells[11].Value = structureDatas[i].AsCenter;
            }
        }

        private void GridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
