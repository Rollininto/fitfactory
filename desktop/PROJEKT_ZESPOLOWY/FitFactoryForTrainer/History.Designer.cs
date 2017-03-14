namespace FitFactoryForTrainer
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.historyView = new System.Windows.Forms.DataGridView();
            this.colLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReaded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historyView)).BeginInit();
            this.SuspendLayout();
            // 
            // historyView
            // 
            this.historyView.AllowUserToAddRows = false;
            this.historyView.AllowUserToDeleteRows = false;
            this.historyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLogin,
            this.colContent,
            this.colReaded});
            this.historyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyView.Location = new System.Drawing.Point(0, 0);
            this.historyView.Name = "historyView";
            this.historyView.ReadOnly = true;
            this.historyView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyView.Size = new System.Drawing.Size(718, 659);
            this.historyView.TabIndex = 1;
            // 
            // colLogin
            // 
            this.colLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colLogin.DataPropertyName = "uzytkownik";
            this.colLogin.HeaderText = "Użytkownik";
            this.colLogin.Name = "colLogin";
            this.colLogin.ReadOnly = true;
            this.colLogin.Width = 87;
            // 
            // colContent
            // 
            this.colContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContent.DataPropertyName = "tekst";
            this.colContent.HeaderText = "Treść";
            this.colContent.Name = "colContent";
            this.colContent.ReadOnly = true;
            // 
            // colReaded
            // 
            this.colReaded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colReaded.DataPropertyName = "czy_przeczytane";
            this.colReaded.HeaderText = "Wyświetlono";
            this.colReaded.Name = "colReaded";
            this.colReaded.ReadOnly = true;
            this.colReaded.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReaded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colReaded.Width = 92;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 659);
            this.Controls.Add(this.historyView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "History";
            this.Text = "Historia";
            ((System.ComponentModel.ISupportInitialize)(this.historyView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historyView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colReaded;
    }
}