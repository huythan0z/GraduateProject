
namespace GraduateProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listItem = new System.Windows.Forms.DataGridView();
            this.columnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setMaterialButton = new System.Windows.Forms.Button();
            this.selectSteelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listItem)).BeginInit();
            this.SuspendLayout();
            // 
            // listItem
            // 
            this.listItem.AllowUserToAddRows = false;
            this.listItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIndex,
            this.Floor,
            this.Width,
            this.Height});
            this.listItem.Location = new System.Drawing.Point(12, 55);
            this.listItem.Name = "listItem";
            this.listItem.RowHeadersWidth = 51;
            this.listItem.RowTemplate.Height = 24;
            this.listItem.Size = new System.Drawing.Size(554, 198);
            this.listItem.TabIndex = 0;
            this.listItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listItem_CellContentClick);
            // 
            // columnIndex
            // 
            this.columnIndex.HeaderText = "ID dầm";
            this.columnIndex.MinimumWidth = 6;
            this.columnIndex.Name = "columnIndex";
            this.columnIndex.Width = 125;
            // 
            // Floor
            // 
            this.Floor.HeaderText = "Tầng";
            this.Floor.MinimumWidth = 6;
            this.Floor.Name = "Floor";
            this.Floor.Width = 125;
            // 
            // Width
            // 
            this.Width.HeaderText = "Chiều rộng b";
            this.Width.MinimumWidth = 6;
            this.Width.Name = "Width";
            this.Width.Width = 125;
            // 
            // Height
            // 
            this.Height.HeaderText = "Chiều cao h";
            this.Height.MinimumWidth = 6;
            this.Height.Name = "Height";
            this.Height.Width = 125;
            // 
            // setMaterialButton
            // 
            this.setMaterialButton.Location = new System.Drawing.Point(92, 276);
            this.setMaterialButton.Name = "setMaterialButton";
            this.setMaterialButton.Size = new System.Drawing.Size(100, 50);
            this.setMaterialButton.TabIndex = 2;
            this.setMaterialButton.Text = "Thêm vật liệu";
            this.setMaterialButton.UseVisualStyleBackColor = true;
            this.setMaterialButton.Click += new System.EventHandler(this.setMaterialButton_Click);
            // 
            // selectSteelButton
            // 
            this.selectSteelButton.Location = new System.Drawing.Point(379, 276);
            this.selectSteelButton.Name = "selectSteelButton";
            this.selectSteelButton.Size = new System.Drawing.Size(100, 50);
            this.selectSteelButton.TabIndex = 3;
            this.selectSteelButton.Text = "Chọn thép";
            this.selectSteelButton.UseVisualStyleBackColor = true;
            this.selectSteelButton.Click += new System.EventHandler(this.selectSteelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "PHẦN MỀM TÍNH TOÁN CỐT THÉP DẦM";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectSteelButton);
            this.Controls.Add(this.setMaterialButton);
            this.Controls.Add(this.listItem);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.listItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listItem;
        private System.Windows.Forms.Button setMaterialButton;
        private System.Windows.Forms.Button selectSteelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.Label label1;
    }
}