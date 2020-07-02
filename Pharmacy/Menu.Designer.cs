namespace Pharmacy
{
    partial class Menu
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
            this.buttonOpenMedicine = new System.Windows.Forms.Button();
            this.buttonOpenNal = new System.Windows.Forms.Button();
            this.buttonOpenPharm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenMedicine
            // 
            this.buttonOpenMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(163)))), ((int)(((byte)(100)))));
            this.buttonOpenMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenMedicine.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenMedicine.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenMedicine.Location = new System.Drawing.Point(13, 180);
            this.buttonOpenMedicine.Name = "buttonOpenMedicine";
            this.buttonOpenMedicine.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenMedicine.TabIndex = 14;
            this.buttonOpenMedicine.Text = "Лекарства";
            this.buttonOpenMedicine.UseVisualStyleBackColor = false;
            this.buttonOpenMedicine.Click += new System.EventHandler(this.buttonOpenMedicine_Click);
            // 
            // buttonOpenNal
            // 
            this.buttonOpenNal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(163)))), ((int)(((byte)(100)))));
            this.buttonOpenNal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenNal.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenNal.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenNal.Location = new System.Drawing.Point(13, 246);
            this.buttonOpenNal.Name = "buttonOpenNal";
            this.buttonOpenNal.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenNal.TabIndex = 13;
            this.buttonOpenNal.Text = "Наличие";
            this.buttonOpenNal.UseVisualStyleBackColor = false;
            this.buttonOpenNal.Click += new System.EventHandler(this.buttonOpenNal_Click);
            // 
            // buttonOpenPharm
            // 
            this.buttonOpenPharm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(163)))), ((int)(((byte)(100)))));
            this.buttonOpenPharm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenPharm.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenPharm.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenPharm.Location = new System.Drawing.Point(13, 114);
            this.buttonOpenPharm.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenPharm.Name = "buttonOpenPharm";
            this.buttonOpenPharm.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenPharm.TabIndex = 12;
            this.buttonOpenPharm.Text = "Аптеки";
            this.buttonOpenPharm.UseVisualStyleBackColor = false;
            this.buttonOpenPharm.Click += new System.EventHandler(this.buttonOpenPharm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources.biyxK7XkT;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 306);
            this.Controls.Add(this.buttonOpenMedicine);
            this.Controls.Add(this.buttonOpenNal);
            this.Controls.Add(this.buttonOpenPharm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenMedicine;
        private System.Windows.Forms.Button buttonOpenNal;
        private System.Windows.Forms.Button buttonOpenPharm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

