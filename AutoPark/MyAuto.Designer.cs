
namespace AutoPark
{
    partial class MyAuto
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
            this.tMark = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.Close = new System.Windows.Forms.Button();
            this.jobDelete = new System.Windows.Forms.Button();
            this.jobsBox = new System.Windows.Forms.ComboBox();
            this.jobAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ljobs = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.tModel = new System.Windows.Forms.TextBox();
            this.motorBox = new System.Windows.Forms.ComboBox();
            this.lmotor = new System.Windows.Forms.Label();
            this.lmodel = new System.Windows.Forms.Label();
            this.lmark = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tMark
            // 
            this.tMark.Location = new System.Drawing.Point(51, 22);
            this.tMark.Name = "tMark";
            this.tMark.Size = new System.Drawing.Size(100, 20);
            this.tMark.TabIndex = 38;
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "MMMMdd, yyyy | hh:mm";
            this.dateTime.Location = new System.Drawing.Point(567, 150);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(179, 20);
            this.dateTime.TabIndex = 37;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(701, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 36;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // jobDelete
            // 
            this.jobDelete.Location = new System.Drawing.Point(525, 94);
            this.jobDelete.Name = "jobDelete";
            this.jobDelete.Size = new System.Drawing.Size(106, 22);
            this.jobDelete.TabIndex = 35;
            this.jobDelete.Text = "Удалить рабоу";
            this.jobDelete.UseVisualStyleBackColor = true;
            this.jobDelete.Click += new System.EventHandler(this.JobDelete_Click);
            // 
            // jobsBox
            // 
            this.jobsBox.FormattingEnabled = true;
            this.jobsBox.Location = new System.Drawing.Point(567, 122);
            this.jobsBox.Name = "jobsBox";
            this.jobsBox.Size = new System.Drawing.Size(122, 21);
            this.jobsBox.TabIndex = 34;
            // 
            // jobAdd
            // 
            this.jobAdd.Location = new System.Drawing.Point(525, 62);
            this.jobAdd.Name = "jobAdd";
            this.jobAdd.Size = new System.Drawing.Size(106, 22);
            this.jobAdd.TabIndex = 33;
            this.jobAdd.Text = "Добавить рабоу";
            this.jobAdd.UseVisualStyleBackColor = true;
            this.jobAdd.Click += new System.EventHandler(this.JobAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Дата:";
            // 
            // ljobs
            // 
            this.ljobs.AutoSize = true;
            this.ljobs.Location = new System.Drawing.Point(522, 125);
            this.ljobs.Name = "ljobs";
            this.ljobs.Size = new System.Drawing.Size(46, 13);
            this.ljobs.TabIndex = 31;
            this.ljobs.Text = "Работа:";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(525, 12);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(106, 37);
            this.update.TabIndex = 30;
            this.update.Text = "Изменить характеристики";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // tModel
            // 
            this.tModel.Location = new System.Drawing.Point(215, 22);
            this.tModel.Name = "tModel";
            this.tModel.Size = new System.Drawing.Size(100, 20);
            this.tModel.TabIndex = 29;
            // 
            // motorBox
            // 
            this.motorBox.FormattingEnabled = true;
            this.motorBox.Location = new System.Drawing.Point(414, 21);
            this.motorBox.Name = "motorBox";
            this.motorBox.Size = new System.Drawing.Size(100, 21);
            this.motorBox.TabIndex = 28;
            // 
            // lmotor
            // 
            this.lmotor.AutoSize = true;
            this.lmotor.Location = new System.Drawing.Point(321, 24);
            this.lmotor.Name = "lmotor";
            this.lmotor.Size = new System.Drawing.Size(87, 13);
            this.lmotor.TabIndex = 27;
            this.lmotor.Text = "Тип двигателя: ";
            // 
            // lmodel
            // 
            this.lmodel.AutoSize = true;
            this.lmodel.Location = new System.Drawing.Point(167, 24);
            this.lmodel.Name = "lmodel";
            this.lmodel.Size = new System.Drawing.Size(52, 13);
            this.lmodel.TabIndex = 26;
            this.lmodel.Text = "Модель: ";
            // 
            // lmark
            // 
            this.lmark.AutoSize = true;
            this.lmark.Location = new System.Drawing.Point(9, 24);
            this.lmark.Name = "lmark";
            this.lmark.Size = new System.Drawing.Size(46, 13);
            this.lmark.TabIndex = 25;
            this.lmark.Text = "Марка: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.jobs,
            this.date});
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 278);
            this.dataGridView1.TabIndex = 24;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // jobs
            // 
            this.jobs.HeaderText = "jobs";
            this.jobs.Name = "jobs";
            this.jobs.Width = 200;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.Width = 200;
            // 
            // MyAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 351);
            this.Controls.Add(this.tMark);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.jobDelete);
            this.Controls.Add(this.jobsBox);
            this.Controls.Add(this.jobAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ljobs);
            this.Controls.Add(this.update);
            this.Controls.Add(this.tModel);
            this.Controls.Add(this.motorBox);
            this.Controls.Add(this.lmotor);
            this.Controls.Add(this.lmodel);
            this.Controls.Add(this.lmark);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyAuto";
            this.Text = "MyAuto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tMark;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button jobDelete;
        private System.Windows.Forms.ComboBox jobsBox;
        private System.Windows.Forms.Button jobAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ljobs;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox tModel;
        private System.Windows.Forms.ComboBox motorBox;
        private System.Windows.Forms.Label lmotor;
        private System.Windows.Forms.Label lmodel;
        private System.Windows.Forms.Label lmark;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}