using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduateProject
{
    public partial class Caculate : Form
    {
        private List<FrameData> _frameData;
        private int index;
        private double width;
        private double height;
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
            for (int i = 0; i < _frameData.Count; i++)
            {
                listFloorCbb.Items.Add(_frameData[i].Level);
            }
            foreach (var item in Enum.GetValues(typeof(ConcreteType)))
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
            width = _frameData[index].width;
            height = _frameData[index].height;
            Singleton.Instance.SelectItemOnUI((int)listItemCbb.Items[index]);
        }
        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StructureData data = new StructureData();
            data.ID = int.Parse(listItemCbb.SelectedItem.ToString());
            data.Level = 0;//int.Parse(listFloorCbb.SelectedItem.ToString());
            data.MomenEdge = double.Parse(mEdgeTxt.Text);
            data.QuantityEdge = int.Parse(quantitySteelEdgeTxt.Text);
            data.RadiusEdge = int.Parse(radiusEdgeTxt.Text);
            data.AsEdgeSelect = double.Parse(AsEdgeSelectTxt.Text);
            data.AsEdge = AsEdge;
            data.MomenCenter = double.Parse(mCenterTxt.Text);
            data.QuantityCenter = int.Parse(quantitySteelCenterTxt.Text);
            data.RadiusCenter = int.Parse(radiusCentertxt.Text);
            data.AsCenterSelect = double.Parse(mCenterTxt.Text);
            data.AsCenter = AsCenter;
            Singleton.Instance.SaveData(data);
            MessageBox.Show("Lưu thành công");
        }
        private double AsEdge;
        private double AsCenter;
        private void checkButton_Click(object sender, EventArgs e)
        {
            int a0 = 50;
            //Ép kiểu dữ liệu từ string sang double/int
            double mEdge = double.Parse(mEdgeTxt.Text);
            int quantityEdge = int.Parse(quantitySteelEdgeTxt.Text);
            int radiusEdge = int.Parse(radiusEdgeTxt.Text);
            //Tính thép chọn 
            AsEdge = quantityEdge * Math.PI * radiusEdge * radiusEdge / 4;
            AsEdgeSelectTxt.Text = Math.Round(AsEdge, 2).ToString();
            double muyEdge = AsEdge / (width * (height - a0));
            muyEdgeTxt.Text = Math.Round(muyEdge, 2).ToString();
            if (AsEdge > CaculateAreaSteel(mEdge, 50, 0.5f) && CheckMuy(muyEdge))
            {
                resultEdgeTxt.Text = "Thỏa mãn";
                resultEdgeTxt.ForeColor = Color.Green;
            }
            else
            {
                resultEdgeTxt.Text = "Không Thỏa mãn";
                resultEdgeTxt.ForeColor = Color.Red;
            }

            double mCenter = double.Parse(mCenterTxt.Text);
            int quantityCenter = int.Parse(quantitySteelCenterTxt.Text);
            int radiusCenter = int.Parse(radiusCentertxt.Text);
            AsCenter = quantityCenter * Math.PI * radiusCenter * radiusCenter / 4;
            AsCenterSelectTxt.Text = Math.Round(AsCenter, 2).ToString();
            double muyCenter = AsCenter / (width * (height - a0));
            muyCenterTxt.Text = Math.Round(muyCenter, 2).ToString();
            if (AsCenter > CaculateAreaSteel(mCenter, a0, 0.5f) && CheckMuy(muyCenter))
            {
                resultCenterTxt.Text = "Thỏa mãn";
                resultCenterTxt.ForeColor = Color.Green;
            }
            else
            {
                resultCenterTxt.Text = "Không Thỏa mãn";
                resultCenterTxt.ForeColor = Color.Red;
            }
            
        }
        private double CaculateAreaSteel(double moment, int a0, double alphaR)
        {
            double As;
            double h0 = height - a0;
            //Lấy Rb,Rs của bê tông theo giá trị đã chọn ở combobox
            double Rb = Singleton.Instance.GetConcreteByType(concreteType).Rb;
            double Rs = Singleton.Instance.GetSteelByType(steelType).Rs;
            double alphaM = moment / (Rb * width * h0 * h0);
            if(alphaM >= alphaR)
            {
                As = 0;
            }
            else
            {
                double zeta = 0.5f * (1 + Math.Sqrt(1 - 2 * alphaM));
                As = moment / (Rs * zeta * h0);
            }
            return As;
        }
        private bool CheckMuy(double value)
        {
            if (value > double.Parse(mMinTxt.Text) && value < double.Parse(mMaxTxt.Text))
            {
                return true;
            }
            return false;
        }

        private ConcreteType concreteType;
        private void concreteCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            concreteType = (ConcreteType)Enum.Parse(typeof(ConcreteType), concreteCbb.SelectedItem.ToString());
        }
        private SteelType steelType;
        private void steelCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            steelType = (SteelType)Enum.Parse(typeof(SteelType), steelCbb.SelectedItem.ToString());
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            SavedStructure savedStructure = new SavedStructure(Singleton.Instance.structureDatas);
            savedStructure.Show();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Singleton.Instance.GetFaces((int)listItemCbb.Items[index]);
        }

        private void muyCenterTxt_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }
    }
}
