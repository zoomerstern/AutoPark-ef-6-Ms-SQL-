
namespace AutoPark
{
    partial class MotorJobs
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
            this.bmotor = new System.Windows.Forms.Button();
            this.bDmotor = new System.Windows.Forms.Button();
            this.bEmotor = new System.Windows.Forms.Button();
            this.tEmotor = new System.Windows.Forms.TextBox();
            this.bDjob = new System.Windows.Forms.Button();
            this.bEjob = new System.Windows.Forms.Button();
            this.tEjob = new System.Windows.Forms.TextBox();
            this.lEmark = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bClose = new System.Windows.Forms.Button();
            this.bjob = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bmotor
            // 
            this.bmotor.Location = new System.Drawing.Point(12, 71);
            this.bmotor.Name = "bmotor";
            this.bmotor.Size = new System.Drawing.Size(75, 23);
            this.bmotor.TabIndex = 50;
            this.bmotor.Text = "Добавить";
            this.bmotor.UseVisualStyleBackColor = true;
            this.bmotor.Click += new System.EventHandler(this.Bmotor_Click);
            // 
            // bDmotor
            // 
            this.bDmotor.Location = new System.Drawing.Point(230, 71);
            this.bDmotor.Name = "bDmotor";
            this.bDmotor.Size = new System.Drawing.Size(75, 23);
            this.bDmotor.TabIndex = 49;
            this.bDmotor.Text = "Удалить";
            this.bDmotor.UseVisualStyleBackColor = true;
            this.bDmotor.Click += new System.EventHandler(this.bDmotor_Click);
            // 
            // bEmotor
            // 
            this.bEmotor.Location = new System.Drawing.Point(120, 71);
            this.bEmotor.Name = "bEmotor";
            this.bEmotor.Size = new System.Drawing.Size(75, 23);
            this.bEmotor.TabIndex = 48;
            this.bEmotor.Text = "Изменить";
            this.bEmotor.UseVisualStyleBackColor = true;
            this.bEmotor.Click += new System.EventHandler(this.BEmotor_Click);
            // 
            // tEmotor
            // 
            this.tEmotor.Location = new System.Drawing.Point(12, 39);
            this.tEmotor.Name = "tEmotor";
            this.tEmotor.Size = new System.Drawing.Size(125, 20);
            this.tEmotor.TabIndex = 47;
            // 
            // bDjob
            // 
            this.bDjob.Location = new System.Drawing.Point(572, 71);
            this.bDjob.Name = "bDjob";
            this.bDjob.Size = new System.Drawing.Size(75, 23);
            this.bDjob.TabIndex = 46;
            this.bDjob.Text = "Удалить";
            this.bDjob.UseVisualStyleBackColor = true;
            this.bDjob.Click += new System.EventHandler(this.bDjob_Click);
            // 
            // bEjob
            // 
            this.bEjob.Location = new System.Drawing.Point(463, 71);
            this.bEjob.Name = "bEjob";
            this.bEjob.Size = new System.Drawing.Size(75, 23);
            this.bEjob.TabIndex = 45;
            this.bEjob.Text = "Изменить";
            this.bEjob.UseVisualStyleBackColor = true;
            this.bEjob.Click += new System.EventHandler(this.bEjob_Click);
            // 
            // tEjob
            // 
            this.tEjob.Location = new System.Drawing.Point(356, 39);
            this.tEjob.Name = "tEjob";
            this.tEjob.Size = new System.Drawing.Size(125, 20);
            this.tEjob.TabIndex = 44;
            // 
            // lEmark
            // 
            this.lEmark.AutoSize = true;
            this.lEmark.Location = new System.Drawing.Point(353, 20);
            this.lEmark.Name = "lEmark";
            this.lEmark.Size = new System.Drawing.Size(46, 13);
            this.lEmark.TabIndex = 43;
            this.lEmark.Text = "Работа:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(12, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(293, 150);
            this.dataGridView2.TabIndex = 42;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "motor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.job});
            this.dataGridView1.Location = new System.Drawing.Point(356, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 150);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // job
            // 
            this.job.FillWeight = 150F;
            this.job.HeaderText = "job";
            this.job.Name = "job";
            this.job.Width = 200;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(574, 10);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 40;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bjob
            // 
            this.bjob.Location = new System.Drawing.Point(356, 71);
            this.bjob.Name = "bjob";
            this.bjob.Size = new System.Drawing.Size(75, 23);
            this.bjob.TabIndex = 39;
            this.bjob.Text = "Добавить";
            this.bjob.UseVisualStyleBackColor = true;
            this.bjob.Click += new System.EventHandler(this.bjob_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Двигатель: ";
            // 
            // MotorJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 260);
            this.Controls.Add(this.bmotor);
            this.Controls.Add(this.bDmotor);
            this.Controls.Add(this.bEmotor);
            this.Controls.Add(this.tEmotor);
            this.Controls.Add(this.bDjob);
            this.Controls.Add(this.bEjob);
            this.Controls.Add(this.tEjob);
            this.Controls.Add(this.lEmark);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bjob);
            this.Controls.Add(this.label2);
            this.Name = "MotorJobs";
            this.Text = "MotorJobs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bmotor;
        private System.Windows.Forms.Button bDmotor;
        private System.Windows.Forms.Button bEmotor;
        private System.Windows.Forms.TextBox tEmotor;
        private System.Windows.Forms.Button bDjob;
        private System.Windows.Forms.Button bEjob;
        private System.Windows.Forms.TextBox tEjob;
        private System.Windows.Forms.Label lEmark;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn job;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bjob;
        private System.Windows.Forms.Label label2;
    }
}