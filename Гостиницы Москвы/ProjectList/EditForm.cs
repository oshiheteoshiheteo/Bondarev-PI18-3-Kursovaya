using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectList
{
    public partial class EditForm : Form
    {
        public int i; // Номер текущего факультета в списке.
        public bool flagEdit = false;

        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = Form1.addrList;
            
            textBox1.Text = Form1.listH[i].Name;
            textBox2.Text = Form1.listH[i].Address;
            textBox3.Text = Form1.listH[i].Email;
            maskedTextBox1.Text = Form1.listH[i].Phone;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Название факультета должно быть введено.");
                return;
            }
            // Отредактировать данные о гостинице
            Form1.listH[i].Name = textBox1.Text;
            Form1.listH[i].Address = textBox2.Text;
            Form1.listH[i].Email = textBox3.Text;
            Form1.listH[i].Phone = maskedTextBox1.Text;

            flagEdit = true;

            MessageBox.Show("Данные изменены.");
        }

    }
}
