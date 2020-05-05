namespace ProjectList
{
    partial class FormRooms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBoxReserv = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRoomnumber = new System.Windows.Forms.TextBox();
            this.textBoxRoomtype = new System.Windows.Forms.TextBox();
            this.textBoxPriceLow = new System.Windows.Forms.TextBox();
            this.textBoxPriceHigh = new System.Windows.Forms.TextBox();
            this.textBoxPerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxReserv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSort1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox2Sort2 = new System.Windows.Forms.CheckBox();
            this.checkBox1Sort2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.roomnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserv = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomnumber,
            this.price,
            this.roomtype,
            this.person,
            this.reserv});
            this.dataGridView2.DataSource = this.roomBindingSource;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(13, 207);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(763, 273);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView2_CellValidating);
            this.dataGridView2.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_ColumnHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(836, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(836, 250);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Edit_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.Location = new System.Drawing.Point(827, 395);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 38);
            this.button4.TabIndex = 1;
            this.button4.Text = "Удалить (Инструкция)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Delete_Click);
            // 
            // checkBoxReserv
            // 
            this.checkBoxReserv.AutoSize = true;
            this.checkBoxReserv.Location = new System.Drawing.Point(797, 440);
            this.checkBoxReserv.Name = "checkBoxReserv";
            this.checkBoxReserv.Size = new System.Drawing.Size(302, 29);
            this.checkBoxReserv.TabIndex = 3;
            this.checkBoxReserv.Text = "Выделить забронированные";
            this.checkBoxReserv.UseVisualStyleBackColor = true;
            this.checkBoxReserv.CheckedChanged += new System.EventHandler(this.Забронированные_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отображены все номера гостиницы";
            // 
            // textBoxRoomnumber
            // 
            this.textBoxRoomnumber.Location = new System.Drawing.Point(139, 31);
            this.textBoxRoomnumber.Name = "textBoxRoomnumber";
            this.textBoxRoomnumber.Size = new System.Drawing.Size(100, 30);
            this.textBoxRoomnumber.TabIndex = 5;
            // 
            // textBoxRoomtype
            // 
            this.textBoxRoomtype.Location = new System.Drawing.Point(402, 529);
            this.textBoxRoomtype.Name = "textBoxRoomtype";
            this.textBoxRoomtype.Size = new System.Drawing.Size(100, 30);
            this.textBoxRoomtype.TabIndex = 5;
            // 
            // textBoxPriceLow
            // 
            this.textBoxPriceLow.Location = new System.Drawing.Point(139, 572);
            this.textBoxPriceLow.Name = "textBoxPriceLow";
            this.textBoxPriceLow.Size = new System.Drawing.Size(80, 30);
            this.textBoxPriceLow.TabIndex = 5;
            // 
            // textBoxPriceHigh
            // 
            this.textBoxPriceHigh.Location = new System.Drawing.Point(139, 608);
            this.textBoxPriceHigh.Name = "textBoxPriceHigh";
            this.textBoxPriceHigh.Size = new System.Drawing.Size(80, 30);
            this.textBoxPriceHigh.TabIndex = 5;
            // 
            // textBoxPerson
            // 
            this.textBoxPerson.Location = new System.Drawing.Point(402, 592);
            this.textBoxPerson.Name = "textBoxPerson";
            this.textBoxPerson.Size = new System.Drawing.Size(100, 30);
            this.textBoxPerson.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(25, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(329, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(25, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Location = new System.Drawing.Point(92, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "от:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Location = new System.Drawing.Point(92, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "до:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(742, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "Применить фильтры";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Select_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(742, 597);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 36);
            this.button5.TabIndex = 9;
            this.button5.Text = "Очистить фильтры";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(742, 558);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(230, 33);
            this.button6.TabIndex = 9;
            this.button6.Text = "Показать все";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.All_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MistyRose;
            this.label8.Location = new System.Drawing.Point(253, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Кол-во персон";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MistyRose;
            this.label9.Location = new System.Drawing.Point(542, 558);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Бронь";
            // 
            // textBoxReserv
            // 
            this.textBoxReserv.Location = new System.Drawing.Point(625, 558);
            this.textBoxReserv.Name = "textBoxReserv";
            this.textBoxReserv.Size = new System.Drawing.Size(76, 30);
            this.textBoxReserv.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.checkBoxSort1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 148);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Одноуровневая сортировка";
            // 
            // checkBoxSort1
            // 
            this.checkBoxSort1.AutoSize = true;
            this.checkBoxSort1.Location = new System.Drawing.Point(486, 81);
            this.checkBoxSort1.Name = "checkBoxSort1";
            this.checkBoxSort1.Size = new System.Drawing.Size(156, 29);
            this.checkBoxSort1.TabIndex = 0;
            this.checkBoxSort1.Text = "по убыванию";
            this.checkBoxSort1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(543, 50);
            this.label10.TabIndex = 1;
            this.label10.Text = "Для сортировки номеров выберите порядок сортировки\r\nи выберите заголовок соответс" +
    "вующего столбца";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxRoomnumber);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(0, 498);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 140);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Показ номеров по фильтрам:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.checkBox2Sort2);
            this.groupBox3.Controls.Add(this.checkBox1Sort2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(705, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 148);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Двухуровневая сортировка";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(226, 41);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 33);
            this.button7.TabIndex = 2;
            this.button7.Text = "Отсортировать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Sort2_Click);
            // 
            // checkBox2Sort2
            // 
            this.checkBox2Sort2.AutoSize = true;
            this.checkBox2Sort2.Location = new System.Drawing.Point(122, 113);
            this.checkBox2Sort2.Name = "checkBox2Sort2";
            this.checkBox2Sort2.Size = new System.Drawing.Size(250, 29);
            this.checkBox2Sort2.TabIndex = 1;
            this.checkBox2Sort2.Text = "уровень 2 по убыванию";
            this.checkBox2Sort2.UseVisualStyleBackColor = true;
            // 
            // checkBox1Sort2
            // 
            this.checkBox1Sort2.AutoSize = true;
            this.checkBox1Sort2.Location = new System.Drawing.Point(26, 81);
            this.checkBox1Sort2.Name = "checkBox1Sort2";
            this.checkBox1Sort2.Size = new System.Drawing.Size(250, 29);
            this.checkBox1Sort2.TabIndex = 1;
            this.checkBox1Sort2.Text = "уровень 1 по убыванию";
            this.checkBox1Sort2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Цена → Тип комнаты",
            "Цена → Кол-во персон",
            "Кол-во персон → Тип комнаты",
            "Кол-во персон → Цена"});
            this.comboBox1.Location = new System.Drawing.Point(6, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // roomnumber
            // 
            this.roomnumber.DataPropertyName = "Roomnumber";
            this.roomnumber.HeaderText = "Номер комнаты";
            this.roomnumber.MinimumWidth = 8;
            this.roomnumber.Name = "roomnumber";
            this.roomnumber.Width = 184;
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Цена";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 94;
            // 
            // roomtype
            // 
            this.roomtype.DataPropertyName = "Roomtype";
            this.roomtype.HeaderText = "Тип комнаты";
            this.roomtype.MinimumWidth = 8;
            this.roomtype.Name = "roomtype";
            this.roomtype.Width = 158;
            // 
            // person
            // 
            this.person.DataPropertyName = "Person";
            this.person.HeaderText = "Кол-во персон";
            this.person.MinimumWidth = 8;
            this.person.Name = "person";
            this.person.Width = 166;
            // 
            // reserv
            // 
            this.reserv.DataPropertyName = "Reservation";
            this.reserv.HeaderText = "Бронь";
            this.reserv.MinimumWidth = 8;
            this.reserv.Name = "reserv";
            this.reserv.Width = 73;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(ProjectList.Room);
            // 
            // FormRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 645);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxReserv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPerson);
            this.Controls.Add(this.textBoxPriceHigh);
            this.Controls.Add(this.textBoxPriceLow);
            this.Controls.Add(this.textBoxRoomtype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxReserv);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRooms";
            this.Text = "Список номеров гостиницы ";
            this.Load += new System.EventHandler(this.FormRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBoxReserv;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn person;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reserv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRoomnumber;
        private System.Windows.Forms.TextBox textBoxRoomtype;
        private System.Windows.Forms.TextBox textBoxPriceLow;
        private System.Windows.Forms.TextBox textBoxPriceHigh;
        private System.Windows.Forms.TextBox textBoxPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxReserv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSort1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBox2Sort2;
        private System.Windows.Forms.CheckBox checkBox1Sort2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}