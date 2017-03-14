namespace FitFactoryForTrainer
{
    partial class WorkoutsWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutsWindow));
            this.workoutsView = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCwiczenia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.workoutsView)).BeginInit();
            this.SuspendLayout();
            // 
            // workoutsView
            // 
            this.workoutsView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.workoutsView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.workoutsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workoutsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colData,
            this.colCwiczenia});
            this.workoutsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workoutsView.Location = new System.Drawing.Point(0, 0);
            this.workoutsView.MultiSelect = false;
            this.workoutsView.Name = "workoutsView";
            this.workoutsView.ReadOnly = true;
            this.workoutsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workoutsView.Size = new System.Drawing.Size(812, 497);
            this.workoutsView.TabIndex = 0;
            this.workoutsView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.workoutsView_DataBindingComplete);
            this.workoutsView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.workoutsView_MouseDoubleClick);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.DataPropertyName = "id_treningu";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colData
            // 
            this.colData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colData.DataPropertyName = "data_treningu";
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colCwiczenia
            // 
            this.colCwiczenia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCwiczenia.DataPropertyName = "czy_ma_cwiczenia";
            this.colCwiczenia.HeaderText = "Cwiczenia";
            this.colCwiczenia.Name = "colCwiczenia";
            this.colCwiczenia.ReadOnly = true;
            // 
            // WorkoutsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 497);
            this.Controls.Add(this.workoutsView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkoutsWindow";
            this.Text = "Okno treningów";
            ((System.ComponentModel.ISupportInitialize)(this.workoutsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView workoutsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCwiczenia;
    }
}