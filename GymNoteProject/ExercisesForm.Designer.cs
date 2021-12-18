
namespace GymNoteProject
{
    partial class ExercisesForm
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
            this.excercisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelDataSet = new GymNoteProject.ModelDataSet();
            this.BoxExIDAdd = new System.Windows.Forms.TextBox();
            this.BoxExNameAdd = new System.Windows.Forms.TextBox();
            this.BoxExIDUp = new System.Windows.Forms.TextBox();
            this.BoxSeries = new System.Windows.Forms.TextBox();
            this.BoxRepeat = new System.Windows.Forms.TextBox();
            this.BtnNameAdd = new System.Windows.Forms.Button();
            this.lblWeight1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxLoad = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.excercisesTableAdapter = new GymNoteProject.ModelDataSetTableAdapters.ExcercisesTableAdapter();
            this.tableAdapterManager = new GymNoteProject.ModelDataSetTableAdapters.TableAdapterManager();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BoxDayPicker = new System.Windows.Forms.ComboBox();
            this.lblday = new System.Windows.Forms.Label();
            this.TbExList = new System.Windows.Forms.DataGridView();
            this.exIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exSeriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exRepeatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excercisesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabaseDataSet1 = new GymNoteProject.MyDatabaseDataSet1();
            this.excercisesTableAdapter1 = new GymNoteProject.MyDatabaseDataSet1TableAdapters.ExcercisesTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.excercisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbExList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excercisesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // excercisesBindingSource
            // 
            this.excercisesBindingSource.DataMember = "Excercises";
            this.excercisesBindingSource.DataSource = this.modelDataSet;
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BoxExIDAdd
            // 
            this.BoxExIDAdd.BackColor = System.Drawing.Color.White;
            this.BoxExIDAdd.ForeColor = System.Drawing.Color.Black;
            this.BoxExIDAdd.Location = new System.Drawing.Point(122, 95);
            this.BoxExIDAdd.Name = "BoxExIDAdd";
            this.BoxExIDAdd.Size = new System.Drawing.Size(100, 20);
            this.BoxExIDAdd.TabIndex = 7;
            
            // 
            // BoxExNameAdd
            // 
            this.BoxExNameAdd.BackColor = System.Drawing.Color.White;
            this.BoxExNameAdd.ForeColor = System.Drawing.Color.Black;
            this.BoxExNameAdd.Location = new System.Drawing.Point(122, 130);
            this.BoxExNameAdd.Name = "BoxExNameAdd";
            this.BoxExNameAdd.Size = new System.Drawing.Size(100, 20);
            this.BoxExNameAdd.TabIndex = 8;
            
            // 
            // BoxExIDUp
            // 
            this.BoxExIDUp.BackColor = System.Drawing.Color.White;
            this.BoxExIDUp.ForeColor = System.Drawing.Color.Black;
            this.BoxExIDUp.Location = new System.Drawing.Point(122, 278);
            this.BoxExIDUp.Name = "BoxExIDUp";
            this.BoxExIDUp.Size = new System.Drawing.Size(100, 20);
            this.BoxExIDUp.TabIndex = 9;
           
            // 
            // BoxSeries
            // 
            this.BoxSeries.BackColor = System.Drawing.Color.White;
            this.BoxSeries.ForeColor = System.Drawing.Color.Black;
            this.BoxSeries.Location = new System.Drawing.Point(122, 313);
            this.BoxSeries.Name = "BoxSeries";
            this.BoxSeries.Size = new System.Drawing.Size(100, 20);
            this.BoxSeries.TabIndex = 10;
            
            // 
            // BoxRepeat
            // 
            this.BoxRepeat.BackColor = System.Drawing.Color.White;
            this.BoxRepeat.ForeColor = System.Drawing.Color.Black;
            this.BoxRepeat.Location = new System.Drawing.Point(122, 348);
            this.BoxRepeat.Name = "BoxRepeat";
            this.BoxRepeat.Size = new System.Drawing.Size(100, 20);
            this.BoxRepeat.TabIndex = 11;
          
            // 
            // BtnNameAdd
            // 
            this.BtnNameAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNameAdd.ForeColor = System.Drawing.Color.White;
            this.BtnNameAdd.Location = new System.Drawing.Point(164, 163);
            this.BtnNameAdd.Name = "BtnNameAdd";
            this.BtnNameAdd.Size = new System.Drawing.Size(58, 23);
            this.BtnNameAdd.TabIndex = 12;
            this.BtnNameAdd.Text = "Add";
            this.BtnNameAdd.UseVisualStyleBackColor = true;
            this.BtnNameAdd.Click += new System.EventHandler(this.BtnNameAdd_Click);
            // 
            // lblWeight1
            // 
            this.lblWeight1.AutoSize = true;
            this.lblWeight1.ForeColor = System.Drawing.Color.White;
            this.lblWeight1.Location = new System.Drawing.Point(13, 137);
            this.lblWeight1.Name = "lblWeight1";
            this.lblWeight1.Size = new System.Drawing.Size(103, 13);
            this.lblWeight1.TabIndex = 13;
            this.lblWeight1.Text = "Enter exercise name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Exercises list";
           
            // 
            // BoxLoad
            // 
            this.BoxLoad.BackColor = System.Drawing.Color.White;
            this.BoxLoad.ForeColor = System.Drawing.Color.Black;
            this.BoxLoad.Location = new System.Drawing.Point(122, 383);
            this.BoxLoad.Name = "BoxLoad";
            this.BoxLoad.Size = new System.Drawing.Size(100, 20);
            this.BoxLoad.TabIndex = 15;
            this.toolTip1.SetToolTip(this.BoxLoad, "Write decimal numbers after \".\"");
            
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(122, 453);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(58, 23);
            this.BtnUpdate.TabIndex = 16;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Exercise ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Exercise ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Series";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Repeat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Load in kg";
            // 
            // excercisesTableAdapter
            // 
            this.excercisesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExcercisesTableAdapter = this.excercisesTableAdapter;
            this.tableAdapterManager.UpdateOrder = GymNoteProject.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BtnDelete
            // 
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(164, 197);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(58, 23);
            this.BtnDelete.TabIndex = 22;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BoxDayPicker
            // 
            this.BoxDayPicker.FormattingEnabled = true;
            this.BoxDayPicker.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.BoxDayPicker.Location = new System.Drawing.Point(122, 418);
            this.BoxDayPicker.Name = "BoxDayPicker";
            this.BoxDayPicker.Size = new System.Drawing.Size(121, 21);
            this.BoxDayPicker.TabIndex = 23;
            this.BoxDayPicker.Text = "Select Day";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.ForeColor = System.Drawing.Color.White;
            this.lblday.Location = new System.Drawing.Point(35, 426);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(26, 13);
            this.lblday.TabIndex = 24;
            this.lblday.Text = "Day";
            // 
            // TbExList
            // 
            this.TbExList.AllowUserToResizeRows = false;
            this.TbExList.AutoGenerateColumns = false;
            this.TbExList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.TbExList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbExList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exIDDataGridViewTextBoxColumn,
            this.exNameDataGridViewTextBoxColumn,
            this.exSeriesDataGridViewTextBoxColumn,
            this.exRepeatDataGridViewTextBoxColumn,
            this.exKgDataGridViewTextBoxColumn,
            this.ExDay});
            this.TbExList.DataSource = this.excercisesBindingSource1;
            this.TbExList.Location = new System.Drawing.Point(270, 59);
            this.TbExList.Name = "TbExList";
            this.TbExList.Size = new System.Drawing.Size(759, 585);
            this.TbExList.TabIndex = 25;
            this.TbExList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TbExList_CellClick);
            // 
            // exIDDataGridViewTextBoxColumn
            // 
            this.exIDDataGridViewTextBoxColumn.DataPropertyName = "ExID";
            this.exIDDataGridViewTextBoxColumn.HeaderText = "ExID";
            this.exIDDataGridViewTextBoxColumn.Name = "exIDDataGridViewTextBoxColumn";
            this.exIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // exNameDataGridViewTextBoxColumn
            // 
            this.exNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.exNameDataGridViewTextBoxColumn.DataPropertyName = "ExName";
            this.exNameDataGridViewTextBoxColumn.HeaderText = "ExName";
            this.exNameDataGridViewTextBoxColumn.Name = "exNameDataGridViewTextBoxColumn";
            // 
            // exSeriesDataGridViewTextBoxColumn
            // 
            this.exSeriesDataGridViewTextBoxColumn.DataPropertyName = "ExSeries";
            this.exSeriesDataGridViewTextBoxColumn.HeaderText = "ExSeries";
            this.exSeriesDataGridViewTextBoxColumn.Name = "exSeriesDataGridViewTextBoxColumn";
            this.exSeriesDataGridViewTextBoxColumn.Width = 75;
            // 
            // exRepeatDataGridViewTextBoxColumn
            // 
            this.exRepeatDataGridViewTextBoxColumn.DataPropertyName = "ExRepeat";
            this.exRepeatDataGridViewTextBoxColumn.HeaderText = "ExRepeat";
            this.exRepeatDataGridViewTextBoxColumn.Name = "exRepeatDataGridViewTextBoxColumn";
            this.exRepeatDataGridViewTextBoxColumn.Width = 75;
            // 
            // exKgDataGridViewTextBoxColumn
            // 
            this.exKgDataGridViewTextBoxColumn.DataPropertyName = "ExKg";
            this.exKgDataGridViewTextBoxColumn.HeaderText = "ExKg";
            this.exKgDataGridViewTextBoxColumn.Name = "exKgDataGridViewTextBoxColumn";
            this.exKgDataGridViewTextBoxColumn.Width = 75;
            // 
            // ExDay
            // 
            this.ExDay.DataPropertyName = "ExDay";
            this.ExDay.HeaderText = "ExDay";
            this.ExDay.Name = "ExDay";
            this.ExDay.Width = 75;
            // 
            // excercisesBindingSource1
            // 
            this.excercisesBindingSource1.DataMember = "Excercises";
            this.excercisesBindingSource1.DataSource = this.myDatabaseDataSet1;
            // 
            // myDatabaseDataSet1
            // 
            this.myDatabaseDataSet1.DataSetName = "MyDatabaseDataSet1";
            this.myDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // excercisesTableAdapter1
            // 
            this.excercisesTableAdapter1.ClearBeforeFill = true;
            // 
            // ExercisesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.TbExList);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.BoxDayPicker);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BoxLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWeight1);
            this.Controls.Add(this.BtnNameAdd);
            this.Controls.Add(this.BoxRepeat);
            this.Controls.Add(this.BoxSeries);
            this.Controls.Add(this.BoxExIDUp);
            this.Controls.Add(this.BoxExNameAdd);
            this.Controls.Add(this.BoxExIDAdd);
            this.Name = "ExercisesForm";
            this.Size = new System.Drawing.Size(1044, 661);
            this.Load += new System.EventHandler(this.ExercisesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.excercisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbExList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excercisesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BoxExIDAdd;
        private System.Windows.Forms.TextBox BoxExNameAdd;
        private System.Windows.Forms.TextBox BoxExIDUp;
        private System.Windows.Forms.TextBox BoxSeries;
        private System.Windows.Forms.TextBox BoxRepeat;
        private System.Windows.Forms.Button BtnNameAdd;
        private System.Windows.Forms.Label lblWeight1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxLoad;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource excercisesBindingSource;
        private ModelDataSet modelDataSet;
        private ModelDataSetTableAdapters.ExcercisesTableAdapter excercisesTableAdapter;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ComboBox BoxDayPicker;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.DataGridView TbExList;
        private System.Windows.Forms.DataGridViewTextBoxColumn exIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exSeriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exRepeatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExDay;
        private System.Windows.Forms.BindingSource excercisesBindingSource1;
        private MyDatabaseDataSet1 myDatabaseDataSet1;
        private MyDatabaseDataSet1TableAdapters.ExcercisesTableAdapter excercisesTableAdapter1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
