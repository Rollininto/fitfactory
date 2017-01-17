namespace FitFactoryForTrainer
{
    partial class EditWorkoutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWorkoutWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.exercisesView = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.IntensityTb = new System.Windows.Forms.RichTextBox();
            this.btnAddExcercise = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.workoutView = new System.Windows.Forms.DataGridView();
            this.btnUsunCwiczenie = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.commentTb = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.colIdExercise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQueueNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIntensivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIdCwiczenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workoutView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.exercisesView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1185, 631);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // exercisesView
            // 
            this.exercisesView.AllowUserToAddRows = false;
            this.exercisesView.AllowUserToDeleteRows = false;
            this.exercisesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exercisesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNazwa});
            this.exercisesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exercisesView.Location = new System.Drawing.Point(3, 3);
            this.exercisesView.MultiSelect = false;
            this.exercisesView.Name = "exercisesView";
            this.exercisesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.exercisesView.Size = new System.Drawing.Size(586, 309);
            this.exercisesView.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNazwa
            // 
            this.colNazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNazwa.DataPropertyName = "nazwa";
            this.colNazwa.HeaderText = "Nazwa ćwiczenia";
            this.colNazwa.Name = "colNazwa";
            this.colNazwa.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.IntensityTb, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAddExcercise, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(595, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.91549F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.08451F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(587, 309);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intensywność";
            // 
            // IntensityTb
            // 
            this.IntensityTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntensityTb.Location = new System.Drawing.Point(3, 32);
            this.IntensityTb.Name = "IntensityTb";
            this.IntensityTb.Size = new System.Drawing.Size(581, 238);
            this.IntensityTb.TabIndex = 1;
            this.IntensityTb.Text = "";
            // 
            // btnAddExcercise
            // 
            this.btnAddExcercise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddExcercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddExcercise.Location = new System.Drawing.Point(3, 276);
            this.btnAddExcercise.Name = "btnAddExcercise";
            this.btnAddExcercise.Size = new System.Drawing.Size(581, 30);
            this.btnAddExcercise.TabIndex = 2;
            this.btnAddExcercise.Text = "Dodaj ćwiczenie";
            this.btnAddExcercise.UseVisualStyleBackColor = true;
            this.btnAddExcercise.Click += new System.EventHandler(this.btnAddExcercise_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.workoutView, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnUsunCwiczenie, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 318);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.52459F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.47541F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(586, 310);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ćwiczenia w treningu";
            // 
            // workoutView
            // 
            this.workoutView.AllowUserToAddRows = false;
            this.workoutView.AllowUserToDeleteRows = false;
            this.workoutView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workoutView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdExercise,
            this.colQueueNumber,
            this.colIntensivity,
            this.colDone,
            this.colIdCwiczenia});
            this.workoutView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workoutView.Location = new System.Drawing.Point(3, 26);
            this.workoutView.MultiSelect = false;
            this.workoutView.Name = "workoutView";
            this.workoutView.ReadOnly = true;
            this.workoutView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workoutView.Size = new System.Drawing.Size(580, 247);
            this.workoutView.TabIndex = 6;
            this.workoutView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.workoutView_DataBindingComplete);
            // 
            // btnUsunCwiczenie
            // 
            this.btnUsunCwiczenie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsunCwiczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsunCwiczenie.Location = new System.Drawing.Point(3, 279);
            this.btnUsunCwiczenie.Name = "btnUsunCwiczenie";
            this.btnUsunCwiczenie.Size = new System.Drawing.Size(580, 28);
            this.btnUsunCwiczenie.TabIndex = 7;
            this.btnUsunCwiczenie.Text = "Usuń ćwiczenie";
            this.btnUsunCwiczenie.UseVisualStyleBackColor = true;
            this.btnUsunCwiczenie.Click += new System.EventHandler(this.btnUsunCwiczenie_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.commentTb, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnSave, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(595, 318);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.507042F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.49296F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(587, 310);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Zapisz z komentarzem";
            // 
            // commentTb
            // 
            this.commentTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentTb.Location = new System.Drawing.Point(3, 29);
            this.commentTb.Name = "commentTb";
            this.commentTb.Size = new System.Drawing.Size(581, 243);
            this.commentTb.TabIndex = 1;
            this.commentTb.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(3, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(581, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Zapisz trening";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // colIdExercise
            // 
            this.colIdExercise.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIdExercise.DataPropertyName = "nazwa_cwicz";
            this.colIdExercise.HeaderText = "Ćwiczenie";
            this.colIdExercise.Name = "colIdExercise";
            this.colIdExercise.ReadOnly = true;
            // 
            // colQueueNumber
            // 
            this.colQueueNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQueueNumber.DataPropertyName = "num_porz";
            this.colQueueNumber.HeaderText = "Kolejność";
            this.colQueueNumber.Name = "colQueueNumber";
            this.colQueueNumber.ReadOnly = true;
            // 
            // colIntensivity
            // 
            this.colIntensivity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIntensivity.DataPropertyName = "intensywnosc";
            this.colIntensivity.HeaderText = "Intensywność";
            this.colIntensivity.Name = "colIntensivity";
            this.colIntensivity.ReadOnly = true;
            // 
            // colDone
            // 
            this.colDone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDone.DataPropertyName = "czy_odrobione";
            this.colDone.HeaderText = "Wykonanie";
            this.colDone.Name = "colDone";
            this.colDone.ReadOnly = true;
            this.colDone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colIdCwiczenia
            // 
            this.colIdCwiczenia.DataPropertyName = "id_cwicz";
            this.colIdCwiczenia.HeaderText = "Id cwiczenia";
            this.colIdCwiczenia.Name = "colIdCwiczenia";
            this.colIdCwiczenia.ReadOnly = true;
            this.colIdCwiczenia.Visible = false;
            // 
            // EditWorkoutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 631);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditWorkoutWindow";
            this.Text = "EditWorkoutWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exercisesView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workoutView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView exercisesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNazwa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox IntensityTb;
        private System.Windows.Forms.Button btnAddExcercise;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView workoutView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox commentTb;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUsunCwiczenie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdExercise;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQueueNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntensivity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCwiczenia;
    }
}