using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GraduateProject
{
    public partial class Caculate : Form
    {
        private List<FrameData> _frameData;
        private int index;
        public Caculate()
        {
            InitializeComponent();
        }
        public Caculate(List<FrameData> framingDatas) : this()
        {
            _frameData = framingDatas;
            for(int i = 0; i < _frameData.Count; i++)
            {
                listItemCbb.Items.Add(_frameData[i].Id);
            }
            foreach(var item in Enum.GetValues(typeof(ConcreteType)))
            {
                concreteCbb.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(SteelType)))
            {
                steelCbb.Items.Add(item);
            }

        }
        private void heightTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void listItemCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listItemCbb.SelectedIndex;
            widthColumnTxt.Text = _frameData[index].width.ToString();
            heightColumnTxt.Text = _frameData[index].height.ToString();

            MessageBox.Show(Singleton.Instance.ConcreteDatas.Count.ToString());
            MessageBox.Show(Singleton.Instance.SteelDatas.Count.ToString());
        }
        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
