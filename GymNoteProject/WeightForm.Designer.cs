
namespace GymNoteProject
{
    partial class WeightForm
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
            this.LblWeight1 = new System.Windows.Forms.Label();
            this.BoxWightAdd = new System.Windows.Forms.TextBox();
            this.BtnWeightAdd = new System.Windows.Forms.Button();
            this.TbWeight = new System.Windows.Forms.DataGridView();
            this.BtnDeleteRow = new System.Windows.Forms.Button();
            this.BoxDeleteWeight = new System.Windows.Forms.TextBox();
            this.modelDataSet = new GymNoteProject.ModelDataSet();
            this.excercisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excercisesTableAdapter = new GymNoteProject.ModelDataSetTableAdapters.ExcercisesTableAdapter();
            this.myDatabaseDataSet = new GymNoteProject.MyDatabaseDataSet();
            this.weightTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weightTable1TableAdapter = new GymNoteProject.MyDatabaseDataSetTableAdapters.WeightTable1TableAdapter();
            this.wIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TbWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excercisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWeight1
            // 
            this.LblWeight1.AutoSize = true;
            this.LblWeight1.ForeColor = System.Drawing.Color.White;
            this.LblWeight1.Location = new System.Drawing.Point(15, 605);
            this.LblWeight1.Name = "LblWeight1";
            this.LblWeight1.Size = new System.Drawing.Size(89, 13);
            this.LblWeight1.TabIndex = 0;
            this.LblWeight1.Text = "Enter your weight";
            // 
            // BoxWightAdd
            // 
            this.BoxWightAdd.BackColor = System.Drawing.Color.White;
            this.BoxWightAdd.ForeColor = System.Drawing.Color.Black;
            this.BoxWightAdd.Location = new System.Drawing.Point(18, 621);
            this.BoxWightAdd.Name = "BoxWightAdd";
            this.BoxWightAdd.Size = new System.Drawing.Size(100, 20);
            this.BoxWightAdd.TabIndex = 3;
            this.toolTip1.SetToolTip(this.BoxWightAdd, "Enter your weight in kg or lbs. Write decimal numbers after \".\"");
            // 
            // BtnWeightAdd
            // 
            this.BtnWeightAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWeightAdd.ForeColor = System.Drawing.Color.White;
            this.BtnWeightAdd.Location = new System.Drawing.Point(124, 619);
            this.BtnWeightAdd.Name = "BtnWeightAdd";
            this.BtnWeightAdd.Size = new System.Drawing.Size(58, 23);
            this.BtnWeightAdd.TabIndex = 4;
            this.BtnWeightAdd.Text = "Add";
            this.BtnWeightAdd.UseVisualStyleBackColor = true;
            this.BtnWeightAdd.Click += new System.EventHandler(this.BtnWeightAdd_Click_1);
            // 
            // TbWeight
            // 
            this.TbWeight.AllowUserToResizeRows = false;
            this.TbWeight.AutoGenerateColumns = false;
            this.TbWeight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.TbWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbWeight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.TbWeight.DataSource = this.weightTable1BindingSource;
            this.TbWeight.Location = new System.Drawing.Point(18, 15);
            this.TbWeight.Name = "TbWeight";
            this.TbWeight.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbWeight.Size = new System.Drawing.Size(332, 587);
            this.TbWeight.TabIndex = 5;
            this.TbWeight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TbWeight_CellClick_1);
            // 
            // BtnDeleteRow
            // 
            this.BtnDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteRow.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteRow.Location = new System.Drawing.Point(223, 619);
            this.BtnDeleteRow.Name = "BtnDeleteRow";
            this.BtnDeleteRow.Size = new System.Drawing.Size(127, 23);
            this.BtnDeleteRow.TabIndex = 9;
            this.BtnDeleteRow.Text = "Delete selected row";
            this.BtnDeleteRow.UseVisualStyleBackColor = true;
            this.BtnDeleteRow.Click += new System.EventHandler(this.BtnDeleteRow_Click_1);
            // 
            // BoxDeleteWeight
            // 
            this.BoxDeleteWeight.BackColor = System.Drawing.Color.White;
            this.BoxDeleteWeight.ForeColor = System.Drawing.Color.Black;
            this.BoxDeleteWeight.Location = new System.Drawing.Point(893, 621);
            this.BoxDeleteWeight.Name = "BoxDeleteWeight";
            this.BoxDeleteWeight.Size = new System.Drawing.Size(100, 20);
            this.BoxDeleteWeight.TabIndex = 11;
            this.BoxDeleteWeight.Visible = false;
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // excercisesBindingSource
            // 
            this.excercisesBindingSource.DataMember = "Excercises";
            this.excercisesBindingSource.DataSource = this.modelDataSet;
            // 
            // excercisesTableAdapter
            // 
            this.excercisesTableAdapter.ClearBeforeFill = true;
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // weightTable1BindingSource
            // 
            this.weightTable1BindingSource.DataMember = "WeightTable1";
            this.weightTable1BindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // weightTable1TableAdapter
            // 
            this.weightTable1TableAdapter.ClearBeforeFill = true;
            // 
            // wIDDataGridViewTextBoxColumn
            // 
            this.wIDDataGridViewTextBoxColumn.DataPropertyName = "WID";
            this.wIDDataGridViewTextBoxColumn.HeaderText = "WID";
            this.wIDDataGridViewTextBoxColumn.Name = "wIDDataGridViewTextBoxColumn";
            this.wIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 160;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 129;
            // 
            // WeightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.BoxDeleteWeight);
            this.Controls.Add(this.BtnDeleteRow);
            this.Controls.Add(this.TbWeight);
            this.Controls.Add(this.BtnWeightAdd);
            this.Controls.Add(this.BoxWightAdd);
            this.Controls.Add(this.LblWeight1);
            this.Name = "WeightForm";
            this.Size = new System.Drawing.Size(1044, 661);
            this.Load += new System.EventHandler(this.WeightForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.TbWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excercisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWeight1;
        private System.Windows.Forms.TextBox BoxWightAdd;
        private System.Windows.Forms.Button BtnWeightAdd;
        private System.Windows.Forms.DataGridView TbWeight;
        private System.Windows.Forms.Button BtnDeleteRow;
        private System.Windows.Forms.TextBox BoxDeleteWeight;
        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource excercisesBindingSource;
        private ModelDataSetTableAdapters.ExcercisesTableAdapter excercisesTableAdapter;
        private System.Windows.Forms.BindingSource weightTable1BindingSource;
        private MyDatabaseDataSet myDatabaseDataSet;
        private MyDatabaseDataSetTableAdapters.WeightTable1TableAdapter weightTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
