namespace FitFactoryForTrainer
{
    partial class Messenger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messenger));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.messageView = new System.Windows.Forms.DataGridView();
            this.messageTb = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReaded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.messageView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.messageTb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(851, 496);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // messageView
            // 
            this.messageView.AllowUserToAddRows = false;
            this.messageView.AllowUserToDeleteRows = false;
            this.messageView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLogin,
            this.colContent,
            this.colReaded});
            this.messageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageView.Location = new System.Drawing.Point(3, 3);
            this.messageView.Name = "messageView";
            this.messageView.ReadOnly = true;
            this.messageView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.messageView.Size = new System.Drawing.Size(845, 366);
            this.messageView.TabIndex = 0;
            // 
            // messageTb
            // 
            this.messageTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTb.Location = new System.Drawing.Point(3, 375);
            this.messageTb.Name = "messageTb";
            this.messageTb.Size = new System.Drawing.Size(845, 83);
            this.messageTb.TabIndex = 1;
            this.messageTb.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnSend, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRefresh, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 464);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(845, 29);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Location = new System.Drawing.Point(3, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(416, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Wyślij";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(425, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(417, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Messenger";
            this.Text = "Komunikator";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.messageView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView messageView;
        private System.Windows.Forms.RichTextBox messageTb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colReaded;
    }
}