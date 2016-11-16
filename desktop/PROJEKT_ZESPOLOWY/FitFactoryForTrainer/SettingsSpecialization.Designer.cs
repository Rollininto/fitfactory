namespace FitFactoryForTrainer
{
    partial class SettingsSpecialization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsSpecialization));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddSpec = new System.Windows.Forms.Button();
            this.btnRemoveSpec = new System.Windows.Forms.Button();
            this.allSpecView = new System.Windows.Forms.DataGridView();
            this.mySpecView = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colmyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmyNazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmyOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allSpecView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySpecView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveSpec, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.allSpecView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mySpecView, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAddSpec, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.89208F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.13665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.991429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.994286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.13665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.848912F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 620);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAddSpec
            // 
            this.btnAddSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddSpec.Location = new System.Drawing.Point(3, 275);
            this.btnAddSpec.Name = "btnAddSpec";
            this.btnAddSpec.Size = new System.Drawing.Size(903, 31);
            this.btnAddSpec.TabIndex = 0;
            this.btnAddSpec.Text = "Dodaj specjalizacje";
            this.btnAddSpec.UseVisualStyleBackColor = true;
            this.btnAddSpec.Click += new System.EventHandler(this.btnAddSpec_Click);
            // 
            // btnRemoveSpec
            // 
            this.btnRemoveSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemoveSpec.Location = new System.Drawing.Point(3, 578);
            this.btnRemoveSpec.Name = "btnRemoveSpec";
            this.btnRemoveSpec.Size = new System.Drawing.Size(903, 39);
            this.btnRemoveSpec.TabIndex = 1;
            this.btnRemoveSpec.Text = "Usuń specjalizacje";
            this.btnRemoveSpec.UseVisualStyleBackColor = true;
            this.btnRemoveSpec.Click += new System.EventHandler(this.btnRemoveSpec_Click);
            // 
            // allSpecView
            // 
            this.allSpecView.AllowUserToAddRows = false;
            this.allSpecView.AllowUserToDeleteRows = false;
            this.allSpecView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allSpecView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNazwa,
            this.colOpis});
            this.allSpecView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSpecView.Location = new System.Drawing.Point(3, 33);
            this.allSpecView.Name = "allSpecView";
            this.allSpecView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allSpecView.Size = new System.Drawing.Size(903, 236);
            this.allSpecView.TabIndex = 2;
            // 
            // mySpecView
            // 
            this.mySpecView.AllowUserToAddRows = false;
            this.mySpecView.AllowUserToDeleteRows = false;
            this.mySpecView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mySpecView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmyId,
            this.colmyNazwa,
            this.colmyOpis});
            this.mySpecView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mySpecView.Location = new System.Drawing.Point(3, 336);
            this.mySpecView.MultiSelect = false;
            this.mySpecView.Name = "mySpecView";
            this.mySpecView.ReadOnly = true;
            this.mySpecView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mySpecView.Size = new System.Drawing.Size(903, 236);
            this.mySpecView.TabIndex = 3;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            // 
            // colNazwa
            // 
            this.colNazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNazwa.DataPropertyName = "nazwa";
            this.colNazwa.HeaderText = "Nazwa";
            this.colNazwa.Name = "colNazwa";
            // 
            // colOpis
            // 
            this.colOpis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOpis.DataPropertyName = "opis";
            this.colOpis.HeaderText = "Opis";
            this.colOpis.Name = "colOpis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Specjalizacje do wyboru";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(903, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Moje specjalizacje";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colmyId
            // 
            this.colmyId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colmyId.DataPropertyName = "id_spec";
            this.colmyId.HeaderText = "Id";
            this.colmyId.Name = "colmyId";
            this.colmyId.ReadOnly = true;
            // 
            // colmyNazwa
            // 
            this.colmyNazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colmyNazwa.DataPropertyName = "nazwa_spec";
            this.colmyNazwa.HeaderText = "Nazwa";
            this.colmyNazwa.Name = "colmyNazwa";
            this.colmyNazwa.ReadOnly = true;
            // 
            // colmyOpis
            // 
            this.colmyOpis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colmyOpis.DataPropertyName = "opis_spec";
            this.colmyOpis.HeaderText = "Opis";
            this.colmyOpis.Name = "colmyOpis";
            this.colmyOpis.ReadOnly = true;
            // 
            // SettingsSpecialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsSpecialization";
            this.Text = "SettingsSpecjalizacje";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allSpecView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySpecView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddSpec;
        private System.Windows.Forms.Button btnRemoveSpec;
        private System.Windows.Forms.DataGridView allSpecView;
        private System.Windows.Forms.DataGridView mySpecView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmyNazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmyOpis;
    }
}