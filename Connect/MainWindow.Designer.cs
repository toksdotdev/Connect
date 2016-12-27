using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace Connect
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.m1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelPurchase = new System.Windows.Forms.Label();
            this.m11 = new System.Windows.Forms.Panel();
            this.m2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelSell = new System.Windows.Forms.Label();
            this.m22 = new System.Windows.Forms.Panel();
            this.m3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelProfile = new System.Windows.Forms.Label();
            this.m33 = new System.Windows.Forms.Panel();
            this.m4 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.labelSettings = new System.Windows.Forms.Label();
            this.m44 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelVersion = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m5 = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.labelLogout = new System.Windows.Forms.Label();
            this.m55 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBoxGoogleMap = new System.Windows.Forms.PictureBox();
            this.pictureBoxTwitter = new System.Windows.Forms.PictureBox();
            this.pictureBoxFcbk = new System.Windows.Forms.PictureBox();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.m1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.m2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.m3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.m4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelVersion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            this.m5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoogleMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFcbk)).BeginInit();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m1
            // 
            this.m1.BackColor = System.Drawing.Color.Transparent;
            this.m1.Controls.Add(this.pictureBox2);
            this.m1.Controls.Add(this.labelPurchase);
            this.m1.Controls.Add(this.m11);
            this.m1.Location = new System.Drawing.Point(3, 16);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(197, 60);
            this.m1.TabIndex = 0;
            this.m1.Click += new System.EventHandler(this.labelPurchase_Click);
            this.m1.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.m1.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::Connect.Properties.Resources.Buy_32px;
            this.pictureBox2.Location = new System.Drawing.Point(19, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // labelPurchase
            // 
            this.labelPurchase.AutoSize = true;
            this.labelPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPurchase.Font = new System.Drawing.Font("LuzSans-Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchase.ForeColor = System.Drawing.Color.White;
            this.labelPurchase.Location = new System.Drawing.Point(48, 14);
            this.labelPurchase.Name = "labelPurchase";
            this.labelPurchase.Size = new System.Drawing.Size(123, 37);
            this.labelPurchase.TabIndex = 1;
            this.labelPurchase.Text = "Purchase";
            this.labelPurchase.Click += new System.EventHandler(this.labelPurchase_Click);
            this.labelPurchase.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.labelPurchase.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // m11
            // 
            this.m11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(152)))), ((int)(((byte)(224)))));
            this.m11.Dock = System.Windows.Forms.DockStyle.Left;
            this.m11.Location = new System.Drawing.Point(0, 0);
            this.m11.Name = "m11";
            this.m11.Size = new System.Drawing.Size(10, 60);
            this.m11.TabIndex = 0;
            this.m11.Visible = false;
            // 
            // m2
            // 
            this.m2.Controls.Add(this.pictureBox3);
            this.m2.Controls.Add(this.labelSell);
            this.m2.Controls.Add(this.m22);
            this.m2.Location = new System.Drawing.Point(3, 81);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(197, 60);
            this.m2.TabIndex = 1;
            this.m2.Click += new System.EventHandler(this.labelSell_Click);
            this.m2.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.m2.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::Connect.Properties.Resources.Money_Bag_32px;
            this.pictureBox3.Location = new System.Drawing.Point(17, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // labelSell
            // 
            this.labelSell.AutoSize = true;
            this.labelSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSell.Font = new System.Drawing.Font("LuzSans-Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSell.ForeColor = System.Drawing.Color.White;
            this.labelSell.Location = new System.Drawing.Point(48, 11);
            this.labelSell.Name = "labelSell";
            this.labelSell.Size = new System.Drawing.Size(59, 37);
            this.labelSell.TabIndex = 2;
            this.labelSell.Text = "Sell";
            this.labelSell.Click += new System.EventHandler(this.labelSell_Click);
            this.labelSell.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.labelSell.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // m22
            // 
            this.m22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(208)))), ((int)(((byte)(114)))));
            this.m22.Dock = System.Windows.Forms.DockStyle.Left;
            this.m22.Location = new System.Drawing.Point(0, 0);
            this.m22.Name = "m22";
            this.m22.Size = new System.Drawing.Size(10, 60);
            this.m22.TabIndex = 1;
            this.m22.Visible = false;
            // 
            // m3
            // 
            this.m3.Controls.Add(this.pictureBox5);
            this.m3.Controls.Add(this.labelProfile);
            this.m3.Controls.Add(this.m33);
            this.m3.Location = new System.Drawing.Point(3, 147);
            this.m3.Name = "m3";
            this.m3.Size = new System.Drawing.Size(197, 60);
            this.m3.TabIndex = 2;
            this.m3.Click += new System.EventHandler(this.labelProfile_Click);
            this.m3.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.m3.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Image = global::Connect.Properties.Resources.Person_Male_32px;
            this.pictureBox5.Location = new System.Drawing.Point(16, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelProfile.Font = new System.Drawing.Font("LuzSans-Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.Color.White;
            this.labelProfile.Location = new System.Drawing.Point(48, 10);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(89, 37);
            this.labelProfile.TabIndex = 2;
            this.labelProfile.Text = "Profile";
            this.labelProfile.Click += new System.EventHandler(this.labelProfile_Click);
            this.labelProfile.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.labelProfile.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // m33
            // 
            this.m33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(124)))), ((int)(((byte)(107)))));
            this.m33.Dock = System.Windows.Forms.DockStyle.Left;
            this.m33.Location = new System.Drawing.Point(0, 0);
            this.m33.Name = "m33";
            this.m33.Size = new System.Drawing.Size(10, 60);
            this.m33.TabIndex = 1;
            this.m33.Visible = false;
            // 
            // m4
            // 
            this.m4.Controls.Add(this.pictureBox8);
            this.m4.Controls.Add(this.labelSettings);
            this.m4.Controls.Add(this.m44);
            this.m4.Location = new System.Drawing.Point(3, 213);
            this.m4.Name = "m4";
            this.m4.Size = new System.Drawing.Size(197, 63);
            this.m4.TabIndex = 3;
            this.m4.Click += new System.EventHandler(this.labelSettings_Click);
            this.m4.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.m4.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox8.Image = global::Connect.Properties.Resources.Maintenance_32px;
            this.pictureBox8.Location = new System.Drawing.Point(16, 15);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.pictureBox8.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSettings.Font = new System.Drawing.Font("LuzSans-Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettings.ForeColor = System.Drawing.Color.White;
            this.labelSettings.Location = new System.Drawing.Point(48, 15);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(108, 37);
            this.labelSettings.TabIndex = 2;
            this.labelSettings.Text = "Settings";
            this.labelSettings.Click += new System.EventHandler(this.labelSettings_Click);
            this.labelSettings.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.labelSettings.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // m44
            // 
            this.m44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(184)))), ((int)(((byte)(155)))));
            this.m44.Dock = System.Windows.Forms.DockStyle.Left;
            this.m44.Location = new System.Drawing.Point(0, 0);
            this.m44.Name = "m44";
            this.m44.Size = new System.Drawing.Size(10, 63);
            this.m44.TabIndex = 1;
            this.m44.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 491);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.panelVersion);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(699, 491);
            this.panel4.TabIndex = 2;
            // 
            // panelVersion
            // 
            this.panelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVersion.Controls.Add(this.pictureBox7);
            this.panelVersion.Controls.Add(this.label5);
            this.panelVersion.Location = new System.Drawing.Point(615, 448);
            this.panelVersion.Name = "panelVersion";
            this.panelVersion.Size = new System.Drawing.Size(81, 49);
            this.panelVersion.TabIndex = 6;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Image = global::Connect.Properties.Resources.Marker_32px;
            this.pictureBox7.Location = new System.Drawing.Point(3, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("LuzSans-Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(32, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "V 1.0.1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.m5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.m1);
            this.panel2.Controls.Add(this.m4);
            this.panel2.Controls.Add(this.m2);
            this.panel2.Controls.Add(this.m3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 491);
            this.panel2.TabIndex = 3;
            // 
            // m5
            // 
            this.m5.Controls.Add(this.pictureBox12);
            this.m5.Controls.Add(this.labelLogout);
            this.m5.Controls.Add(this.m55);
            this.m5.Location = new System.Drawing.Point(3, 282);
            this.m5.Name = "m5";
            this.m5.Size = new System.Drawing.Size(197, 63);
            this.m5.TabIndex = 11;
            this.m5.Click += new System.EventHandler(this.labelLogout_Click);
            this.m5.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.m5.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox12.Image = global::Connect.Properties.Resources.Logout_Rounded_Left_32px;
            this.pictureBox12.Location = new System.Drawing.Point(16, 15);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(32, 32);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 10;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.pictureBox12.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogout.Font = new System.Drawing.Font("LuzSans-Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.ForeColor = System.Drawing.Color.White;
            this.labelLogout.Location = new System.Drawing.Point(48, 15);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(95, 37);
            this.labelLogout.TabIndex = 2;
            this.labelLogout.Text = "Logout";
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            this.labelLogout.MouseEnter += new System.EventHandler(this.TabBarItem_MouseEnter);
            this.labelLogout.MouseLeave += new System.EventHandler(this.TabBarItem_MouseLeave);
            // 
            // m55
            // 
            this.m55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.m55.Dock = System.Windows.Forms.DockStyle.Left;
            this.m55.Location = new System.Drawing.Point(0, 0);
            this.m55.Name = "m55";
            this.m55.Size = new System.Drawing.Size(10, 63);
            this.m55.TabIndex = 1;
            this.m55.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Controls.Add(this.pictureBoxGoogleMap);
            this.panel6.Controls.Add(this.pictureBoxTwitter);
            this.panel6.Controls.Add(this.pictureBoxFcbk);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 448);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 43);
            this.panel6.TabIndex = 6;
            // 
            // pictureBoxGoogleMap
            // 
            this.pictureBoxGoogleMap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxGoogleMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxGoogleMap.Image = global::Connect.Properties.Resources.Google_Maps_32px;
            this.pictureBoxGoogleMap.Location = new System.Drawing.Point(135, 7);
            this.pictureBoxGoogleMap.Name = "pictureBoxGoogleMap";
            this.pictureBoxGoogleMap.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxGoogleMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGoogleMap.TabIndex = 10;
            this.pictureBoxGoogleMap.TabStop = false;
            // 
            // pictureBoxTwitter
            // 
            this.pictureBoxTwitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxTwitter.Image = global::Connect.Properties.Resources.Twitter_32px;
            this.pictureBoxTwitter.Location = new System.Drawing.Point(83, 7);
            this.pictureBoxTwitter.Name = "pictureBoxTwitter";
            this.pictureBoxTwitter.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTwitter.TabIndex = 9;
            this.pictureBoxTwitter.TabStop = false;
            // 
            // pictureBoxFcbk
            // 
            this.pictureBoxFcbk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxFcbk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxFcbk.Image = global::Connect.Properties.Resources.Facebook_32px;
            this.pictureBoxFcbk.Location = new System.Drawing.Point(27, 7);
            this.pictureBoxFcbk.Name = "pictureBoxFcbk";
            this.pictureBoxFcbk.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxFcbk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFcbk.TabIndex = 8;
            this.pictureBoxFcbk.TabStop = false;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.SystemColors.WindowText;
            this.TitleBar.Controls.Add(this.pictureBox11);
            this.TitleBar.Controls.Add(this.pictureBox10);
            this.TitleBar.Controls.Add(this.pictureBox1);
            this.TitleBar.Controls.Add(this.shapeContainer3);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(899, 69);
            this.TitleBar.TabIndex = 4;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox11.Image = global::Connect.Properties.Resources.Forward_16px;
            this.pictureBox11.Location = new System.Drawing.Point(36, 47);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(16, 16);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox10.Image = global::Connect.Properties.Resources.Back_16px;
            this.pictureBox10.Location = new System.Drawing.Point(6, 47);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(16, 16);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(836, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 111);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape3,
            this.ovalShape2,
            this.ovalShape1});
            this.shapeContainer3.Size = new System.Drawing.Size(899, 69);
            this.shapeContainer3.TabIndex = 1;
            this.shapeContainer3.TabStop = false;
            // 
            // ovalShape3
            // 
            this.ovalShape3.BorderColor = System.Drawing.Color.Transparent;
            this.ovalShape3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ovalShape3.FillGradientColor = System.Drawing.Color.Thistle;
            this.ovalShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape3.Location = new System.Drawing.Point(39, 5);
            this.ovalShape3.Name = "ovalShape3";
            this.ovalShape3.Size = new System.Drawing.Size(12, 12);
            this.ovalShape3.Click += new System.EventHandler(this.ovalShape3_Click);
            // 
            // ovalShape2
            // 
            this.ovalShape2.BorderColor = System.Drawing.Color.Transparent;
            this.ovalShape2.FillColor = System.Drawing.Color.DarkOrange;
            this.ovalShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape2.Location = new System.Drawing.Point(22, 5);
            this.ovalShape2.Name = "ovalShape2";
            this.ovalShape2.Size = new System.Drawing.Size(12, 12);
            this.ovalShape2.Click += new System.EventHandler(this.ovalShape2_Click);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.m1.ResumeLayout(false);
            this.m1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.m2.ResumeLayout(false);
            this.m2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.m3.ResumeLayout(false);
            this.m3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.m4.ResumeLayout(false);
            this.m4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelVersion.ResumeLayout(false);
            this.panelVersion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.m5.ResumeLayout(false);
            this.m5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoogleMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFcbk)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Panel m1;
        private Label labelPurchase;
        private Panel m11;
        private Panel m2;
        private Label labelSell;
        private Panel m22;
        private Panel m3;
        private Label labelProfile;
        private Panel m33;
        private Panel m4;
        private Label labelSettings;
        private Panel m44;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel TitleBar;
        private ShapeContainer shapeContainer3;
        private OvalShape ovalShape3;
        private OvalShape ovalShape2;
        private OvalShape ovalShape1;
        private Panel panel4;
        private Label label5;
        private Panel panelVersion;
        private Panel panel6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox8;
        private PictureBox pictureBoxGoogleMap;
        private PictureBox pictureBoxTwitter;
        private PictureBox pictureBoxFcbk;
        private PictureBox pictureBox7;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private Panel m5;
        private PictureBox pictureBox12;
        private Label labelLogout;
        private Panel m55;

    }
}

