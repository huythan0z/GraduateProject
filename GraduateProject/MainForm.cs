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
        private List<FrameData> _frameDatas;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(List<FrameData> framingDatas) : this()
        {
            _frameDatas = framingDatas;
            //Truyền dữ liệu vào dataGridView
            for (int i = 0; i < framingDatas.Count; i++)
            {
                listItem.Rows.Add(framingDatas[i]);
                listItem.Rows[i].Cells[0].Value = framingDatas[i].Id;
                listItem.Rows[i].Cells[1].Value = "1";
                listItem.Rows[i].Cells[2].Value = framingDatas[i].width;
                listItem.Rows[i].Cells[3].Value = framingDatas[i].height;
            }
        }

        private void setMaterialButton_Click(object sender, EventArgs e)
        {
            SetMaterialForm setMaterial = new SetMaterialForm("");
            setMaterial.Show();
            
        }

        private void selectSteelButton_Click(object sender, EventArgs e)
        {
            Caculate caculate = new Caculate(_frameDatas);
            caculate.Show();
            
        }

        private void listItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        } 
    }
}
