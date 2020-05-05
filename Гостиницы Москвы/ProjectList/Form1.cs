using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProjectList
{
    public partial class Form1 : Form
    {
        FileStream fs;
        XmlSerializer xs;

        public Form1()
        {
            InitializeComponent();
        }

        public static List<Hotel> listH = new List<Hotel>();
        public List<Room> listR;
        public static List<string> addrList = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Отель_номера.xml"))
            {
                // Восстановим из файла сериализованный граф объектов.
                fs = new FileStream("Отель_номера.xml", FileMode.Open);
                xs = new XmlSerializer(typeof(List<Hotel>));
                listH = (List<Hotel>)xs.Deserialize(fs);
                fs.Close();
            }
            else
            {

                // Гостиница "Космос" -----------------------------------
                listR = new List<Room>();
                listR.Add(new Room(030, 6900, "standard", 2, true));
                listR.Add(new Room(045, 11570, "semi-suite", 2, false));
                listR.Add(new Room(088, 28200, "luxe", 3, true));
                listR.Add(new Room(006, 19600, "suite", 3, false));
                listR.Add(new Room(102, 15000, "suite", 1, true));

                listH.Add(new Hotel("Космос", "Проспект Мира, 150", "reservations@hotelcosmos.ru", "+7 (495) 234-12-06", listR));

                // Гостиница "Radisson Славянская"----------------------
                listR = new List<Room>();
                listR.Add(new Room(001, 7400, "standard", 2, true));
                listR.Add(new Room(023, 21000, "luxe", 2, false));
                listR.Add(new Room(098, 11400, "semi-suite", 2, true));
                listR.Add(new Room(007, 13870, "suite", 1, true));
                listR.Add(new Room(101, 20000, "suite", 2, false));

                listH.Add(new Hotel("Radisson Славянская", "Площадь Европы, 2", "reservations.moscow@radisson-hotels.ru", "+7 (495) 941-80-20", listR));

                // Гостиница "Hampton Строгино" ----------------------------------------------
                listR = new List<Room>();
                listR.Add(new Room(001, 6000, "standard", 1, false));
                listR.Add(new Room(119, 19900, "suite", 2, true));
                listR.Add(new Room(022, 14350, "semi-suite", 3, false));
                listR.Add(new Room(037, 10000, "standard", 2, false));

                listH.Add(new Hotel("Hampton Строгино", "ул. Кулакова, 20 к.1", "mowms_hampton@hilton.com", "+7 (499) 745-06-00", listR));

            }

            hotelBindingSource.DataSource = listH;
        }

        //----------Отображение списка номеров------------
        private void dataGridView1_CellDoubleClick(object sender,
        DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null
            || dataGridView1.CurrentRow.Index ==
            dataGridView1.RowCount - 1) // Новая строка
                return;

            FormRooms formR = new FormRooms();
            
            // Выполнить привязку сетки 2 к номерам текущей гостиницы.
            formR.h = dataGridView1.CurrentRow.Index;
            formR.roomBindingSource.DataSource = listH[formR.h].Rooms;
            
            formR.ShowDialog();
            hotelBindingSource.ResetCurrentItem(); // Для обновления количества номеров.
        }

        private void Сохранить_Click(object sender, EventArgs e)
        {
            // Создание потока
            fs = new FileStream("Отель_номера.xml", FileMode.Create);
            
            XmlSerializer xs = new XmlSerializer(typeof(List<Hotel>));
            
            // Сохраним объект в XML-файле
            xs.Serialize(fs, listH);
            fs.Close();
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            if (addForm.flagEdit)
                hotelBindingSource.ResetBindings(false);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для удаления одной или нескольких гостиниц " +
                "выделите их, щелкнув на заголовки (слева), и нажмите клавишу Delete");
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.i = dataGridView1.CurrentRow.Index;
            
            editForm.ShowDialog();

            if (editForm.flagEdit)
                hotelBindingSource.ResetCurrentItem();
        }

        //----------Отображение списка номеров------------
        private void Show_Click(object sender, EventArgs e)
        {
            dataGridView1_CellDoubleClick(null, null);
        }

        private void Author_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу создал Бондарев М.П. в рамках курсовой работы по дисциплине Современные технологии программирования");
        }

        private void About_Click(object sender, EventArgs e)
        {
            Process about = Process.Start("NotePad.exe", "Help.txt");
        }
    }
}
