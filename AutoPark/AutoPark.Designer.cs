
namespace AutoPark
{
    partial class AutoPark
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.editJobMotor = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // editJobMotor
            // 
            this.editJobMotor.Location = new System.Drawing.Point(151, 12);
            this.editJobMotor.Name = "editJobMotor";
            this.editJobMotor.Size = new System.Drawing.Size(115, 35);
            this.editJobMotor.TabIndex = 36;
            this.editJobMotor.Text = "Моторы и работы";
            this.editJobMotor.UseVisualStyleBackColor = true;
            this.editJobMotor.Click += new System.EventHandler(this.Edit_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(342, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(63, 20);
            this.close.TabIndex = 35;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(151, 53);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(115, 35);
            this.insert.TabIndex = 34;
            this.insert.Text = "Выбрать";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(289, 53);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(115, 35);
            this.delete.TabIndex = 33;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(11, 53);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(115, 35);
            this.add.TabIndex = 32;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.mark,
            this.model,
            this.motor});
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 288);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // num
            // 
            this.num.HeaderText = "num";
            this.num.Name = "num";
            this.num.Width = 50;
            // 
            // mark
            // 
            this.mark.HeaderText = "model";
            this.mark.Name = "mark";
            // 
            // model
            // 
            this.model.HeaderText = "name";
            this.model.Name = "model";
            // 
            // motor
            // 
            this.motor.HeaderText = "motor";
            this.motor.Name = "motor";
            // 
            // AutoPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 392);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editJobMotor);
            this.Controls.Add(this.close);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Name = "AutoPark";
            this.Text = "AutoPark";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editJobMotor;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn motor;
    }
}

