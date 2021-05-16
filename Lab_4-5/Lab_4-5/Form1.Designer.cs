
namespace Lab_4_5
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
        public void InitializeComponent()
        {
            this.display_RTB = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveWithoutAddress_btn = new System.Windows.Forms.Button();
            this.clone_btn = new System.Windows.Forms.Button();
            this.display_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.apartmentArea_numeric = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.apartmentNumber_numeric = new System.Windows.Forms.NumericUpDown();
            this.house_numeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.street_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.country_CB = new System.Windows.Forms.ComboBox();
            this.city_TB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.availability_checkedLB = new System.Windows.Forms.CheckedListBox();
            this.numberOfRooms_numeric = new System.Windows.Forms.NumericUpDown();
            this.materialMonolith_RB = new System.Windows.Forms.RadioButton();
            this.materialBrick_RB = new System.Windows.Forms.RadioButton();
            this.yearOfConstruction_DTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.floor_TB = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackbar_lbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.displayWithSort_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentArea_numeric)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentNumber_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.house_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRooms_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor_TB)).BeginInit();
            this.SuspendLayout();
            // 
            // display_RTB
            // 
            this.display_RTB.Location = new System.Drawing.Point(604, 6);
            this.display_RTB.Name = "display_RTB";
            this.display_RTB.Size = new System.Drawing.Size(601, 413);
            this.display_RTB.TabIndex = 63;
            this.display_RTB.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.displayWithSort_btn);
            this.panel2.Controls.Add(this.saveWithoutAddress_btn);
            this.panel2.Controls.Add(this.clone_btn);
            this.panel2.Controls.Add(this.display_btn);
            this.panel2.Controls.Add(this.save_btn);
            this.panel2.Location = new System.Drawing.Point(288, 314);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 158);
            this.panel2.TabIndex = 62;
            // 
            // saveWithoutAddress_btn
            // 
            this.saveWithoutAddress_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveWithoutAddress_btn.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveWithoutAddress_btn.Location = new System.Drawing.Point(182, 114);
            this.saveWithoutAddress_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveWithoutAddress_btn.Name = "saveWithoutAddress_btn";
            this.saveWithoutAddress_btn.Size = new System.Drawing.Size(119, 42);
            this.saveWithoutAddress_btn.TabIndex = 68;
            this.saveWithoutAddress_btn.Text = "Save Without Address";
            this.saveWithoutAddress_btn.UseVisualStyleBackColor = false;
            this.saveWithoutAddress_btn.Click += new System.EventHandler(this.saveWithoutAddress_btn_Click);
            // 
            // clone_btn
            // 
            this.clone_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clone_btn.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clone_btn.Location = new System.Drawing.Point(93, 51);
            this.clone_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clone_btn.Name = "clone_btn";
            this.clone_btn.Size = new System.Drawing.Size(107, 46);
            this.clone_btn.TabIndex = 67;
            this.clone_btn.Text = "Clone Last";
            this.clone_btn.UseVisualStyleBackColor = false;
            this.clone_btn.Click += new System.EventHandler(this.clone_btn_Click);
            // 
            // display_btn
            // 
            this.display_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.display_btn.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display_btn.Location = new System.Drawing.Point(0, 1);
            this.display_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.display_btn.Name = "display_btn";
            this.display_btn.Size = new System.Drawing.Size(107, 42);
            this.display_btn.TabIndex = 26;
            this.display_btn.Text = "Display";
            this.display_btn.UseVisualStyleBackColor = false;
            this.display_btn.Click += new System.EventHandler(this.display_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.save_btn.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.Location = new System.Drawing.Point(0, 114);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(105, 42);
            this.save_btn.TabIndex = 25;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // apartmentArea_numeric
            // 
            this.apartmentArea_numeric.Location = new System.Drawing.Point(122, 108);
            this.apartmentArea_numeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apartmentArea_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.apartmentArea_numeric.Name = "apartmentArea_numeric";
            this.apartmentArea_numeric.Size = new System.Drawing.Size(137, 22);
            this.apartmentArea_numeric.TabIndex = 59;
            this.apartmentArea_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.apartmentNumber_numeric);
            this.panel1.Controls.Add(this.house_numeric);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.street_TB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.country_CB);
            this.panel1.Controls.Add(this.city_TB);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(288, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 304);
            this.panel1.TabIndex = 61;
            // 
            // apartmentNumber_numeric
            // 
            this.apartmentNumber_numeric.Location = new System.Drawing.Point(145, 265);
            this.apartmentNumber_numeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apartmentNumber_numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.apartmentNumber_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.apartmentNumber_numeric.Name = "apartmentNumber_numeric";
            this.apartmentNumber_numeric.Size = new System.Drawing.Size(127, 22);
            this.apartmentNumber_numeric.TabIndex = 24;
            this.apartmentNumber_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // house_numeric
            // 
            this.house_numeric.Location = new System.Drawing.Point(147, 224);
            this.house_numeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.house_numeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.house_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.house_numeric.Name = "house_numeric";
            this.house_numeric.Size = new System.Drawing.Size(127, 22);
            this.house_numeric.TabIndex = 23;
            this.house_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "House";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Street";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Country";
            // 
            // street_TB
            // 
            this.street_TB.Location = new System.Drawing.Point(145, 183);
            this.street_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.street_TB.MaxLength = 20;
            this.street_TB.Name = "street_TB";
            this.street_TB.Size = new System.Drawing.Size(127, 22);
            this.street_TB.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // country_CB
            // 
            this.country_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.country_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.country_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.country_CB.FormattingEnabled = true;
            this.country_CB.Items.AddRange(new object[] {
            "Poland",
            "Germany",
            "France",
            "United Kingdom"});
            this.country_CB.Location = new System.Drawing.Point(145, 101);
            this.country_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.country_CB.Name = "country_CB";
            this.country_CB.Size = new System.Drawing.Size(127, 24);
            this.country_CB.TabIndex = 20;
            // 
            // city_TB
            // 
            this.city_TB.Location = new System.Drawing.Point(145, 142);
            this.city_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.city_TB.MaxLength = 20;
            this.city_TB.Name = "city_TB";
            this.city_TB.Size = new System.Drawing.Size(127, 22);
            this.city_TB.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(20, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Apartment number";
            // 
            // availability_checkedLB
            // 
            this.availability_checkedLB.CheckOnClick = true;
            this.availability_checkedLB.FormattingEnabled = true;
            this.availability_checkedLB.Items.AddRange(new object[] {
            "kitchen",
            "bathroom",
            "basement",
            "balcony"});
            this.availability_checkedLB.Location = new System.Drawing.Point(121, 196);
            this.availability_checkedLB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.availability_checkedLB.Name = "availability_checkedLB";
            this.availability_checkedLB.Size = new System.Drawing.Size(138, 72);
            this.availability_checkedLB.TabIndex = 58;
            // 
            // numberOfRooms_numeric
            // 
            this.numberOfRooms_numeric.Location = new System.Drawing.Point(121, 146);
            this.numberOfRooms_numeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfRooms_numeric.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numberOfRooms_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfRooms_numeric.Name = "numberOfRooms_numeric";
            this.numberOfRooms_numeric.Size = new System.Drawing.Size(138, 22);
            this.numberOfRooms_numeric.TabIndex = 57;
            this.numberOfRooms_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materialMonolith_RB
            // 
            this.materialMonolith_RB.AutoSize = true;
            this.materialMonolith_RB.Location = new System.Drawing.Point(187, 294);
            this.materialMonolith_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialMonolith_RB.Name = "materialMonolith_RB";
            this.materialMonolith_RB.Size = new System.Drawing.Size(82, 21);
            this.materialMonolith_RB.TabIndex = 56;
            this.materialMonolith_RB.Text = "Monolith";
            this.materialMonolith_RB.UseVisualStyleBackColor = true;
            // 
            // materialBrick_RB
            // 
            this.materialBrick_RB.AutoSize = true;
            this.materialBrick_RB.Location = new System.Drawing.Point(121, 294);
            this.materialBrick_RB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialBrick_RB.Name = "materialBrick_RB";
            this.materialBrick_RB.Size = new System.Drawing.Size(60, 21);
            this.materialBrick_RB.TabIndex = 55;
            this.materialBrick_RB.Text = "Brick";
            this.materialBrick_RB.UseVisualStyleBackColor = true;
            // 
            // yearOfConstruction_DTP
            // 
            this.yearOfConstruction_DTP.CustomFormat = "yyyy";
            this.yearOfConstruction_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearOfConstruction_DTP.Location = new System.Drawing.Point(144, 397);
            this.yearOfConstruction_DTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearOfConstruction_DTP.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.yearOfConstruction_DTP.Name = "yearOfConstruction_DTP";
            this.yearOfConstruction_DTP.Size = new System.Drawing.Size(115, 22);
            this.yearOfConstruction_DTP.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Year of construction";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Apartment area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Number of rooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-220, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Availability";
            // 
            // floor_TB
            // 
            this.floor_TB.Location = new System.Drawing.Point(122, 337);
            this.floor_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.floor_TB.Maximum = 20;
            this.floor_TB.Name = "floor_TB";
            this.floor_TB.Size = new System.Drawing.Size(147, 56);
            this.floor_TB.TabIndex = 47;
            this.floor_TB.Scroll += new System.EventHandler(this.floor_TB_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Apartment";
            // 
            // trackbar_lbl
            // 
            this.trackbar_lbl.AutoSize = true;
            this.trackbar_lbl.Location = new System.Drawing.Point(85, 340);
            this.trackbar_lbl.Name = "trackbar_lbl";
            this.trackbar_lbl.Size = new System.Drawing.Size(16, 17);
            this.trackbar_lbl.TabIndex = 66;
            this.trackbar_lbl.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 65;
            this.label13.Text = "Floor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Material type";
            // 
            // displayWithSort_btn
            // 
            this.displayWithSort_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.displayWithSort_btn.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.displayWithSort_btn.Location = new System.Drawing.Point(194, 2);
            this.displayWithSort_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayWithSort_btn.Name = "displayWithSort_btn";
            this.displayWithSort_btn.Size = new System.Drawing.Size(107, 42);
            this.displayWithSort_btn.TabIndex = 67;
            this.displayWithSort_btn.Text = "Display With Sort";
            this.displayWithSort_btn.UseVisualStyleBackColor = false;
            this.displayWithSort_btn.Click += new System.EventHandler(this.displayWithSort_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 491);
            this.Controls.Add(this.trackbar_lbl);
            this.Controls.Add(this.display_RTB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.apartmentArea_numeric);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.availability_checkedLB);
            this.Controls.Add(this.numberOfRooms_numeric);
            this.Controls.Add(this.materialMonolith_RB);
            this.Controls.Add(this.materialBrick_RB);
            this.Controls.Add(this.yearOfConstruction_DTP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.floor_TB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apartmentArea_numeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentNumber_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.house_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRooms_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor_TB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox display_RTB;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button display_btn;
        public System.Windows.Forms.Button save_btn;
        public System.Windows.Forms.NumericUpDown apartmentArea_numeric;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.NumericUpDown apartmentNumber_numeric;
        public System.Windows.Forms.NumericUpDown house_numeric;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox street_TB;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox country_CB;
        public System.Windows.Forms.TextBox city_TB;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.CheckedListBox availability_checkedLB;
        public System.Windows.Forms.NumericUpDown numberOfRooms_numeric;
        public System.Windows.Forms.RadioButton materialMonolith_RB;
        public System.Windows.Forms.RadioButton materialBrick_RB;
        public System.Windows.Forms.DateTimePicker yearOfConstruction_DTP;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TrackBar floor_TB;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label trackbar_lbl;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button clone_btn;
        public System.Windows.Forms.Button saveWithoutAddress_btn;
        public System.Windows.Forms.Button displayWithSort_btn;
    }
}

