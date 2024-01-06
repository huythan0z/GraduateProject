namespace GraduateProject
{
    partial class SetMaterialForm
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
            this.Concrete = new System.Windows.Forms.GroupBox();
            this.typeConcreteCbb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ebTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Steel = new System.Windows.Forms.GroupBox();
            this.typeSteelCbb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.esTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rscTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rsTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.saveMaterial = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.Concrete.SuspendLayout();
            this.Steel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Concrete
            // 
            this.Concrete.Controls.Add(this.typeConcreteCbb);
            this.Concrete.Controls.Add(this.label7);
            this.Concrete.Controls.Add(this.label6);
            this.Concrete.Controls.Add(this.label5);
            this.Concrete.Controls.Add(this.ebTxt);
            this.Concrete.Controls.Add(this.label4);
            this.Concrete.Controls.Add(this.rbtTxt);
            this.Concrete.Controls.Add(this.label3);
            this.Concrete.Controls.Add(this.rbTxt);
            this.Concrete.Controls.Add(this.label2);
            this.Concrete.Controls.Add(this.label1);
            this.Concrete.Location = new System.Drawing.Point(12, 12);
            this.Concrete.Name = "Concrete";
            this.Concrete.Size = new System.Drawing.Size(228, 152);
            this.Concrete.TabIndex = 0;
            this.Concrete.TabStop = false;
            this.Concrete.Text = "Bê tông";
            // 
            // typeConcreteCbb
            // 
            this.typeConcreteCbb.FormattingEnabled = true;
            this.typeConcreteCbb.Location = new System.Drawing.Point(55, 22);
            this.typeConcreteCbb.Name = "typeConcreteCbb";
            this.typeConcreteCbb.Size = new System.Drawing.Size(154, 24);
            this.typeConcreteCbb.TabIndex = 12;
            this.typeConcreteCbb.SelectedIndexChanged += new System.EventHandler(this.typeConcreteCbb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "kN/m2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "kN/m2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "kN/m2";
            // 
            // ebTxt
            // 
            this.ebTxt.Location = new System.Drawing.Point(55, 110);
            this.ebTxt.Name = "ebTxt";
            this.ebTxt.Size = new System.Drawing.Size(100, 22);
            this.ebTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Eb :";
            // 
            // rbtTxt
            // 
            this.rbtTxt.Location = new System.Drawing.Point(55, 82);
            this.rbtTxt.Name = "rbtTxt";
            this.rbtTxt.Size = new System.Drawing.Size(100, 22);
            this.rbtTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rbt :";
            // 
            // rbTxt
            // 
            this.rbTxt.Location = new System.Drawing.Point(55, 54);
            this.rbTxt.Name = "rbTxt";
            this.rbTxt.Size = new System.Drawing.Size(100, 22);
            this.rbTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rb :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại :";
            // 
            // Steel
            // 
            this.Steel.Controls.Add(this.typeSteelCbb);
            this.Steel.Controls.Add(this.label8);
            this.Steel.Controls.Add(this.label9);
            this.Steel.Controls.Add(this.label10);
            this.Steel.Controls.Add(this.esTxt);
            this.Steel.Controls.Add(this.label11);
            this.Steel.Controls.Add(this.rscTxt);
            this.Steel.Controls.Add(this.label12);
            this.Steel.Controls.Add(this.rsTxt);
            this.Steel.Controls.Add(this.label13);
            this.Steel.Controls.Add(this.label14);
            this.Steel.Location = new System.Drawing.Point(270, 12);
            this.Steel.Name = "Steel";
            this.Steel.Size = new System.Drawing.Size(228, 152);
            this.Steel.TabIndex = 11;
            this.Steel.TabStop = false;
            this.Steel.Text = "Thép";
            // 
            // typeSteelCbb
            // 
            this.typeSteelCbb.FormattingEnabled = true;
            this.typeSteelCbb.Location = new System.Drawing.Point(55, 22);
            this.typeSteelCbb.Name = "typeSteelCbb";
            this.typeSteelCbb.Size = new System.Drawing.Size(154, 24);
            this.typeSteelCbb.TabIndex = 11;
            this.typeSteelCbb.SelectedIndexChanged += new System.EventHandler(this.typeSteelCbb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "kN/m2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "kN/m2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "kN/m2";
            // 
            // esTxt
            // 
            this.esTxt.Location = new System.Drawing.Point(55, 110);
            this.esTxt.Name = "esTxt";
            this.esTxt.Size = new System.Drawing.Size(100, 22);
            this.esTxt.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Es :";
            // 
            // rscTxt
            // 
            this.rscTxt.Location = new System.Drawing.Point(55, 82);
            this.rscTxt.Name = "rscTxt";
            this.rscTxt.Size = new System.Drawing.Size(100, 22);
            this.rscTxt.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Rsc :";
            // 
            // rsTxt
            // 
            this.rsTxt.Location = new System.Drawing.Point(55, 54);
            this.rsTxt.Name = "rsTxt";
            this.rsTxt.Size = new System.Drawing.Size(100, 22);
            this.rsTxt.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Rs :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Loại :";
            // 
            // saveMaterial
            // 
            this.saveMaterial.Location = new System.Drawing.Point(355, 175);
            this.saveMaterial.Name = "saveMaterial";
            this.saveMaterial.Size = new System.Drawing.Size(143, 40);
            this.saveMaterial.TabIndex = 12;
            this.saveMaterial.Text = "Lưu vật liệu";
            this.saveMaterial.UseVisualStyleBackColor = true;
            this.saveMaterial.Click += new System.EventHandler(this.saveMaterial_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 175);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 40);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SetMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 227);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveMaterial);
            this.Controls.Add(this.Steel);
            this.Controls.Add(this.Concrete);
            this.Name = "SetMaterialForm";
            this.Text = "Set Material";
            this.Concrete.ResumeLayout(false);
            this.Concrete.PerformLayout();
            this.Steel.ResumeLayout(false);
            this.Steel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Concrete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ebTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rbtTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rbTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Steel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox esTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rscTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox rsTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button saveMaterial;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox typeSteelCbb;
        private System.Windows.Forms.ComboBox typeConcreteCbb;
    }
}

