namespace Pharmacy
{
    partial class Лекарства
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewMed = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Form = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dosage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manuf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelForm = new System.Windows.Forms.Label();
            this.labelDosage = new System.Windows.Forms.Label();
            this.labelManuf = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.textBoxManuf = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxForm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonDel.Location = new System.Drawing.Point(513, 342);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(184, 55);
            this.buttonDel.TabIndex = 54;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonEdit.Location = new System.Drawing.Point(323, 342);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(184, 55);
            this.buttonEdit.TabIndex = 53;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonAdd.Location = new System.Drawing.Point(133, 342);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(184, 55);
            this.buttonAdd.TabIndex = 52;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewMed
            // 
            this.listViewMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.listViewMed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nname,
            this.Form,
            this.Dosage,
            this.Manuf,
            this.Date});
            this.listViewMed.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewMed.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewMed.FullRowSelect = true;
            this.listViewMed.GridLines = true;
            this.listViewMed.HideSelection = false;
            this.listViewMed.Location = new System.Drawing.Point(222, 12);
            this.listViewMed.MultiSelect = false;
            this.listViewMed.Name = "listViewMed";
            this.listViewMed.Size = new System.Drawing.Size(475, 322);
            this.listViewMed.TabIndex = 51;
            this.listViewMed.UseCompatibleStateImageBehavior = false;
            this.listViewMed.View = System.Windows.Forms.View.Details;
            this.listViewMed.SelectedIndexChanged += new System.EventHandler(this.listViewMed_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 29;
            // 
            // Nname
            // 
            this.Nname.Text = "Название";
            this.Nname.Width = 94;
            // 
            // Form
            // 
            this.Form.Text = "Форма выпуска";
            this.Form.Width = 110;
            // 
            // Dosage
            // 
            this.Dosage.Text = "Дозировка";
            this.Dosage.Width = 102;
            // 
            // Manuf
            // 
            this.Manuf.Text = "Производитель";
            this.Manuf.Width = 170;
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForm.Location = new System.Drawing.Point(9, 76);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(152, 26);
            this.labelForm.TabIndex = 50;
            this.labelForm.Text = "Форма выпуска";
            // 
            // labelDosage
            // 
            this.labelDosage.AutoSize = true;
            this.labelDosage.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDosage.Location = new System.Drawing.Point(7, 142);
            this.labelDosage.Name = "labelDosage";
            this.labelDosage.Size = new System.Drawing.Size(109, 26);
            this.labelDosage.TabIndex = 49;
            this.labelDosage.Text = "Дозировка";
            // 
            // labelManuf
            // 
            this.labelManuf.AutoSize = true;
            this.labelManuf.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManuf.Location = new System.Drawing.Point(7, 207);
            this.labelManuf.Name = "labelManuf";
            this.labelManuf.Size = new System.Drawing.Size(149, 26);
            this.labelManuf.TabIndex = 48;
            this.labelManuf.Text = "Производитель";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(9, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 26);
            this.labelName.TabIndex = 47;
            this.labelName.Text = "Название";
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDosage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxDosage.Location = new System.Drawing.Point(12, 171);
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(189, 33);
            this.textBoxDosage.TabIndex = 46;
            // 
            // textBoxManuf
            // 
            this.textBoxManuf.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxManuf.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxManuf.Location = new System.Drawing.Point(12, 236);
            this.textBoxManuf.Name = "textBoxManuf";
            this.textBoxManuf.Size = new System.Drawing.Size(189, 33);
            this.textBoxManuf.TabIndex = 44;
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxName.Location = new System.Drawing.Point(12, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(189, 33);
            this.textBoxName.TabIndex = 43;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(9, 272);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(86, 26);
            this.labelDate.TabIndex = 57;
            this.labelDate.Text = "Телефон";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(12, 301);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(189, 33);
            this.dateTimePicker.TabIndex = 58;
            // 
            // Date
            // 
            this.Date.Text = "Дата выпуска";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources.biyxK7XkT;
            this.pictureBox1.Location = new System.Drawing.Point(12, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxForm
            // 
            this.comboBoxForm.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxForm.FormattingEnabled = true;
            this.comboBoxForm.Items.AddRange(new object[] {
            "таблетки",
            "капсулы",
            "ампулы",
            "сироп",
            "крем"});
            this.comboBoxForm.Location = new System.Drawing.Point(12, 105);
            this.comboBoxForm.Name = "comboBoxForm";
            this.comboBoxForm.Size = new System.Drawing.Size(189, 34);
            this.comboBoxForm.TabIndex = 59;
            // 
            // Лекарства
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 410);
            this.Controls.Add(this.comboBoxForm);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewMed);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.labelDosage);
            this.Controls.Add(this.labelManuf);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxDosage);
            this.Controls.Add(this.textBoxManuf);
            this.Controls.Add(this.textBoxName);
            this.Name = "Лекарства";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лекарства";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewMed;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nname;
        private System.Windows.Forms.ColumnHeader Form;
        private System.Windows.Forms.ColumnHeader Dosage;
        private System.Windows.Forms.ColumnHeader Manuf;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.Label labelDosage;
        private System.Windows.Forms.Label labelManuf;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxDosage;
        private System.Windows.Forms.TextBox textBoxManuf;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ComboBox comboBoxForm;
    }
}