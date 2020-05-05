using System;
using System.Windows.Forms;
namespace ProjectList
{
    public partial class AddRoomForm : Form
    {
        public int h; // Номер текущей гостиницы.
        public bool flagEdit = false;
        public AddRoomForm()
        {
            InitializeComponent();
        }
        private void AddRoomForm_Load(object sender, EventArgs e)
        {
            label1.Text += Form1.listH[h].Name;
        }
        ////////////////////////////////////////
        private void Add_Click(object sender, EventArgs e)
        {
            int rn = 0, pr = 0, pe = 0;
            if (string.IsNullOrWhiteSpace(textBox1.Text)) // Если поле пустое
            {
                MessageBox.Show("Номер комнаты должен быть введён");
                textBox1.Focus();
                return;
            }

            if (textBox1.Text != "" && !int.TryParse(textBox2.Text, out rn))
            {
                MessageBox.Show("Номер комнаты должен быть числом");
                textBox2.Focus();
                return;

            }

            if (textBox2.Text != "" && !int.TryParse(textBox2.Text, out pr))
            {
                MessageBox.Show("Цена должна быть числом");
                textBox2.Focus();
                return;

            }
            if (textBox4.Text != "" && !int.TryParse(textBox4.Text, out pe))
            {
                MessageBox.Show("Кол-во персон должно быть числом");
                textBox4.Focus();
                return;
            }

            Form1.listH[h].Rooms.Add(new Room(rn, pr, textBox3.Text, pe, checkBox1.Checked));
            flagEdit = true;

            if (MessageBox.Show("Номер" +textBox1.Text +
              "добавлен. \n\nДобавить следующий номер?", "Добавить или выйти ?",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.No)
                Close();

            textBox1.Focus();
        }
    }
}