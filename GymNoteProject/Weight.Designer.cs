
namespace GymNoteProject
{
    partial class Weight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weight));
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnExercises = new FontAwesome.Sharp.IconButton();
            this.BtnWeight = new FontAwesome.Sharp.IconButton();
            this.BtnHome = new FontAwesome.Sharp.IconButton();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.LblLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlTopBar = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.PnlHome = new System.Windows.Forms.Panel();
            this.exercisesForm2 = new GymNoteProject.ExercisesForm();
            this.homeForm1 = new GymNoteProject.HomeForm();
            this.exercisesForm1 = new GymNoteProject.ExercisesForm();
            this.exercisesForm = new GymNoteProject.ExercisesForm();
            this.homeForm = new GymNoteProject.HomeForm();
            this.weightForm = new GymNoteProject.WeightForm();
            this.PnlMenu.SuspendLayout();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlTopBar.SuspendLayout();
            this.PnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PnlMenu.Controls.Add(this.BtnExercises);
            this.PnlMenu.Controls.Add(this.BtnWeight);
            this.PnlMenu.Controls.Add(this.BtnHome);
            this.PnlMenu.Controls.Add(this.PnlLogo);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(220, 681);
            this.PnlMenu.TabIndex = 0;
           
            // 
            // BtnExercises
            // 
            this.BtnExercises.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnExercises.FlatAppearance.BorderSize = 0;
            this.BtnExercises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExercises.ForeColor = System.Drawing.Color.White;
            this.BtnExercises.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.BtnExercises.IconColor = System.Drawing.Color.White;
            this.BtnExercises.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExercises.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExercises.Location = new System.Drawing.Point(0, 260);
            this.BtnExercises.Name = "BtnExercises";
            this.BtnExercises.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnExercises.Size = new System.Drawing.Size(220, 60);
            this.BtnExercises.TabIndex = 3;
            this.BtnExercises.Text = "Exercises";
            this.BtnExercises.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExercises.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExercises.UseVisualStyleBackColor = true;
            this.BtnExercises.Click += new System.EventHandler(this.BtnExercises_Click);
            // 
            // BtnWeight
            // 
            this.BtnWeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnWeight.FlatAppearance.BorderSize = 0;
            this.BtnWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWeight.ForeColor = System.Drawing.Color.White;
            this.BtnWeight.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.BtnWeight.IconColor = System.Drawing.Color.White;
            this.BtnWeight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnWeight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWeight.Location = new System.Drawing.Point(0, 200);
            this.BtnWeight.Name = "BtnWeight";
            this.BtnWeight.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnWeight.Size = new System.Drawing.Size(220, 60);
            this.BtnWeight.TabIndex = 2;
            this.BtnWeight.Text = "Weight";
            this.BtnWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWeight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnWeight.UseVisualStyleBackColor = true;
            this.BtnWeight.Click += new System.EventHandler(this.BtnWeight_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.BtnHome.IconColor = System.Drawing.Color.White;
            this.BtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(0, 140);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnHome.Size = new System.Drawing.Size(220, 60);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PnlLogo
            // 
            this.PnlLogo.Controls.Add(this.LblLogo);
            this.PnlLogo.Controls.Add(this.pictureBox1);
            this.PnlLogo.Controls.Add(this.panel1);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(220, 140);
            this.PnlLogo.TabIndex = 0;
            // 
            // LblLogo
            // 
            this.LblLogo.AutoSize = true;
            this.LblLogo.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblLogo.ForeColor = System.Drawing.Color.White;
            this.LblLogo.Location = new System.Drawing.Point(63, 9);
            this.LblLogo.Name = "LblLogo";
            this.LblLogo.Size = new System.Drawing.Size(95, 25);
            this.LblLogo.TabIndex = 5;
            this.LblLogo.Text = "GymNote";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 681);
            this.panel1.TabIndex = 2;
            // 
            // PnlTopBar
            // 
            this.PnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.PnlTopBar.Controls.Add(this.BtnClose);
            this.PnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTopBar.Location = new System.Drawing.Point(220, 0);
            this.PnlTopBar.Name = "PnlTopBar";
            this.PnlTopBar.Size = new System.Drawing.Size(1044, 20);
            this.PnlTopBar.TabIndex = 1;
            this.PnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTopBar_MouseDown);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 20;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(1014, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnClose.Size = new System.Drawing.Size(30, 20);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PnlHome
            // 
            this.PnlHome.Controls.Add(this.exercisesForm2);
            this.PnlHome.Controls.Add(this.homeForm1);
            this.PnlHome.Controls.Add(this.exercisesForm1);
            this.PnlHome.Controls.Add(this.exercisesForm);
            this.PnlHome.Controls.Add(this.homeForm);
            this.PnlHome.Controls.Add(this.weightForm);
            this.PnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlHome.Location = new System.Drawing.Point(220, 20);
            this.PnlHome.Name = "PnlHome";
            this.PnlHome.Size = new System.Drawing.Size(1044, 661);
            this.PnlHome.TabIndex = 2;
            this.PnlHome.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHome_Paint);
            // 
            // exercisesForm2
            // 
            this.exercisesForm2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.exercisesForm2.Location = new System.Drawing.Point(0, 0);
            this.exercisesForm2.Name = "exercisesForm2";
            this.exercisesForm2.Size = new System.Drawing.Size(1044, 661);
            this.exercisesForm2.TabIndex = 4;
            // 
            // homeForm1
            // 
            this.homeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.homeForm1.Location = new System.Drawing.Point(0, 0);
            this.homeForm1.Name = "homeForm1";
            this.homeForm1.Size = new System.Drawing.Size(1044, 661);
            this.homeForm1.TabIndex = 3;
            // 
            // exercisesForm1
            // 
            this.exercisesForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.exercisesForm1.Location = new System.Drawing.Point(0, 0);
            this.exercisesForm1.Name = "exercisesForm1";
            this.exercisesForm1.Size = new System.Drawing.Size(1044, 661);
            this.exercisesForm1.TabIndex = 2;
            // 
            // exercisesForm
            // 
            this.exercisesForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.exercisesForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exercisesForm.Location = new System.Drawing.Point(0, 0);
            this.exercisesForm.Name = "exercisesForm";
            this.exercisesForm.Size = new System.Drawing.Size(1044, 661);
            this.exercisesForm.TabIndex = 1;
            // 
            // homeForm
            // 
            this.homeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.homeForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeForm.Location = new System.Drawing.Point(0, 0);
            this.homeForm.Name = "homeForm";
            this.homeForm.Size = new System.Drawing.Size(1044, 661);
            this.homeForm.TabIndex = 0;
            // 
            // weightForm
            // 
            this.weightForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.weightForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weightForm.Location = new System.Drawing.Point(0, 0);
            this.weightForm.Name = "weightForm";
            this.weightForm.Size = new System.Drawing.Size(1044, 661);
            this.weightForm.TabIndex = 0;
            // 
            // Weight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PnlHome);
            this.Controls.Add(this.PnlTopBar);
            this.Controls.Add(this.PnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Weight";
            this.Text = "Form1";
            this.PnlMenu.ResumeLayout(false);
            this.PnlLogo.ResumeLayout(false);
            this.PnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlTopBar.ResumeLayout(false);
            this.PnlHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private FontAwesome.Sharp.IconButton BtnExercises;
        private FontAwesome.Sharp.IconButton BtnWeight;
        private FontAwesome.Sharp.IconButton BtnHome;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.Panel PnlTopBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlHome;
        private HomeForm homeForm;
        private ExercisesForm exercisesForm;
        private WeightForm weightForm;
        private FontAwesome.Sharp.IconButton BtnClose;
        private ExercisesForm exercisesForm2;
        private HomeForm homeForm1;
        private ExercisesForm exercisesForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblLogo;
    }
}