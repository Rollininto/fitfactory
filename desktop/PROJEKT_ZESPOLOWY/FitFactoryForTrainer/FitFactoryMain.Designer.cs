namespace FitFactoryForTrainer
{
    partial class FitFactoryMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FitFactoryMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.usersView = new System.Windows.Forms.DataGridView();
            this.colLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdProgramu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImie2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataUr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSystematicWorkout = new System.Windows.Forms.Button();
            this.btnShowWorkout = new System.Windows.Forms.Button();
            this.btnCommunicate = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnInvites = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.59322F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.40678F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.usersView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.228758F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.77124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 633);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(954, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Panel";
            // 
            // usersView
            // 
            this.usersView.AllowUserToAddRows = false;
            this.usersView.AllowUserToDeleteRows = false;
            this.usersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLogin,
            this.colIdProgramu,
            this.colImie,
            this.colImie2,
            this.colNazwisko,
            this.colDataUr,
            this.colPlec,
            this.colCel,
            this.colMail,
            this.colOpis});
            this.usersView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersView.Location = new System.Drawing.Point(3, 35);
            this.usersView.MultiSelect = false;
            this.usersView.Name = "usersView";
            this.usersView.ReadOnly = true;
            this.usersView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersView.Size = new System.Drawing.Size(945, 574);
            this.usersView.TabIndex = 0;
            this.usersView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.usersView_MouseDoubleClick);
            // 
            // colLogin
            // 
            this.colLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLogin.DataPropertyName = "login_uz";
            this.colLogin.HeaderText = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.ReadOnly = true;
            // 
            // colIdProgramu
            // 
            this.colIdProgramu.DataPropertyName = "id_progr";
            this.colIdProgramu.HeaderText = "Program";
            this.colIdProgramu.Name = "colIdProgramu";
            this.colIdProgramu.ReadOnly = true;
            // 
            // colImie
            // 
            this.colImie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colImie.DataPropertyName = "imie_uz";
            this.colImie.HeaderText = "Imie";
            this.colImie.Name = "colImie";
            this.colImie.ReadOnly = true;
            // 
            // colImie2
            // 
            this.colImie2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colImie2.DataPropertyName = "imie2_uz";
            this.colImie2.HeaderText = "Imie2";
            this.colImie2.Name = "colImie2";
            this.colImie2.ReadOnly = true;
            // 
            // colNazwisko
            // 
            this.colNazwisko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNazwisko.DataPropertyName = "nazwisko_uz";
            this.colNazwisko.HeaderText = "Nazwisko";
            this.colNazwisko.Name = "colNazwisko";
            this.colNazwisko.ReadOnly = true;
            // 
            // colDataUr
            // 
            this.colDataUr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDataUr.DataPropertyName = "data_ur_uz";
            this.colDataUr.HeaderText = "Data ur";
            this.colDataUr.Name = "colDataUr";
            this.colDataUr.ReadOnly = true;
            // 
            // colPlec
            // 
            this.colPlec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlec.DataPropertyName = "plec_uz";
            this.colPlec.HeaderText = "Plec";
            this.colPlec.Name = "colPlec";
            this.colPlec.ReadOnly = true;
            // 
            // colCel
            // 
            this.colCel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCel.DataPropertyName = "nazwa_celu";
            this.colCel.HeaderText = "Cel";
            this.colCel.Name = "colCel";
            this.colCel.ReadOnly = true;
            // 
            // colMail
            // 
            this.colMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMail.HeaderText = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.ReadOnly = true;
            // 
            // colOpis
            // 
            this.colOpis.DataPropertyName = "opis";
            this.colOpis.HeaderText = "Opis";
            this.colOpis.Name = "colOpis";
            this.colOpis.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(945, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Przypisani użytkownicy";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnSystematicWorkout, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnShowWorkout, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnCommunicate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnHistory, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteUser, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnInvites, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnSettings, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(954, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(223, 574);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnSystematicWorkout
            // 
            this.btnSystematicWorkout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSystematicWorkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSystematicWorkout.Location = new System.Drawing.Point(3, 327);
            this.btnSystematicWorkout.Name = "btnSystematicWorkout";
            this.btnSystematicWorkout.Size = new System.Drawing.Size(217, 75);
            this.btnSystematicWorkout.TabIndex = 3;
            this.btnSystematicWorkout.Text = "Treningi systematyczne";
            this.btnSystematicWorkout.UseVisualStyleBackColor = true;
            // 
            // btnShowWorkout
            // 
            this.btnShowWorkout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowWorkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowWorkout.Location = new System.Drawing.Point(3, 165);
            this.btnShowWorkout.Name = "btnShowWorkout";
            this.btnShowWorkout.Size = new System.Drawing.Size(217, 75);
            this.btnShowWorkout.TabIndex = 2;
            this.btnShowWorkout.Text = "Wyświetl treningi";
            this.btnShowWorkout.UseVisualStyleBackColor = true;
            this.btnShowWorkout.Click += new System.EventHandler(this.btnShowWorkout_Click);
            // 
            // btnCommunicate
            // 
            this.btnCommunicate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCommunicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCommunicate.Location = new System.Drawing.Point(3, 3);
            this.btnCommunicate.Name = "btnCommunicate";
            this.btnCommunicate.Size = new System.Drawing.Size(217, 75);
            this.btnCommunicate.TabIndex = 0;
            this.btnCommunicate.Text = "Komunikator";
            this.btnCommunicate.UseVisualStyleBackColor = true;
            this.btnCommunicate.Click += new System.EventHandler(this.btnCommunicate_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHistory.Location = new System.Drawing.Point(3, 84);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(217, 75);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "Archiwum";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteUser.Location = new System.Drawing.Point(3, 246);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(217, 75);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Usuń użytkownika";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnInvites
            // 
            this.btnInvites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInvites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInvites.Location = new System.Drawing.Point(3, 408);
            this.btnInvites.Name = "btnInvites";
            this.btnInvites.Size = new System.Drawing.Size(217, 75);
            this.btnInvites.TabIndex = 5;
            this.btnInvites.Text = "Zaproszenia";
            this.btnInvites.UseVisualStyleBackColor = true;
            this.btnInvites.Click += new System.EventHandler(this.btnInvites_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.Location = new System.Drawing.Point(3, 489);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(217, 82);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Ustawienia";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // FitFactoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 633);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FitFactoryMain";
            this.Text = "FitFactory";
            this.Load += new System.EventHandler(this.FitFactoryMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView usersView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSystematicWorkout;
        private System.Windows.Forms.Button btnShowWorkout;
        private System.Windows.Forms.Button btnCommunicate;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnInvites;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProgramu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImie2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataUr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpis;
    }
}