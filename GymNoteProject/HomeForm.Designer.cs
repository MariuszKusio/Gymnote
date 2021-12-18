
namespace GymNoteProject
{
    partial class HomeForm
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.LblHome1 = new System.Windows.Forms.Label();
            this.LblTips = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TBTips = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlYoutube = new System.Windows.Forms.Panel();
            this.PicYT5 = new System.Windows.Forms.PictureBox();
            this.PicYT4 = new System.Windows.Forms.PictureBox();
            this.PicYT3 = new System.Windows.Forms.PictureBox();
            this.PicYT2 = new System.Windows.Forms.PictureBox();
            this.PicYT1 = new System.Windows.Forms.PictureBox();
            this.PnlMusic = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LblYoutube = new System.Windows.Forms.Label();
            this.LblMusic = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.PicMusic1 = new System.Windows.Forms.PictureBox();
            this.PicMusic2 = new System.Windows.Forms.PictureBox();
            this.PicMusic3 = new System.Windows.Forms.PictureBox();
            this.PicMusic4 = new System.Windows.Forms.PictureBox();
            this.PicMusic5 = new System.Windows.Forms.PictureBox();
            this.PicMusic6 = new System.Windows.Forms.PictureBox();
            this.PicMusic7 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.PnlYoutube.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicYT5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicYT4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicYT3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicYT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicYT1)).BeginInit();
            this.PnlMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic7)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHome1
            // 
            this.LblHome1.AutoSize = true;
            this.LblHome1.ForeColor = System.Drawing.Color.White;
            this.LblHome1.Location = new System.Drawing.Point(6, 545);
            this.LblHome1.Name = "LblHome1";
            this.LblHome1.Size = new System.Drawing.Size(57, 13);
            this.LblHome1.TabIndex = 1;
            this.LblHome1.Text = "Tip for you";
            // 
            // LblTips
            // 
            this.LblTips.AutoSize = true;
            this.LblTips.ForeColor = System.Drawing.Color.White;
            this.LblTips.Location = new System.Drawing.Point(3, 584);
            this.LblTips.Name = "LblTips";
            this.LblTips.Size = new System.Drawing.Size(0, 13);
            this.LblTips.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(778, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Next tip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBTips
            // 
            this.TBTips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.TBTips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBTips.Cursor = System.Windows.Forms.Cursors.Default;
            this.TBTips.ForeColor = System.Drawing.SystemColors.Window;
            this.TBTips.Location = new System.Drawing.Point(1, 1);
            this.TBTips.Margin = new System.Windows.Forms.Padding(1);
            this.TBTips.Name = "TBTips";
            this.TBTips.ReadOnly = true;
            this.TBTips.Size = new System.Drawing.Size(763, 88);
            this.TBTips.TabIndex = 4;
            this.TBTips.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TBTips);
            this.panel1.Location = new System.Drawing.Point(9, 559);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 90);
            this.panel1.TabIndex = 5;
            // 
            // PnlYoutube
            // 
            this.PnlYoutube.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlYoutube.Controls.Add(this.PicYT5);
            this.PnlYoutube.Controls.Add(this.PicYT4);
            this.PnlYoutube.Controls.Add(this.PicYT3);
            this.PnlYoutube.Controls.Add(this.PicYT2);
            this.PnlYoutube.Controls.Add(this.PicYT1);
            this.PnlYoutube.Location = new System.Drawing.Point(10, 46);
            this.PnlYoutube.Name = "PnlYoutube";
            this.PnlYoutube.Size = new System.Drawing.Size(351, 434);
            this.PnlYoutube.TabIndex = 6;
            this.toolTip1.SetToolTip(this.PnlYoutube, "Click to open selected channel");
            this.PnlYoutube.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlYoutube_Paint);
            // 
            // PicYT5
            // 
            this.PicYT5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicYT5.Image = ((System.Drawing.Image)(resources.GetObject("PicYT5.Image")));
            this.PicYT5.Location = new System.Drawing.Point(25, 345);
            this.PicYT5.Name = "PicYT5";
            this.PicYT5.Size = new System.Drawing.Size(300, 65);
            this.PicYT5.TabIndex = 4;
            this.PicYT5.TabStop = false;
            this.PicYT5.Click += new System.EventHandler(this.PicYT5_Click);
            // 
            // PicYT4
            // 
            this.PicYT4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicYT4.Image = ((System.Drawing.Image)(resources.GetObject("PicYT4.Image")));
            this.PicYT4.Location = new System.Drawing.Point(25, 265);
            this.PicYT4.Name = "PicYT4";
            this.PicYT4.Size = new System.Drawing.Size(300, 65);
            this.PicYT4.TabIndex = 3;
            this.PicYT4.TabStop = false;
            this.PicYT4.Click += new System.EventHandler(this.PicYT4_Click);
            // 
            // PicYT3
            // 
            this.PicYT3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicYT3.Image = ((System.Drawing.Image)(resources.GetObject("PicYT3.Image")));
            this.PicYT3.Location = new System.Drawing.Point(25, 185);
            this.PicYT3.Name = "PicYT3";
            this.PicYT3.Size = new System.Drawing.Size(300, 65);
            this.PicYT3.TabIndex = 2;
            this.PicYT3.TabStop = false;
            this.PicYT3.Click += new System.EventHandler(this.PicYT3_Click);
            // 
            // PicYT2
            // 
            this.PicYT2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicYT2.Image = ((System.Drawing.Image)(resources.GetObject("PicYT2.Image")));
            this.PicYT2.Location = new System.Drawing.Point(25, 105);
            this.PicYT2.Name = "PicYT2";
            this.PicYT2.Size = new System.Drawing.Size(300, 65);
            this.PicYT2.TabIndex = 1;
            this.PicYT2.TabStop = false;
            this.PicYT2.Click += new System.EventHandler(this.PicYT2_Click);
            // 
            // PicYT1
            // 
            this.PicYT1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicYT1.Image = ((System.Drawing.Image)(resources.GetObject("PicYT1.Image")));
            this.PicYT1.Location = new System.Drawing.Point(25, 25);
            this.PicYT1.Name = "PicYT1";
            this.PicYT1.Size = new System.Drawing.Size(300, 65);
            this.PicYT1.TabIndex = 0;
            this.PicYT1.TabStop = false;
            this.PicYT1.Click += new System.EventHandler(this.PicYT1_Click);
            // 
            // PnlMusic
            // 
            this.PnlMusic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMusic.Controls.Add(this.PicMusic7);
            this.PnlMusic.Controls.Add(this.PicMusic6);
            this.PnlMusic.Controls.Add(this.PicMusic5);
            this.PnlMusic.Controls.Add(this.PicMusic4);
            this.PnlMusic.Controls.Add(this.PicMusic3);
            this.PnlMusic.Controls.Add(this.PicMusic2);
            this.PnlMusic.Controls.Add(this.PicMusic1);
            this.PnlMusic.Controls.Add(this.label2);
            this.PnlMusic.Location = new System.Drawing.Point(423, 46);
            this.PnlMusic.Name = "PnlMusic";
            this.PnlMusic.Size = new System.Drawing.Size(351, 434);
            this.PnlMusic.TabIndex = 7;
            this.toolTip2.SetToolTip(this.PnlMusic, "Click to open selected music");
            this.PnlMusic.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMusic_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, -17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tip for you";
            // 
            // LblYoutube
            // 
            this.LblYoutube.AutoSize = true;
            this.LblYoutube.ForeColor = System.Drawing.Color.White;
            this.LblYoutube.Location = new System.Drawing.Point(7, 30);
            this.LblYoutube.Name = "LblYoutube";
            this.LblYoutube.Size = new System.Drawing.Size(130, 13);
            this.LblYoutube.TabIndex = 8;
            this.LblYoutube.Text = "Gym tubes recomendation";
            // 
            // LblMusic
            // 
            this.LblMusic.AutoSize = true;
            this.LblMusic.ForeColor = System.Drawing.Color.White;
            this.LblMusic.Location = new System.Drawing.Point(420, 30);
            this.LblMusic.Name = "LblMusic";
            this.LblMusic.Size = new System.Drawing.Size(108, 13);
            this.LblMusic.TabIndex = 9;
            this.LblMusic.Text = "Music recomendation";
            // 
            // PicMusic1
            // 
            this.PicMusic1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMusic1.Image = ((System.Drawing.Image)(resources.GetObject("PicMusic1.Image")));
            this.PicMusic1.Location = new System.Drawing.Point(25, 20);
            this.PicMusic1.Name = "PicMusic1";
            this.PicMusic1.Size = new System.Drawing.Size(300, 50);
            this.PicMusic1.TabIndex = 10;
            this.PicMusic1.TabStop = false;
            this.PicMusic1.Click += new System.EventHandler(this.PicMusic1_Click);
            // 
            // PicMusic2
            // 
            this.PicMusic2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMusic2.Image = ((System.Drawing.Image)(resources.GetObject("PicMusic2.Image")));
            this.PicMusic2.Location = new System.Drawing.Point(25, 77);
            this.PicMusic2.Name = "PicMusic2";
            this.PicMusic2.Size = new System.Drawing.Size(300, 50);
            this.PicMusic2.TabIndex = 11;
            this.PicMusic2.TabStop = false;
            this.PicMusic2.Click += new System.EventHandler(this.PicMusic2_Click);
            // 
            // PicMusic3
            // 
            this.PicMusic3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMusic3.Image = ((System.Drawing.Image)(resources.GetObject("PicMusic3.Image")));
            this.PicMusic3.Location = new System.Drawing.Point(25, 134);
            this.PicMusic3.Name = "PicMusic3";
            this.PicMusic3.Size = new System.Drawing.Size(300, 50);
            this.PicMusic3.TabIndex = 12;
            this.PicMusic3.TabStop = false;
            this.PicMusic3.Click += new System.EventHandler(this.PicMusic3_Click);
            // 
            // PicMusic4
            // 
            this.PicMusic4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMusic4.Image = ((System.Drawing.Image)(resources.GetObject("PicMusic4.Image")));
            this.PicMusic4.Location = new System.Drawing.Point(25, 191);
            this.PicMusic4.Name = "PicMusic4";
            this.PicMusic4.Size = new System.Drawing.Size(300, 50);
            this.PicMusic4.TabIndex = 13;
            this.PicMusic4.TabStop = false;
            this.PicMusic4.Click += new System.EventHandler(this.PicMusic4_Click);
            // 
            // PicMusic5
            // 
            this.PicMusic5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMusic5.Image = ((System.Drawing.Image)(resources.GetObject("PicMusic5.Image")));
            this.PicMusic5.Location = new System.Drawing.Point(25, 248);
            this.PicMusic5.Name = "PicMusic5";
            this.PicMusic5.Size = new System.Drawing.Size(300, 50);
            this.PicMusic5.TabIndex = 14;
            this.PicMusic5.TabStop = false;
            this.PicMusic5.Click += new System.EventHandler(this.PicMusic5_Click);
            // 
            // PicMusic6
            // 
            this.PicMusic6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMusic6.Image = ((System.Drawing.Image)(resources.GetObject("PicMusic6.Image")));
            this.PicMusic6.Location = new System.Drawing.Point(25, 305);
            this.PicMusic6.Name = "PicMusic6";
            this.PicMusic6.Size = new System.Drawing.Size(300, 50);
            this.PicMusic6.TabIndex = 15;
            this.PicMusic6.TabStop = false;
            this.PicMusic6.Click += new System.EventHandler(this.PicMusic6_Click);
            // 
            // PicMusic7
            // 
            this.PicMusic7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMusic7.Image = ((System.Drawing.Image)(resources.GetObject("PicMusic7.Image")));
            this.PicMusic7.Location = new System.Drawing.Point(25, 362);
            this.PicMusic7.Name = "PicMusic7";
            this.PicMusic7.Size = new System.Drawing.Size(300, 50);
            this.PicMusic7.TabIndex = 16;
            this.PicMusic7.TabStop = false;
            this.PicMusic7.Click += new System.EventHandler(this.PicMusic7_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.LblMusic);
            this.Controls.Add(this.LblYoutube);
            this.Controls.Add(this.PnlMusic);
            this.Controls.Add(this.PnlYoutube);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblTips);
            this.Controls.Add(this.LblHome1);
            this.Name = "HomeForm";
            this.Size = new System.Drawing.Size(1044, 661);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.PnlYoutube.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicYT5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicYT4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicYT3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicYT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicYT1)).EndInit();
            this.PnlMusic.ResumeLayout(false);
            this.PnlMusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMusic7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHome1;
        private System.Windows.Forms.Label LblTips;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox TBTips;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlYoutube;
        private System.Windows.Forms.Panel PnlMusic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblYoutube;
        private System.Windows.Forms.Label LblMusic;
        private System.Windows.Forms.PictureBox PicYT5;
        private System.Windows.Forms.PictureBox PicYT4;
        private System.Windows.Forms.PictureBox PicYT3;
        private System.Windows.Forms.PictureBox PicYT2;
        private System.Windows.Forms.PictureBox PicYT1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox PicMusic7;
        private System.Windows.Forms.PictureBox PicMusic6;
        private System.Windows.Forms.PictureBox PicMusic5;
        private System.Windows.Forms.PictureBox PicMusic4;
        private System.Windows.Forms.PictureBox PicMusic3;
        private System.Windows.Forms.PictureBox PicMusic2;
        private System.Windows.Forms.PictureBox PicMusic1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}
