namespace Connect
{
    partial class ProfileWindowFake
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1,
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(645, 497);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.Color.White;
            this.rectangleShape2.CornerRadius = 4;
            this.rectangleShape2.FillColor = System.Drawing.SystemColors.GrayText;
            this.rectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape2.Location = new System.Drawing.Point(633, 6);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.SelectionColor = System.Drawing.Color.White;
            this.rectangleShape2.Size = new System.Drawing.Size(8, 164);
            this.rectangleShape2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.rectangleShape2_MouseWheel);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.FillColor = System.Drawing.SystemColors.Control;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(630, 2);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.White;
            this.rectangleShape1.Size = new System.Drawing.Size(13, 491);
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackgroundImage = global::Connect.Properties.Resources.me;
            this.ovalShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ovalShape1.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.ovalShape1.Location = new System.Drawing.Point(231, 15);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(158, 159);
            this.ovalShape1.Click += new System.EventHandler(this.ovalShape1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(0, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 311);
            this.panel1.TabIndex = 1;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(442, 43);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(33, 200);
            this.vScrollBar1.TabIndex = 0;
            // 
            // ProfileWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileWindow";
            this.Text = "ProfileWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}