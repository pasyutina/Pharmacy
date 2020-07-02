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
    public partial class Наличие : Form
    {
        public Наличие()
        {
            InitializeComponent();
            ShowNal();
            ShowPharm();
            ShowMed();
        }
        
        void ShowNal()
        {
            listViewNal.Items.Clear();
            foreach (Nal nal in Program.a.Nal)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    nal.Id.ToString(),  nal.Medicins.Name,  
                    nal.Apteka.Name, nal.Quantity.ToString(),
                    nal.Price.ToString() 
                });
                item.Tag = nal;
                listViewNal.Items.Add(item);
            }
            listViewNal.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowMed()
        {
            comboBoxMed.Items.Clear();
            foreach (Medicins med in Program.a.Medicins)
            {
                string[] item = { med.Id.ToString() + ". " +
                        med.Name };
                comboBoxMed.Items.Add(string.Join("", item));
            }
        }
        void ShowPharm()
        {
            comboBoxPharm.Items.Clear();
            foreach (Apteka pharm in Program.a.Apteka)
            {
                string[] item = { pharm.Id.ToString() + ". " +
                        pharm.Name };
                comboBoxPharm.Items.Add(string.Join("", item));
            }
        }
        private void listViewNal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNal.SelectedItems.Count == 1)
            {
                Nal nal = listViewNal.SelectedItems[0].Tag as Nal;
                comboBoxMed.SelectedIndex = comboBoxMed.FindString(nal.IdMedicine.ToString());
                comboBoxPharm.SelectedIndex = comboBoxPharm.FindString(nal.IdApteka.ToString());
                textBoxQuantity.Text = nal.Quantity.ToString();
                textBoxPrice.Text = nal.Price.ToString();
            }
            else
            {
                comboBoxMed.SelectedItem = null;
                comboBoxPharm.SelectedItem = null;
                textBoxQuantity.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Nal nal = new Nal();
                nal.IdMedicine = Convert.ToInt32(comboBoxMed.SelectedItem.ToString().Split('.')[0]);
                nal.IdApteka = Convert.ToInt32(comboBoxPharm.SelectedItem.ToString().Split('.')[0]);
                nal.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                nal.Price = Convert.ToInt32(textBoxPrice.Text);
                if (nal.IdMedicine == null || nal.IdApteka == null )
                {
                    throw new Exception("Обязательное заполнение полей!");
                }
                Program.a.Nal.Add(nal);
                Program.a.SaveChanges();
                ShowNal();
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
                if (listViewNal.SelectedItems.Count == 1)
                {
                    Nal nal = listViewNal.SelectedItems[0].Tag as Nal;
                    nal.IdMedicine = Convert.ToInt32(comboBoxMed.SelectedItem.ToString().Split('.')[0]);
                    nal.IdApteka = Convert.ToInt32(comboBoxPharm.SelectedItem.ToString().Split('.')[0]);
                    nal.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                    nal.Price = Convert.ToInt32(textBoxPrice.Text);
                    if (nal.IdMedicine == null || nal.IdApteka == null)
                    {
                        throw new Exception("Обязательное заполнение полей!");
                    }
                    Program.a.SaveChanges();
                    ShowNal();
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
                if (listViewNal.SelectedItems.Count == 1)
                {
                    Nal nal = listViewNal.SelectedItems[0].Tag as Nal;
                    Program.a.Nal.Remove(nal);
                    Program.a.SaveChanges();
                    ShowNal();
                }
                comboBoxMed.SelectedItem = null;
                comboBoxPharm.SelectedItem = null;
                textBoxQuantity.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}
