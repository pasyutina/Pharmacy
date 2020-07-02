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
    public partial class Аптеки : Form
    {
        public Аптеки()
        {
            InitializeComponent();
            ShowPharm();
        }

        void ShowPharm()
        {
            listViewPharm.Items.Clear();
            foreach (Apteka pharm in Program.a.Apteka)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    pharm.Id.ToString(), pharm.Name, pharm.Address, pharm.Email, pharm.Phone
                });
                item.Tag = pharm;
                listViewPharm.Items.Add(item);
            }
            listViewPharm.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewPharm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPharm.SelectedItems.Count == 1)
            {
                Apteka pharm = listViewPharm.SelectedItems[0].Tag as Apteka;
                textBoxName.Text = pharm.Name;
                textBoxAddress.Text = pharm.Address;
                textBoxEmail.Text = pharm.Email;
                textBoxPhone.Text = pharm.Phone;
            }
            else
            {
                textBoxName.Text = "";
                textBoxAddress.Text = "";
                textBoxEmail.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Apteka pharm = new Apteka();
                pharm.Name = textBoxName.Text;
                pharm.Address = textBoxAddress.Text;
                pharm.Email = textBoxEmail.Text;
                pharm.Phone = textBoxPhone.Text;
                if (pharm.Name == "" || pharm.Address == "" || pharm.Email == "" || pharm.Phone == "")
                {
                    throw new Exception("Обязательное заполнение полей ФИО!");
                }
                Program.a.Apteka.Add(pharm);
                Program.a.SaveChanges();
                ShowPharm();
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
                if (listViewPharm.SelectedItems.Count == 1)
                {
                    Apteka pharm = listViewPharm.SelectedItems[0].Tag as Apteka;
                    pharm.Name = textBoxName.Text;
                    pharm.Address = textBoxAddress.Text;
                    pharm.Email = textBoxEmail.Text;
                    pharm.Phone = textBoxPhone.Text;
                    if (pharm.Name == "" || pharm.Address == "" || pharm.Email == "" || pharm.Phone == "")
                    {
                        throw new Exception("Обязательное заполнение полей ФИО!");
                    }
                    Program.a.SaveChanges();
                    ShowPharm();
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
                if (listViewPharm.SelectedItems.Count == 1)
                {
                    Apteka pharm = listViewPharm.SelectedItems[0].Tag as Apteka;
                    Program.a.Apteka.Remove(pharm);
                    Program.a.SaveChanges();
                    ShowPharm();
                }
                textBoxName.Text = "";
                textBoxAddress.Text = "";
                textBoxEmail.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void labelLastEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
