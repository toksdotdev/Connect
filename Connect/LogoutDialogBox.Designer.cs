using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace Connect
{
    partial class LogoutDialogBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("LuzSans-Book", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(50, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Are you sure you want to Logout?";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(382, 214);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape3.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.rectangleShape3.BorderWidth = 2;
            this.rectangleShape3.Location = new System.Drawing.Point(0, 0);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(381, 213);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.rectangleShape2.CornerRadius = 16;
            this.rectangleShape2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape2.FillColor = System.Drawing.Color.DarkSlateGray;
            this.rectangleShape2.FillGradientColor = System.Drawing.Color.White;
            this.rectangleShape2.Location = new System.Drawing.Point(208, 130);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.SelectionColor = System.Drawing.Color.Transparent;
            this.rectangleShape2.Size = new System.Drawing.Size(81, 33);
            this.rectangleShape2.MouseEnter += new System.EventHandler(this.rectangleShape_MouseEnter);
            this.rectangleShape2.MouseLeave += new System.EventHandler(this.rectangleShape_MouseLeave);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.rectangleShape1.CornerRadius = 16;
            this.rectangleShape1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.White;
            this.rectangleShape1.Location = new System.Drawing.Point(94, 132);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.Size = new System.Drawing.Size(81, 33);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            this.rectangleShape1.MouseEnter += new System.EventHandler(this.rectangleShape_MouseEnter);
            this.rectangleShape1.MouseLeave += new System.EventHandler(this.rectangleShape_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(115, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yes";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(232, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "No";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Connect.Properties.Resources.Close_Window_50px;
            this.pictureBox1.Location = new System.Drawing.Point(151, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.SystemColors.WindowText;
            this.TitleBar.Controls.Add(this.shapeContainer3);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(382, 20);
            this.TitleBar.TabIndex = 8;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape1});
            this.shapeContainer3.Size = new System.Drawing.Size(382, 20);
            this.shapeContainer3.TabIndex = 1;
            this.shapeContainer3.TabStop = false;
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ovalShape1.BorderColor = System.Drawing.Color.Transparent;
            this.ovalShape1.FillColor = System.Drawing.Color.Red;
            this.ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape1.Location = new System.Drawing.Point(5, 5);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(12, 12);
            this.ovalShape1.Click += new System.EventHandler(this.ovalShape1_Click);
            // 
            // LogoutDialogBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 214);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogoutDialogBox";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Logout";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Logout_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ShapeContainer shapeContainer1;
        private RectangleShape rectangleShape1;
        private RectangleShape rectangleShape2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private RectangleShape rectangleShape3;
        private Panel TitleBar;
        private ShapeContainer shapeContainer3;
        private OvalShape ovalShape1;
    }
}