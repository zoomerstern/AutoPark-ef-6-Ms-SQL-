
namespace AutoPark
{
    partial class Add
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
            this.tBmark = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.tBmodel = new System.Windows.Forms.TextBox();
            this.motorBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBmark
            // 
            this.tBmark.Location = new System.Drawing.Point(109, 8);
            this.tBmark.Name = "tBmark";
            this.tBmark.Size = new System.Drawing.Size(125, 20);
            this.tBmark.TabIndex = 25;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(159, 128);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 24;
            this.bClose.Text = "Отмена";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(13, 128);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 23;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // tBmodel
            // 
            this.tBmodel.Location = new System.Drawing.Point(109, 47);
            this.tBmodel.Name = "tBmodel";
            this.tBmodel.Size = new System.Drawing.Size(125, 20);
            this.tBmodel.TabIndex = 22;
            // 
            // motorBox
            // 
            this.motorBox.FormattingEnabled = true;
            this.motorBox.Location = new System.Drawing.Point(109, 84);
            this.motorBox.Name = "motorBox";
            this.motorBox.Size = new System.Drawing.Size(125, 21);
            this.motorBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Тип двигателя: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Модель: ";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(51, 11);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(46, 13);
            this.label0.TabIndex = 18;
            this.label0.Text = "Марка: ";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 160);
            this.Controls.Add(this.tBmark);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tBmodel);
            this.Controls.Add(this.motorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBmark;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tBmodel;
        private System.Windows.Forms.ComboBox motorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label0;
    }
}