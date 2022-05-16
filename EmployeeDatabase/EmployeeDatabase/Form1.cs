using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDatabase
{
    public partial class Form1 : Form
    {
        int row = 0;
        string gender;
        int selectedRow;

        public Form1()
        {
            InitializeComponent();
        }

        private void rb_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            string id, name, gender, designation;
            object age;
            double bs, da, hra, totalSal;

            id = txt_id.Text;
            name = txt_name.Text;
            if (rb_male.Checked == true)
                gender = "Male";
            else
                gender = "Female";
            age = cb_age.SelectedItem;
            designation = txt_desi.Text;
            bs = double.Parse(txt_bs.Text);
            da = double.Parse(txt_da.Text);
            hra = double.Parse(txt_hra.Text);
            totalSal = bs + da + hra;
            txt_totalSal.Text = " " + totalSal;

            data.Rows.Add();
            data.Rows[row].Cells[0].Value = txt_id.Text;
            data.Rows[row].Cells[1].Value = txt_name.Text;
            data.Rows[row].Cells[2].Value = gender.ToString();
            data.Rows[row].Cells[3].Value = age.ToString();
            data.Rows[row].Cells[4].Value = txt_desi.Text;
            data.Rows[row].Cells[5].Value = txt_bs.Text;
            data.Rows[row].Cells[6].Value = txt_da.Text;
            data.Rows[row].Cells[7].Value = txt_hra.Text;
            data.Rows[row].Cells[8].Value = txt_totalSal.Text;
            row++;
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("ID must be number.");
            }
        }

        private void txt_bs_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Basic Salary must be number.");
            }
        }

        private void txt_da_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Daily Allowance must be number.");
            }
        }

        private void txt_hra_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Home Rent Allowance must be number.");
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = data.Rows[selectedRow];
            newDataRow.Cells[1].Value = txt_name.Text;
            if (rb_male.Checked)
                gender = rb_male.Text;
            else
                gender = rb_female.Text;
            newDataRow.Cells[2].Value = gender.ToString();
            newDataRow.Cells[3].Value = cb_age.ToString();
            newDataRow.Cells[4].Value = txt_desi.Text;
            newDataRow.Cells[5].Value = txt_bs.Text;
            newDataRow.Cells[6].Value = txt_da.Text;
            newDataRow.Cells[7].Value = txt_hra.Text;
            newDataRow.Cells[8].Value = txt_totalSal.Text;
            
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Enabled = false;
            selectedRow = e.RowIndex;
            DataGridViewRow row = data.Rows[selectedRow];
            txt_name.Text = row.Cells[1].Value.ToString();
            string age = row.Cells[3].Value.ToString();
            cb_age.Text = age;
            txt_desi.Text = row.Cells[4].Value.ToString();
            txt_bs.Text = row.Cells[5].Value.ToString();
            txt_da.Text = row.Cells[6].Value.ToString();
            txt_hra.Text = row.Cells[7].Value.ToString();
            txt_totalSal.Text = row.Cells[8].Value.ToString();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            selectedRow = data.CurrentCell.RowIndex;
            data.Rows.RemoveAt(selectedRow);
            txt_id.Clear();
            txt_name.Clear();
            rb_male.Checked = true;
            cb_age.SelectedIndex = -1;
            txt_bs.Clear();
            txt_da.Clear();
            txt_hra.Clear();
            txt_totalSal.Clear();
        }

        private void bt_calculate_Click(object sender, EventArgs e)
        {
            string id, name;
            object age;
            double bs, da, hra;
            double totalSal = 0;

            id = txt_id.Text;
            name = txt_name.Text;
            if (rb_male.Checked == true)
                gender = "Male";
            else
                gender = "Female";
            age = cb_age.SelectedItem;
            bs = double.Parse(txt_bs.Text);
            da = double.Parse(txt_da.Text);
            hra = double.Parse(txt_hra.Text);
            totalSal = bs + da + hra;
            txt_totalSal.Text = " " + totalSal;

            bt_insert.Enabled = true;
            bt_update.Enabled = true;
            bt_delete.Enabled = true;
            bt_exit.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt_insert.Enabled = false;
            bt_update.Enabled = false;
            bt_delete.Enabled = false;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
