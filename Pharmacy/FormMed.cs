using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Лекарства : Form
    {
        public Лекарства()
        {
            InitializeComponent();
            ShowMed();
        }

        void ShowMed()
        {
            listViewMed.Items.Clear();
            foreach (Medicins med in Program.a.Medicins)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    med.Id.ToString(), med.Name, med.Form,
                    med.Dosage, med.Manuf, med.Date.ToString()
                });
                item.Tag = med;
                listViewMed.Items.Add(item);
            }
            listViewMed.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMed.SelectedItems.Count == 1)
            {
                Medicins med = listViewMed.SelectedItems[0].Tag as Medicins;
                textBoxName.Text = med.Name;
                comboBoxForm.Text = med.Form;
                textBoxDosage.Text = med.Dosage;
                textBoxManuf.Text = med.Manuf;
                dateTimePicker.Value = med.Date.GetValueOrDefault();
            }
            else
            {
                textBoxName.Text = "";
                comboBoxForm.Text = "";
                textBoxDosage.Text = "";
                textBoxManuf.Text = "";
                dateTimePicker.Value = DateTime.Now;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Medicins med = new Medicins();
                med.Name = textBoxName.Text;
                med.Form = comboBoxForm.Text;
                med.Dosage = textBoxDosage.Text;
                med.Manuf = textBoxManuf.Text;
                med.Date = dateTimePicker.Value;
                if (med.Name == "" || med.Manuf == "" || med.Dosage == "" )
                {
                    throw new Exception("Обязательное заполнение полей!");
                }
                Program.a.Medicins.Add(med);
                Program.a.SaveChanges();
                ShowMed();
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMed.SelectedItems.Count == 1)
                {
                    Medicins med = listViewMed.SelectedItems[0].Tag as Medicins;
                    med.Name = textBoxName.Text;
                    med.Form = comboBoxForm.Text;
                    med.Dosage = textBoxDosage.Text;
                    med.Manuf = textBoxManuf.Text;
                    med.Date = dateTimePicker.Value;
                    if (med.Name == "" || med.Manuf == "" || med.Dosage == "")
                    {
                        throw new Exception("Обязательное заполнение полей!");
                    }
                    Program.a.SaveChanges();
                    ShowMed();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMed.SelectedItems.Count == 1)
                {
                    Medicins med = listViewMed.SelectedItems[0].Tag as Medicins;
                    Program.a.Medicins.Remove(med);
                    Program.a.SaveChanges();
                    ShowMed();
                }
                textBoxName.Text = "";
                comboBoxForm.Text = "";
                textBoxDosage.Text = "";
                textBoxManuf.Text = "";
                dateTimePicker.Value = DateTime.Now;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
