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
    public partial class FormRooms : Form
    {
        public int h;   //Индекс текущей гостиницы
        Color backColor;   // Текущий цвет фона сетки

        bool select = false; // true - на экране отображены не все студенты списка;
                             // false - на экране отображены ВСЕ студенты.

        public FormRooms()
        {
            InitializeComponent();
        }

        private void FormRooms_Load(object sender, EventArgs e)
        {
            Text += Form1.listH[h].Name;
            backColor = dataGridView2.RowsDefaultCellStyle.BackColor;

            label2.Text = "Отображены все студенты факультета";
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Новое значение:
            string valueNew = e.FormattedValue.ToString().Trim();

            // Имя столбца (e.ColumnIndex - индекс столбца со старым значением).
            string nameColumn = dataGridView2.Columns[e.ColumnIndex].Name;
            int vInt;
            
            if (nameColumn == "roomnumber" && valueNew != "" && !int.TryParse(valueNew, out vInt))
            {
                MessageBox.Show("Номер комнаты должен быть числом.");
                e.Cancel = true; // Новое значение не принято.
            }
            
            else if (nameColumn == "price" && valueNew != "" && !int.TryParse(valueNew, out vInt))
            {
                MessageBox.Show("Цена должна быть числом.");
                e.Cancel = true; // Новое значение не принято.
            }
            
            else if (nameColumn == "person" && valueNew != "" && !int.TryParse(valueNew, out vInt))
            {
                MessageBox.Show("Кол-во персон должно быть числом.");
                e.Cancel = true; // Новое значение не принято.
            }

            if (nameColumn == "reserv")
            {
                if (valueNew == "True" && checkBoxReserv.Checked)
                    // Изменить цвет фона забронированного номера.
                    dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Maroon;
                else
                    dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = backColor;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null) return;
            EditRoomForm editForm = new EditRoomForm();
            editForm.h = h; // Текущий номер гостиницы
            editForm.r = dataGridView2.CurrentRow.Index; // Текущий номер комнаты
            editForm.ShowDialog();
            if (editForm.flagEdit)
                roomBindingSource.ResetCurrentItem();

            if ((bool)dataGridView2["reserv", editForm.r].Value == true && checkBoxReserv.Checked)
                // Изменить цвет фона забронированного номера.
                dataGridView2.Rows[editForm.r].DefaultCellStyle.BackColor = Color.Maroon;
            else
                dataGridView2.Rows[editForm.r].DefaultCellStyle.BackColor = backColor;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddRoomForm addForm = new AddRoomForm();
            addForm.h = h; // Текущий номер гостиницы
            addForm.ShowDialog();
            if (addForm.flagEdit)
                roomBindingSource.ResetBindings(false);

            Забронированные();

            if (select)
            { // Если ранее была выполнена фильтрация.
                Select_Click(null, null);

                // Найдем последнюю отображаемую строку и перейдем на неё.
                for (int i = dataGridView2.RowCount - 1; i >= 0; i--)
                if (dataGridView2.Rows[i].Visible == true)
                {
                    // Перейти на добавленный номер. Его индекс = i.
                    dataGridView2.CurrentCell = dataGridView2[1, i];
                    break;
                }
            }
            else
                // Перейти на добавленный номер. Он в конце списка.
                dataGridView2.CurrentCell =
                dataGridView2[1, dataGridView2.RowCount - 1];
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для удаления одного или нескольких номеров выделите их, щелкнув по заголовкам(слева), и нажмите клавишу Delete");
        }

        //-------- Выделение должников фоном----------------------------
        private void Забронированные()
        {
            if (checkBoxReserv.Checked)
            {
                for (int Y = 0; Y < dataGridView2.RowCount; Y++)
                    // Изменить цвет фона.
                    if ((bool)dataGridView2["reserv", Y].Value == true)
                        dataGridView2.Rows[Y].DefaultCellStyle.BackColor = Color.Maroon;
            }
            else
                for (int Y = 0; Y < dataGridView2.RowCount; Y++)
                    // Восстановить цвет фона.
                    if ((bool)dataGridView2["reserv", Y].Value == true)
                    dataGridView2.Rows[Y].DefaultCellStyle.BackColor = backColor;
        }

        private void Забронированные_CheckedChanged(object sender, EventArgs e)
        {
            Забронированные();
        }

        //--------Отбор номеров-------------------------
        private void Select_Click(object sender, EventArgs e)
        {
            dataGridView2.CurrentCell = null;
            for (int i = 0; i < dataGridView2.RowCount; i++)
{
                if (TestRow(i))
                    dataGridView2.Rows[i].Visible = true;
                else
                {
                    dataGridView2.Rows[i].Visible = false;
                    select = true;
                }
            }
            
            if (select) label2.Text = string.Format("Список номеров отфильтрован: {0}, {1}, {2}, {3}, {4}, {5}",
            textBoxRoomnumber.Text, textBoxRoomtype.Text, textBoxPerson.Text, textBoxPriceLow.Text, textBoxPriceHigh.Text, textBoxReserv.Text);

            // Перенести фокус на первый отображаемый номер, если он есть.
            for (int i = 0; i < dataGridView2.RowCount; i++)

            if (dataGridView2.Rows[i].Visible == true)
            {
                // Перейти на добавленный номер. Его индекс = i.
                dataGridView2.CurrentCell = dataGridView2[1, i];
                break;
            }
        }

        // Метод проверяет ячейки переданной строки на одновременное равенство всем критериям.
        private bool TestRow(int r)
        {
            Room rm = Form1.listH[h].Rooms[r];
            if (textBoxRoomnumber.Text != "" && rm.Roomnumber != Convert.ToInt32(textBoxRoomnumber.Text)) return false;
            if (textBoxRoomtype.Text != "" && !rm.Roomtype.StartsWith(textBoxRoomtype.Text)) return false;
            if (textBoxPerson.Text != "" && rm.Person != Convert.ToInt32(textBoxPerson.Text)) return false;

            int prlow, prhigh;
            int.TryParse(textBoxPriceLow.Text, out prlow);
            int.TryParse(textBoxPriceHigh.Text, out prhigh);
            if (prhigh == 0) prhigh = 100000;
            if (rm.Price < prlow || rm.Price > prhigh) return false;

            if (textBoxReserv.Text != "")
            {
                bool res = textBoxReserv.Text == "да" ? true : false;
                if (rm.Reservation != res) return false;
            }

            return true;
        }

        private void All_Click(object sender, EventArgs e)
        {
            select = false;
            label2.Text = "Отображены все студенты факультета";
            for (int i = 0; i < dataGridView2.RowCount; i++)
                dataGridView2.Rows[i].Visible = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxRoomnumber.Text = "";
            textBoxRoomtype.Text = "";
            textBoxPerson.Text = "";
            textBoxPriceLow.Text = "";
            textBoxPriceHigh.Text = "";
            textBoxReserv.Text = "";
        }

        //--------Одноуровневая сортировка-------------------------
        private void dataGridView2_ColumnHeaderMouseClick(object sender,
        DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView2.Rows.Count == 0) return;
            int d = checkBoxSort1.Checked == true ? -1 : 1; // Порядок сортировки.
            List<Room> list = Form1.listH[h].Rooms;
            switch (dataGridView2.Columns[e.ColumnIndex].Name)
            {
                case "roomnumber":
                list.Sort((a1, a2) => d* a1.Roomnumber.CompareTo(a2.Roomnumber));
                    break;
                
                case "price":
                list.Sort((a1, a2) => d* a1.Price.CompareTo(a2.Price));
                    break;

                case "roomtype":
                list.Sort((a1, a2) => d* a1.Roomtype.CompareTo(a2.Roomtype));
                    break;

                case "person":
                list.Sort((a1, a2) => d* a1.Person.CompareTo(a2.Person));
                    break;

                case "reserv":
                list.Sort((a1, a2) => d* a1.Reservation.CompareTo(a2.Reservation));
                    break;

                default: // По другим столбцам сортировки не будет.
                    return;
            }
            roomBindingSource.ResetBindings(false);
            if (select) Select_Click(null, null); // Обновить фильтрацию.
            Забронированные(); // Изменить фон у строк должников.
        }

        //--- Двухуровневая сортировка ---------------------------
        private void Sort2_Click(object sender, EventArgs e)
        {
            List<Room> list = Form1.listH[h].Rooms;
            if (!checkBox1Sort2.Checked && !checkBox2Sort2.Checked)
                switch (comboBox1.SelectedIndex)
                {
                case 0:
                    list = (list.OrderBy(s => s.Price).ThenBy(s => s.Roomtype)).ToList();
                    break;
                case 1:
                    list = (list.OrderBy(s => s.Price).ThenBy(s => s.Person)).ToList();
                    break;
                case 2:
                    list = (list.OrderBy(s => s.Person).ThenBy(s => s.Roomtype)).ToList();
                    break;
                case 3:
                    list = (list.OrderBy(s => s.Person).ThenBy(s => s.Price)).ToList();
                    break;
                }
            else if (!checkBox1Sort2.Checked && checkBox2Sort2.Checked)
                switch (comboBox1.SelectedIndex)
                {
                case 0:
                    list = (list.OrderBy(s => s.Price).ThenByDescending(s => s.Roomtype)).ToList();
                    break;
                case 1:
                    list = (list.OrderBy(s => s.Price).ThenByDescending(s => s.Person)).ToList();
                    break;
                case 2:
                    list = (list.OrderBy(s => s.Person).ThenByDescending(s => s.Roomtype)).ToList();
                    break;
                case 3:
                    list = (list.OrderBy(s => s.Person).ThenByDescending(s => s.Price)).ToList();
                    break;
                }
            else if (checkBox1Sort2.Checked && checkBox2Sort2.Checked)
                switch (comboBox1.SelectedIndex)
                {
                case 0:
                    list = (list.OrderByDescending(s => s.Price).ThenByDescending(s => s.Roomtype)).ToList();
                    break;
                case 1:
                    list = (list.OrderByDescending(s => s.Price).ThenByDescending(s => s.Person)).ToList();
                    break;
                case 2:
                    list = (list.OrderByDescending(s => s.Person).ThenByDescending(s => s.Roomtype)).ToList();
                    break;
                case 3:
                    list = (list.OrderByDescending(s => s.Person).ThenByDescending(s => s.Price)).ToList();
                    break;
                }
            else if (checkBox1Sort2.Checked && !checkBox2Sort2.Checked)

                switch (comboBox1.SelectedIndex)
                {
                case 0:
                    list = (list.OrderByDescending(s => s.Price).ThenBy(s => s.Roomtype)).ToList();
                    break;
                case 1:
                    list = (list.OrderByDescending(s => s.Price).ThenBy(s => s.Person)).ToList();
                    break;
                case 2:
                    list = (list.OrderByDescending(s => s.Person).ThenBy(s => s.Roomtype)).ToList();
                    break;
                case 3:
                    list = (list.OrderByDescending(s => s.Person).ThenBy(s => s.Price)).ToList();
                    break;
                }
            Form1.listH[h].Rooms = list;
            roomBindingSource.DataSource = list;
            if (select) Select_Click(null, null);
            Забронированные(); // Изменить фон у строк забронированных.
        }
    }
}
