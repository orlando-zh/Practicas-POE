namespace Practica1POE
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            ejeXYabel = new Label();
            ejeXlabel = new Label();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            nombreClickLabel = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(99, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "MouseDown y MouseUp";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(ejeXYabel);
            groupBox2.Controls.Add(ejeXlabel);
            groupBox2.Location = new Point(464, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "MouseMove";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 80);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 23);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // ejeXYabel
            // 
            ejeXYabel.AutoSize = true;
            ejeXYabel.Location = new Point(26, 81);
            ejeXYabel.Name = "ejeXYabel";
            ejeXYabel.Size = new Size(44, 20);
            ejeXYabel.TabIndex = 1;
            ejeXYabel.Text = "Eje Y:";
            // 
            // ejeXlabel
            // 
            ejeXlabel.AutoSize = true;
            ejeXlabel.Location = new Point(20, 27);
            ejeXlabel.Name = "ejeXlabel";
            ejeXlabel.Size = new Size(45, 20);
            ejeXlabel.TabIndex = 0;
            ejeXlabel.Text = "Eje X:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nombreClickLabel);
            groupBox3.Location = new Point(290, 269);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "MouseWheel";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(55, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // nombreClickLabel
            // 
            nombreClickLabel.AutoSize = true;
            nombreClickLabel.Location = new Point(51, 51);
            nombreClickLabel.Name = "nombreClickLabel";
            nombreClickLabel.Size = new Size(50, 20);
            nombreClickLabel.TabIndex = 0;
            nombreClickLabel.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "/";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label4;
        private Label label3;
        private Label ejeXYabel;
        private Label ejeXlabel;
        private PictureBox pictureBox1;
        private Label nombreClickLabel;
    }
}