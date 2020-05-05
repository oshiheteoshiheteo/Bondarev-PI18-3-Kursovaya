using System;
using System.Windows.Forms;
namespace ProjectList
{
    public partial class EditRoomForm : Form
    {
        public int h, r;
        public bool flagEdit = false;
        public EditRoomForm()
        {
            InitializeComponent();
        }
        //---------Настроить форму на текущий номер------------
        private void EditRoomForm_Load(object sender, EventArgs e)
        {
            label1.Text += Form1.listH[h].Name;
            Room rm = Form1.listH[h].Rooms[r];

            textBox1.Text = rm.Roomnumber.ToString();
            textBox2.Text = rm.Price.ToString();
            textBox3.Text = rm.Roomtype;
            textBox4.Text = rm.Person.ToString();
            checkBox1.Checked = rm.Reservation;
        }
        //-------Принять изменения------------------------------
        private void Accept_Click(object sender, EventArgs e)
        {
            int rn = 0, pr = 0, pe = 0;
            if (string.IsNullOrWhiteSpace(textBox1.Text)) // Если поле пустое
            {
                MessageBox.Show("Номер должен быть введён");
                textBox1.Focus();
                return;
            }
            if (!int.TryParse(textBox1.Text, out rn))
            {
                MessageBox.Show("Номер должен быть числом");
                textBox2.Focus();
                return;
            }

            if (!int.TryParse(textBox2.Text, out pr))
            {
                MessageBox.Show("Цена должна быть числом");
                textBox4.Focus();
                return;
            }

            if (!int.TryParse(textBox4.Text, out pe))
            {
                MessageBox.Show("Кол-во персон должно быть числом");
                textBox4.Focus();
                return;
            }

            Room rm = Form1.listH[h].Rooms[r];
            rm.Roomnumber = rn;
            rm.Price = pr;
            rm.Roomtype = textBox3.Text;
            rm.Person = pe;
            rm.Reservation = checkBox1.Checked;
            
            flagEdit = true;
            Close();
        }
    }
}