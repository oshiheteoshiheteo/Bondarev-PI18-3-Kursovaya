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
    public partial class AddForm : Form
    {
        public bool flagEdit = false;

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = Form1.addrList;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Название гостиницы должно быть введено");
                return;
            }
            // Создать новый объект и добавить его в список
            List<Room> listR = new List<Room>();

            Form1.listH.Add(new Hotel(textBox1.Text, textBox2.Text,
            textBox3.Text, maskedTextBox1.Text, listR));

            textBox1.Focus();
            flagEdit = true;

            MessageBox.Show("Гостиница добавлена.");
        }
    }
}
