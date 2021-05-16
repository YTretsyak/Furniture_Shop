using System;

namespace Лабораторная_работа2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
			this.Add_Button = new System.Windows.Forms.Button();
			this.Sem1_CheckBox = new System.Windows.Forms.CheckBox();
			this.label_sem = new System.Windows.Forms.Label();
			this.LecturesAmt_TextBox = new System.Windows.Forms.TextBox();
			this.Sem2_CheckBox = new System.Windows.Forms.CheckBox();
			this.label_curs1 = new System.Windows.Forms.Label();
			this.Course_ComboBox = new System.Windows.Forms.ComboBox();
			this.label_specialization = new System.Windows.Forms.Label();
			this.Specialization_ComboBox = new System.Windows.Forms.ComboBox();
			this.label_colvo_lec = new System.Windows.Forms.Label();
			this.label_col_lab = new System.Windows.Forms.Label();
			this.LabsAmt_TextBox = new System.Windows.Forms.TextBox();
			this.label_vid_control = new System.Windows.Forms.Label();
			this.Test_ListBox = new System.Windows.Forms.ListBox();
			this.label_lector = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.Reset_Button = new System.Windows.Forms.Button();
			this.Disciplines_ListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Data_label = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.Name_TextBox = new System.Windows.Forms.TextBox();
			this.Save_Button = new System.Windows.Forms.Button();
			this.Json_TextBox = new System.Windows.Forms.TextBox();
			this.Load_Button = new System.Windows.Forms.Button();
			this.PrintJson_Button = new System.Windows.Forms.Button();
			this.Preset_Button = new System.Windows.Forms.Button();
			this.Change_Button = new System.Windows.Forms.Button();
			this.Remove_Button = new System.Windows.Forms.Button();
			this.search_button = new System.Windows.Forms.Button();
			this.SearchBox = new System.Windows.Forms.TextBox();
			this.radioCourse = new System.Windows.Forms.RadioButton();
			this.radioSemestr = new System.Windows.Forms.RadioButton();
			this.radioLector = new System.Windows.Forms.RadioButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabelSearch = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSort = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabelClear = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabelDelete = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabelNext = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabelPrevious = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabelAbout = new System.Windows.Forms.ToolStripLabel();
			this.buttonSortLc = new System.Windows.Forms.Button();
			this.buttonSortName = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.Clone_Button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Add_Button
			// 
			this.Add_Button.Location = new System.Drawing.Point(270, 345);
			this.Add_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Add_Button.Name = "Add_Button";
			this.Add_Button.Size = new System.Drawing.Size(100, 29);
			this.Add_Button.TabIndex = 0;
			this.Add_Button.Text = "Добавить";
			this.Add_Button.UseVisualStyleBackColor = true;
			this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
			// 
			// Sem1_CheckBox
			// 
			this.Sem1_CheckBox.AutoSize = true;
			this.Sem1_CheckBox.Location = new System.Drawing.Point(93, 44);
			this.Sem1_CheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Sem1_CheckBox.Name = "Sem1_CheckBox";
			this.Sem1_CheckBox.Size = new System.Drawing.Size(94, 24);
			this.Sem1_CheckBox.TabIndex = 1;
			this.Sem1_CheckBox.Text = "Первый";
			this.Sem1_CheckBox.UseVisualStyleBackColor = true;
			// 
			// label_sem
			// 
			this.label_sem.AutoSize = true;
			this.label_sem.Location = new System.Drawing.Point(10, 44);
			this.label_sem.Name = "label_sem";
			this.label_sem.Size = new System.Drawing.Size(79, 20);
			this.label_sem.TabIndex = 2;
			this.label_sem.Text = "Семестр:";
			// 
			// LecturesAmt_TextBox
			// 
			this.LecturesAmt_TextBox.Location = new System.Drawing.Point(14, 255);
			this.LecturesAmt_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LecturesAmt_TextBox.Name = "LecturesAmt_TextBox";
			this.LecturesAmt_TextBox.Size = new System.Drawing.Size(112, 26);
			this.LecturesAmt_TextBox.TabIndex = 3;
			// 
			// Sem2_CheckBox
			// 
			this.Sem2_CheckBox.AutoSize = true;
			this.Sem2_CheckBox.Location = new System.Drawing.Point(93, 69);
			this.Sem2_CheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Sem2_CheckBox.Name = "Sem2_CheckBox";
			this.Sem2_CheckBox.Size = new System.Drawing.Size(91, 24);
			this.Sem2_CheckBox.TabIndex = 1;
			this.Sem2_CheckBox.Text = "Второй";
			this.Sem2_CheckBox.UseVisualStyleBackColor = true;
			// 
			// label_curs1
			// 
			this.label_curs1.AutoSize = true;
			this.label_curs1.Location = new System.Drawing.Point(14, 89);
			this.label_curs1.Name = "label_curs1";
			this.label_curs1.Size = new System.Drawing.Size(47, 20);
			this.label_curs1.TabIndex = 2;
			this.label_curs1.Text = "Курс:";
			// 
			// Course_ComboBox
			// 
			this.Course_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Course_ComboBox.FormattingEnabled = true;
			this.Course_ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.Course_ComboBox.Location = new System.Drawing.Point(14, 114);
			this.Course_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Course_ComboBox.Name = "Course_ComboBox";
			this.Course_ComboBox.Size = new System.Drawing.Size(136, 28);
			this.Course_ComboBox.TabIndex = 4;
			// 
			// label_specialization
			// 
			this.label_specialization.AutoSize = true;
			this.label_specialization.Location = new System.Drawing.Point(14, 159);
			this.label_specialization.Name = "label_specialization";
			this.label_specialization.Size = new System.Drawing.Size(132, 20);
			this.label_specialization.TabIndex = 2;
			this.label_specialization.Text = "Специальность:";
			// 
			// Specialization_ComboBox
			// 
			this.Specialization_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Specialization_ComboBox.FormattingEnabled = true;
			this.Specialization_ComboBox.Items.AddRange(new object[] {
            "ПОИТ",
            "ДЭИВИ",
            "ИСИТ",
            "ПОИБМС"});
			this.Specialization_ComboBox.Location = new System.Drawing.Point(14, 184);
			this.Specialization_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Specialization_ComboBox.Name = "Specialization_ComboBox";
			this.Specialization_ComboBox.Size = new System.Drawing.Size(136, 28);
			this.Specialization_ComboBox.TabIndex = 4;
			// 
			// label_colvo_lec
			// 
			this.label_colvo_lec.AutoSize = true;
			this.label_colvo_lec.Location = new System.Drawing.Point(14, 230);
			this.label_colvo_lec.Name = "label_colvo_lec";
			this.label_colvo_lec.Size = new System.Drawing.Size(162, 20);
			this.label_colvo_lec.TabIndex = 2;
			this.label_colvo_lec.Text = "Количество лекций:";
			// 
			// label_col_lab
			// 
			this.label_col_lab.AutoSize = true;
			this.label_col_lab.Location = new System.Drawing.Point(14, 301);
			this.label_col_lab.Name = "label_col_lab";
			this.label_col_lab.Size = new System.Drawing.Size(217, 20);
			this.label_col_lab.TabIndex = 2;
			this.label_col_lab.Text = "Количество лабораторных:";
			// 
			// LabsAmt_TextBox
			// 
			this.LabsAmt_TextBox.Location = new System.Drawing.Point(14, 326);
			this.LabsAmt_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LabsAmt_TextBox.Name = "LabsAmt_TextBox";
			this.LabsAmt_TextBox.Size = new System.Drawing.Size(112, 26);
			this.LabsAmt_TextBox.TabIndex = 3;
			// 
			// label_vid_control
			// 
			this.label_vid_control.AutoSize = true;
			this.label_vid_control.Location = new System.Drawing.Point(14, 370);
			this.label_vid_control.Name = "label_vid_control";
			this.label_vid_control.Size = new System.Drawing.Size(120, 20);
			this.label_vid_control.TabIndex = 2;
			this.label_vid_control.Text = "Вид контроля:";
			// 
			// Test_ListBox
			// 
			this.Test_ListBox.FormattingEnabled = true;
			this.Test_ListBox.ItemHeight = 20;
			this.Test_ListBox.Items.AddRange(new object[] {
            "Экзамен",
            "Зачет"});
			this.Test_ListBox.Location = new System.Drawing.Point(14, 395);
			this.Test_ListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Test_ListBox.Name = "Test_ListBox";
			this.Test_ListBox.Size = new System.Drawing.Size(112, 44);
			this.Test_ListBox.TabIndex = 6;
			// 
			// label_lector
			// 
			this.label_lector.AutoSize = true;
			this.label_lector.Location = new System.Drawing.Point(267, 41);
			this.label_lector.Name = "label_lector";
			this.label_lector.Size = new System.Drawing.Size(69, 20);
			this.label_lector.TabIndex = 2;
			this.label_lector.Text = "Лектор:";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(270, 68);
			this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(249, 24);
			this.radioButton1.TabIndex = 7;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Урбанович Павел Павлович";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(270, 101);
			this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(283, 24);
			this.radioButton2.TabIndex = 7;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Жиляк Надежда Александровна";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(270, 135);
			this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(302, 24);
			this.radioButton3.TabIndex = 7;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Пустовалова Наталья Николаевна";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(270, 169);
			this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(302, 24);
			this.radioButton4.TabIndex = 7;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Смелов Владимир Владиславович";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(270, 202);
			this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(293, 24);
			this.radioButton5.TabIndex = 7;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "Колесников Виталий Леонидович";
			this.radioButton5.UseVisualStyleBackColor = true;
			// 
			// Reset_Button
			// 
			this.Reset_Button.Location = new System.Drawing.Point(580, 51);
			this.Reset_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Reset_Button.Name = "Reset_Button";
			this.Reset_Button.Size = new System.Drawing.Size(100, 29);
			this.Reset_Button.TabIndex = 0;
			this.Reset_Button.Text = "Сбросить";
			this.Reset_Button.UseVisualStyleBackColor = true;
			this.Reset_Button.UseWaitCursor = true;
			this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
			// 
			// Disciplines_ListView
			// 
			this.Disciplines_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Disciplines_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader11,
            this.columnHeader12});
			this.Disciplines_ListView.FullRowSelect = true;
			this.Disciplines_ListView.GridLines = true;
			this.Disciplines_ListView.HideSelection = false;
			this.Disciplines_ListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.Disciplines_ListView.Location = new System.Drawing.Point(10, 492);
			this.Disciplines_ListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Disciplines_ListView.Name = "Disciplines_ListView";
			this.Disciplines_ListView.Size = new System.Drawing.Size(1623, 345);
			this.Disciplines_ListView.TabIndex = 22;
			this.Disciplines_ListView.UseCompatibleStateImageBehavior = false;
			this.Disciplines_ListView.View = System.Windows.Forms.View.Details;
			this.Disciplines_ListView.SelectedIndexChanged += new System.EventHandler(this.Disciplines_ListView_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Название";
			this.columnHeader1.Width = 89;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Курс";
			this.columnHeader8.Width = 43;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Семестр";
			this.columnHeader2.Width = 105;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Вид контроля";
			this.columnHeader3.Width = 83;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Количество лекций (в семестре)";
			this.columnHeader4.Width = 179;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Количество лабораторных (в семестре)";
			this.columnHeader5.Width = 214;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Специальность";
			this.columnHeader6.Width = 97;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Лектор";
			this.columnHeader7.Width = 198;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Кафедра";
			this.columnHeader11.Width = 120;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Должность";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(1104, 42);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(224, 26);
			this.dateTimePicker1.TabIndex = 9;
			this.dateTimePicker1.UseWaitCursor = true;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// Data_label
			// 
			this.Data_label.AutoSize = true;
			this.Data_label.Location = new System.Drawing.Point(1100, 90);
			this.Data_label.Name = "Data_label";
			this.Data_label.Size = new System.Drawing.Size(0, 20);
			this.Data_label.TabIndex = 10;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.Clock_Timer_Tick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(267, 261);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 20);
			this.label1.TabIndex = 23;
			this.label1.Text = "Название дисциплины";
			// 
			// Name_TextBox
			// 
			this.Name_TextBox.Location = new System.Drawing.Point(270, 295);
			this.Name_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name_TextBox.Name = "Name_TextBox";
			this.Name_TextBox.Size = new System.Drawing.Size(181, 26);
			this.Name_TextBox.TabIndex = 3;
			// 
			// Save_Button
			// 
			this.Save_Button.Location = new System.Drawing.Point(903, 395);
			this.Save_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Save_Button.Name = "Save_Button";
			this.Save_Button.Size = new System.Drawing.Size(140, 45);
			this.Save_Button.TabIndex = 30;
			this.Save_Button.Text = "Сохранить";
			this.Save_Button.UseVisualStyleBackColor = true;
			this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
			// 
			// Json_TextBox
			// 
			this.Json_TextBox.Location = new System.Drawing.Point(681, 85);
			this.Json_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Json_TextBox.Multiline = true;
			this.Json_TextBox.Name = "Json_TextBox";
			this.Json_TextBox.Size = new System.Drawing.Size(396, 165);
			this.Json_TextBox.TabIndex = 31;
			// 
			// Load_Button
			// 
			this.Load_Button.Location = new System.Drawing.Point(1048, 394);
			this.Load_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Load_Button.Name = "Load_Button";
			this.Load_Button.Size = new System.Drawing.Size(151, 45);
			this.Load_Button.TabIndex = 32;
			this.Load_Button.Text = "Загрузить";
			this.Load_Button.UseVisualStyleBackColor = true;
			this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
			// 
			// PrintJson_Button
			// 
			this.PrintJson_Button.Location = new System.Drawing.Point(757, 394);
			this.PrintJson_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PrintJson_Button.Name = "PrintJson_Button";
			this.PrintJson_Button.Size = new System.Drawing.Size(140, 45);
			this.PrintJson_Button.TabIndex = 33;
			this.PrintJson_Button.Text = "JSON";
			this.PrintJson_Button.UseVisualStyleBackColor = true;
			this.PrintJson_Button.Click += new System.EventHandler(this.PrintJson_Button_Click);
			// 
			// Preset_Button
			// 
			this.Preset_Button.Location = new System.Drawing.Point(271, 382);
			this.Preset_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Preset_Button.Name = "Preset_Button";
			this.Preset_Button.Size = new System.Drawing.Size(100, 29);
			this.Preset_Button.TabIndex = 34;
			this.Preset_Button.Text = "Preset";
			this.Preset_Button.UseVisualStyleBackColor = true;
			this.Preset_Button.Click += new System.EventHandler(this.Preset_Button_Click);
			// 
			// Change_Button
			// 
			this.Change_Button.Location = new System.Drawing.Point(376, 345);
			this.Change_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Change_Button.Name = "Change_Button";
			this.Change_Button.Size = new System.Drawing.Size(100, 29);
			this.Change_Button.TabIndex = 35;
			this.Change_Button.Text = "Изменить";
			this.Change_Button.UseVisualStyleBackColor = true;
			this.Change_Button.Click += new System.EventHandler(this.Change_Button_Click);
			// 
			// Remove_Button
			// 
			this.Remove_Button.Location = new System.Drawing.Point(482, 345);
			this.Remove_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Remove_Button.Name = "Remove_Button";
			this.Remove_Button.Size = new System.Drawing.Size(100, 29);
			this.Remove_Button.TabIndex = 36;
			this.Remove_Button.Text = "Удалить";
			this.Remove_Button.UseVisualStyleBackColor = true;
			this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
			// 
			// search_button
			// 
			this.search_button.Location = new System.Drawing.Point(1516, 226);
			this.search_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.search_button.Name = "search_button";
			this.search_button.Size = new System.Drawing.Size(117, 48);
			this.search_button.TabIndex = 37;
			this.search_button.Text = "Поиск";
			this.search_button.UseVisualStyleBackColor = true;
			this.search_button.Click += new System.EventHandler(this.Search_button_Click);
			// 
			// SearchBox
			// 
			this.SearchBox.Location = new System.Drawing.Point(1212, 226);
			this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SearchBox.Multiline = true;
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Size = new System.Drawing.Size(285, 44);
			this.SearchBox.TabIndex = 38;
			// 
			// radioCourse
			// 
			this.radioCourse.AutoSize = true;
			this.radioCourse.Location = new System.Drawing.Point(1212, 184);
			this.radioCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radioCourse.Name = "radioCourse";
			this.radioCourse.Size = new System.Drawing.Size(68, 24);
			this.radioCourse.TabIndex = 39;
			this.radioCourse.TabStop = true;
			this.radioCourse.Text = "Курс";
			this.radioCourse.UseVisualStyleBackColor = true;
			// 
			// radioSemestr
			// 
			this.radioSemestr.AutoSize = true;
			this.radioSemestr.Location = new System.Drawing.Point(1305, 184);
			this.radioSemestr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radioSemestr.Name = "radioSemestr";
			this.radioSemestr.Size = new System.Drawing.Size(100, 24);
			this.radioSemestr.TabIndex = 39;
			this.radioSemestr.TabStop = true;
			this.radioSemestr.Text = "Семестр";
			this.radioSemestr.UseVisualStyleBackColor = true;
			// 
			// radioLector
			// 
			this.radioLector.AutoSize = true;
			this.radioLector.Location = new System.Drawing.Point(1423, 184);
			this.radioLector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radioLector.Name = "radioLector";
			this.radioLector.Size = new System.Drawing.Size(90, 24);
			this.radioLector.TabIndex = 39;
			this.radioLector.TabStop = true;
			this.radioLector.Text = "Лектор";
			this.radioLector.UseVisualStyleBackColor = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelSearch,
            this.toolStripSort,
            this.toolStripLabelClear,
            this.toolStripLabelDelete,
            this.toolStripLabelNext,
            this.toolStripLabelPrevious,
            this.toolStripLabelAbout});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1648, 38);
			this.toolStrip1.TabIndex = 40;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabelSearch
			// 
			this.toolStripLabelSearch.Name = "toolStripLabelSearch";
			this.toolStripLabelSearch.RightToLeftAutoMirrorImage = true;
			this.toolStripLabelSearch.Size = new System.Drawing.Size(64, 33);
			this.toolStripLabelSearch.Text = "Search";
			this.toolStripLabelSearch.Click += new System.EventHandler(this.toolStripLabelSearch_Click);
			// 
			// toolStripSort
			// 
			this.toolStripSort.Name = "toolStripSort";
			this.toolStripSort.Size = new System.Drawing.Size(45, 33);
			this.toolStripSort.Text = "Sort";
			// 
			// toolStripLabelClear
			// 
			this.toolStripLabelClear.Name = "toolStripLabelClear";
			this.toolStripLabelClear.Size = new System.Drawing.Size(51, 33);
			this.toolStripLabelClear.Text = "Clear";
			this.toolStripLabelClear.Click += new System.EventHandler(this.toolStripLabelClear_Click);
			// 
			// toolStripLabelDelete
			// 
			this.toolStripLabelDelete.Name = "toolStripLabelDelete";
			this.toolStripLabelDelete.Size = new System.Drawing.Size(62, 33);
			this.toolStripLabelDelete.Text = "Delete";
			this.toolStripLabelDelete.Click += new System.EventHandler(this.toolStripLabelDelete_Click);
			// 
			// toolStripLabelNext
			// 
			this.toolStripLabelNext.Name = "toolStripLabelNext";
			this.toolStripLabelNext.Size = new System.Drawing.Size(48, 33);
			this.toolStripLabelNext.Text = "Next";
			this.toolStripLabelNext.Click += new System.EventHandler(this.toolStripLabelNext_Click);
			// 
			// toolStripLabelPrevious
			// 
			this.toolStripLabelPrevious.Name = "toolStripLabelPrevious";
			this.toolStripLabelPrevious.Size = new System.Drawing.Size(79, 33);
			this.toolStripLabelPrevious.Text = "Previous";
			this.toolStripLabelPrevious.Click += new System.EventHandler(this.toolStripLabelPrevious_Click);
			// 
			// toolStripLabelAbout
			// 
			this.toolStripLabelAbout.Name = "toolStripLabelAbout";
			this.toolStripLabelAbout.Size = new System.Drawing.Size(125, 33);
			this.toolStripLabelAbout.Text = "О программе";
			this.toolStripLabelAbout.Click += new System.EventHandler(this.toolStripLabelAbout_Click);
			// 
			// buttonSortLc
			// 
			this.buttonSortLc.Location = new System.Drawing.Point(271, 419);
			this.buttonSortLc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonSortLc.Name = "buttonSortLc";
			this.buttonSortLc.Size = new System.Drawing.Size(180, 65);
			this.buttonSortLc.TabIndex = 41;
			this.buttonSortLc.Text = "Сортировать по кол-ву лекций";
			this.buttonSortLc.UseVisualStyleBackColor = true;
			this.buttonSortLc.Click += new System.EventHandler(this.buttonSortLc_Click);
			// 
			// buttonSortName
			// 
			this.buttonSortName.Location = new System.Drawing.Point(482, 419);
			this.buttonSortName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonSortName.Name = "buttonSortName";
			this.buttonSortName.Size = new System.Drawing.Size(164, 65);
			this.buttonSortName.TabIndex = 41;
			this.buttonSortName.Text = "Сортировать по виду контроля";
			this.buttonSortName.UseVisualStyleBackColor = true;
			this.buttonSortName.Click += new System.EventHandler(this.buttonSortName_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1104, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(18, 20);
			this.label2.TabIndex = 42;
			this.label2.Text = "0";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(422, 2);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 29);
			this.button1.TabIndex = 43;
			this.button1.Text = "Скрыть";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Clone_Button
			// 
			this.Clone_Button.Location = new System.Drawing.Point(376, 382);
			this.Clone_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Clone_Button.Name = "Clone_Button";
			this.Clone_Button.Size = new System.Drawing.Size(100, 29);
			this.Clone_Button.TabIndex = 44;
			this.Clone_Button.Text = "Clone";
			this.Clone_Button.UseVisualStyleBackColor = true;
			this.Clone_Button.Click += new System.EventHandler(this.Clone_Button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1648, 860);
			this.Controls.Add(this.Clone_Button);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonSortName);
			this.Controls.Add(this.buttonSortLc);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.radioLector);
			this.Controls.Add(this.radioSemestr);
			this.Controls.Add(this.radioCourse);
			this.Controls.Add(this.SearchBox);
			this.Controls.Add(this.search_button);
			this.Controls.Add(this.Remove_Button);
			this.Controls.Add(this.Change_Button);
			this.Controls.Add(this.Preset_Button);
			this.Controls.Add(this.PrintJson_Button);
			this.Controls.Add(this.Load_Button);
			this.Controls.Add(this.Json_TextBox);
			this.Controls.Add(this.Save_Button);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Data_label);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.Disciplines_ListView);
			this.Controls.Add(this.radioButton5);
			this.Controls.Add(this.radioButton4);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.Test_ListBox);
			this.Controls.Add(this.Specialization_ComboBox);
			this.Controls.Add(this.Course_ComboBox);
			this.Controls.Add(this.LabsAmt_TextBox);
			this.Controls.Add(this.Name_TextBox);
			this.Controls.Add(this.LecturesAmt_TextBox);
			this.Controls.Add(this.label_curs1);
			this.Controls.Add(this.label_vid_control);
			this.Controls.Add(this.label_col_lab);
			this.Controls.Add(this.label_colvo_lec);
			this.Controls.Add(this.label_specialization);
			this.Controls.Add(this.label_lector);
			this.Controls.Add(this.label_sem);
			this.Controls.Add(this.Sem2_CheckBox);
			this.Controls.Add(this.Sem1_CheckBox);
			this.Controls.Add(this.Reset_Button);
			this.Controls.Add(this.Add_Button);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MinimumSize = new System.Drawing.Size(1499, 797);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.CheckBox Sem1_CheckBox;
        private System.Windows.Forms.Label label_sem;
        private System.Windows.Forms.TextBox LecturesAmt_TextBox;
        private System.Windows.Forms.CheckBox Sem2_CheckBox;
        private System.Windows.Forms.Label label_curs1;
        private System.Windows.Forms.ComboBox Course_ComboBox;
        private System.Windows.Forms.Label label_specialization;
        private System.Windows.Forms.ComboBox Specialization_ComboBox;
        private System.Windows.Forms.Label label_colvo_lec;
        private System.Windows.Forms.Label label_col_lab;
        private System.Windows.Forms.TextBox LabsAmt_TextBox;
        private System.Windows.Forms.Label label_vid_control;
        private System.Windows.Forms.ListBox Test_ListBox;
        private System.Windows.Forms.Label label_lector;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.ListView Disciplines_ListView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Data_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.TextBox Json_TextBox;
        private System.Windows.Forms.Button Load_Button;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.Button PrintJson_Button;
		private System.Windows.Forms.Button Preset_Button;
		private System.Windows.Forms.Button Remove_Button;
		private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.RadioButton radioLector;
        private System.Windows.Forms.RadioButton radioSemestr;
        private System.Windows.Forms.RadioButton radioCourse;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSearch;
        private System.Windows.Forms.ToolStripLabel toolStripSort;
        private System.Windows.Forms.ToolStripLabel toolStripLabelClear;
        private System.Windows.Forms.ToolStripLabel toolStripLabelDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabelNext;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPrevious;
        private System.Windows.Forms.ToolStripLabel toolStripLabelAbout;
        private System.Windows.Forms.Button buttonSortName;
        private System.Windows.Forms.Button buttonSortLc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Clone_Button;
	}
}

