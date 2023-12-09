
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
            this.selectColumnButton = new System.Windows.Forms.Button();
            this.setMaterialButton = new System.Windows.Forms.Button();
            this.selectSteelButton = new System.Windows.Forms.Button();
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
            this.listItem.Location = new System.Drawing.Point(12, 12);
            this.listItem.Name = "listItem";
            this.listItem.RowHeadersWidth = 51;
            this.listItem.RowTemplate.Height = 24;
            this.listItem.Size = new System.Drawing.Size(554, 198);
            this.listItem.TabIndex = 0;
            // 
            // columnIndex
            // 
            this.columnIndex.HeaderText = "Cột";
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
            this.Width.HeaderText = "b";
            this.Width.MinimumWidth = 6;
            this.Width.Name = "Width";
            this.Width.Width = 125;
            // 
            // Height
            // 
            this.Height.HeaderText = "h";
            this.Height.MinimumWidth = 6;
            this.Height.Name = "Height";
            this.Height.Width = 125;
            // 
            // selectColumnButton
            // 
            this.selectColumnButton.Location = new System.Drawing.Point(587, 12);
            this.selectColumnButton.Name = "selectColumnButton";
            this.selectColumnButton.Size = new System.Drawing.Size(100, 50);
            this.selectColumnButton.TabIndex = 1;
            this.selectColumnButton.Text = "Chọn cột";
            this.selectColumnButton.UseVisualStyleBackColor = true;
            // 
            // setMaterialButton
            // 
            this.setMaterialButton.Location = new System.Drawing.Point(587, 68);
            this.setMaterialButton.Name = "setMaterialButton";
            this.setMaterialButton.Size = new System.Drawing.Size(100, 50);
            this.setMaterialButton.TabIndex = 2;
            this.setMaterialButton.Text = "Thêm vật liệu";
            this.setMaterialButton.UseVisualStyleBackColor = true;
            // 
            // selectSteelButton
            // 
            this.selectSteelButton.Location = new System.Drawing.Point(587, 124);
            this.selectSteelButton.Name = "selectSteelButton";
            this.selectSteelButton.Size = new System.Drawing.Size(100, 50);
            this.selectSteelButton.TabIndex = 3;
            this.selectSteelButton.Text = "Chọn thép";
            this.selectSteelButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 248);
            this.Controls.Add(this.selectSteelButton);
            this.Controls.Add(this.setMaterialButton);
            this.Controls.Add(this.selectColumnButton);
            this.Controls.Add(this.listItem);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.listItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.Button selectColumnButton;
        private System.Windows.Forms.Button setMaterialButton;
        private System.Windows.Forms.Button selectSteelButton;
    }
}