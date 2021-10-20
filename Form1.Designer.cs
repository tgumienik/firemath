
using fireTools;

namespace TymonInformatyka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.pnlMathList = new System.Windows.Forms.Panel();
            this.pictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbMathApps = new System.Windows.Forms.ListBox();
            this.back1 = new System.Windows.Forms.PictureBox();
            this.icoInfo = new System.Windows.Forms.PictureBox();
            this.pnlMathList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proste i pomocne matematyczne aplikacje!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.AutoTransition = true;
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Green,
        System.Drawing.Color.LightBlue,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DarkBlue};
            this.guna2ColorTransition1.EndColor = System.Drawing.Color.DarkBlue;
            this.guna2ColorTransition1.Interval = 1;
            this.guna2ColorTransition1.ValueChanged += new System.EventHandler(this.guna2ColorTransition1_ValueChanged);
            // 
            // pnlMathList
            // 
            this.pnlMathList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnlMathList.Controls.Add(this.pictureBox1);
            this.pnlMathList.Controls.Add(this.guna2Button1);
            this.pnlMathList.Controls.Add(this.label3);
            this.pnlMathList.Controls.Add(this.label2);
            this.pnlMathList.Controls.Add(this.guna2CirclePictureBox1);
            this.pnlMathList.Controls.Add(this.lbMathApps);
            this.pnlMathList.Controls.Add(this.back1);
            this.pnlMathList.Location = new System.Drawing.Point(1, 0);
            this.pnlMathList.Name = "pnlMathList";
            this.pnlMathList.Size = new System.Drawing.Size(854, 451);
            this.pnlMathList.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pictureBox1.Location = new System.Drawing.Point(202, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.ShadowDecoration.BorderRadius = 5;
            this.pictureBox1.ShadowDecoration.Depth = 3;
            this.pictureBox1.ShadowDecoration.Parent = this.pictureBox1;
            this.pictureBox1.Size = new System.Drawing.Size(635, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseTransparentBackground = true;
            this.pictureBox1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(420, 139);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(318, 42);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Uruchom";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(416, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "Oblicz pole figury.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(412, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pole figury";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(225, 23);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(157, 158);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lbMathApps
            // 
            this.lbMathApps.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbMathApps.FormattingEnabled = true;
            this.lbMathApps.Items.AddRange(new object[] {
            "Pole figury",
            "Konwerter długości",
            "Konwerter masy",
            "Konwerter szybkości",
            "Konwerter siły",
            "Konwerter temperatur",
            "Kalkulator liczby π"});
            this.lbMathApps.Location = new System.Drawing.Point(9, 9);
            this.lbMathApps.Name = "lbMathApps";
            this.lbMathApps.Size = new System.Drawing.Size(162, 433);
            this.lbMathApps.TabIndex = 1;
            this.lbMathApps.SelectedIndexChanged += new System.EventHandler(this.lbMathApps_SelectedIndexChanged);
            // 
            // back1
            // 
            this.back1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.back1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.back1.Image = ((System.Drawing.Image)(resources.GetObject("back1.Image")));
            this.back1.Location = new System.Drawing.Point(771, 6);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(75, 75);
            this.back1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back1.TabIndex = 0;
            this.back1.TabStop = false;
            this.back1.Tag = "back";
            this.back1.Visible = false;
            this.back1.Click += new System.EventHandler(this.back);
            // 
            // icoInfo
            // 
            this.icoInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.icoInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.icoInfo.Image = ((System.Drawing.Image)(resources.GetObject("icoInfo.Image")));
            this.icoInfo.Location = new System.Drawing.Point(396, 457);
            this.icoInfo.Name = "icoInfo";
            this.icoInfo.Size = new System.Drawing.Size(60, 60);
            this.icoInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoInfo.TabIndex = 0;
            this.icoInfo.TabStop = false;
            this.icoInfo.Click += new System.EventHandler(this.icoInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(853, 521);
            this.Controls.Add(this.pnlMathList);
            this.Controls.Add(this.icoInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fireMath";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMathList.ResumeLayout(false);
            this.pnlMathList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox icoInfo;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private System.Windows.Forms.Panel pnlMathList;
        private System.Windows.Forms.PictureBox back1;
        private System.Windows.Forms.ListBox lbMathApps;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox1;
    }
}

