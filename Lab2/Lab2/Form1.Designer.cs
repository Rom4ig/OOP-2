﻿namespace Lab2
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
            this.Airplane_List = new System.Windows.Forms.ListBox();
            this.Crewman_Add = new System.Windows.Forms.Button();
            this.Airplane_Space = new System.Windows.Forms.NumericUpDown();
            this.Airplane_Type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Airplane_DateOfMaintenance = new System.Windows.Forms.MonthCalendar();
            this.Crewman_Sex_Female = new System.Windows.Forms.RadioButton();
            this.Crewman_Sex_Male = new System.Windows.Forms.RadioButton();
            this.Airplane_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Airplane_YearOfConstruction = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Airplane_LoadCarryingCapacity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Crewman_FirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Crewman_SecondName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Crewman_Position = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Crewman_Age = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Airplane_Add = new System.Windows.Forms.Button();
            this.Crewman_Experience = new System.Windows.Forms.NumericUpDown();
            this.Airplane_Crew = new System.Windows.Forms.CheckedListBox();
            this.Company_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Company_Country = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Company_Year = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Company_Type_Cargo = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Company_Type_Passenger = new System.Windows.Forms.CheckBox();
            this.Company_Type_Military = new System.Windows.Forms.CheckBox();
            this.Company_Add = new System.Windows.Forms.Button();
            this.Company_List = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Airplane_Model = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Crewman_List = new System.Windows.Forms.ListBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Crewman_Clear = new System.Windows.Forms.Button();
            this.Company_Clear = new System.Windows.Forms.Button();
            this.Airplane_Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Save_Dialog = new System.Windows.Forms.SaveFileDialog();
            this.Open_Dialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Airplane_Space)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crewman_Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crewman_Experience)).BeginInit();
            this.SuspendLayout();
            // 
            // Airplane_List
            // 
            this.Airplane_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Airplane_List.FormattingEnabled = true;
            this.Airplane_List.ItemHeight = 15;
            this.Airplane_List.Location = new System.Drawing.Point(777, 425);
            this.Airplane_List.Name = "Airplane_List";
            this.Airplane_List.Size = new System.Drawing.Size(569, 109);
            this.Airplane_List.TabIndex = 43;
            // 
            // Crewman_Add
            // 
            this.Crewman_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Crewman_Add.Location = new System.Drawing.Point(47, 272);
            this.Crewman_Add.Name = "Crewman_Add";
            this.Crewman_Add.Size = new System.Drawing.Size(136, 53);
            this.Crewman_Add.TabIndex = 40;
            this.Crewman_Add.Text = "Add to list of crewmans";
            this.Crewman_Add.UseVisualStyleBackColor = true;
            this.Crewman_Add.Click += new System.EventHandler(this.Crewman_Add_Click);
            // 
            // Airplane_Space
            // 
            this.Airplane_Space.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Airplane_Space.Location = new System.Drawing.Point(974, 151);
            this.Airplane_Space.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Airplane_Space.Name = "Airplane_Space";
            this.Airplane_Space.Size = new System.Drawing.Size(123, 24);
            this.Airplane_Space.TabIndex = 39;
            // 
            // Airplane_Type
            // 
            this.Airplane_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Airplane_Type.FormattingEnabled = true;
            this.Airplane_Type.Location = new System.Drawing.Point(1142, 82);
            this.Airplane_Type.Name = "Airplane_Type";
            this.Airplane_Type.Size = new System.Drawing.Size(195, 26);
            this.Airplane_Type.TabIndex = 37;
            this.Airplane_Type.SelectedIndexChanged += new System.EventHandler(this.Airplane_Type_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1184, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Airplane\'s type";
            // 
            // Airplane_DateOfMaintenance
            // 
            this.Airplane_DateOfMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Airplane_DateOfMaintenance.Location = new System.Drawing.Point(1379, 168);
            this.Airplane_DateOfMaintenance.Name = "Airplane_DateOfMaintenance";
            this.Airplane_DateOfMaintenance.TabIndex = 31;
            // 
            // Crewman_Sex_Female
            // 
            this.Crewman_Sex_Female.AutoSize = true;
            this.Crewman_Sex_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Crewman_Sex_Female.Location = new System.Drawing.Point(244, 219);
            this.Crewman_Sex_Female.Name = "Crewman_Sex_Female";
            this.Crewman_Sex_Female.Size = new System.Drawing.Size(75, 22);
            this.Crewman_Sex_Female.TabIndex = 29;
            this.Crewman_Sex_Female.TabStop = true;
            this.Crewman_Sex_Female.Text = "Female";
            this.Crewman_Sex_Female.UseVisualStyleBackColor = true;
            // 
            // Crewman_Sex_Male
            // 
            this.Crewman_Sex_Male.AutoSize = true;
            this.Crewman_Sex_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Crewman_Sex_Male.Location = new System.Drawing.Point(180, 219);
            this.Crewman_Sex_Male.Name = "Crewman_Sex_Male";
            this.Crewman_Sex_Male.Size = new System.Drawing.Size(58, 22);
            this.Crewman_Sex_Male.TabIndex = 28;
            this.Crewman_Sex_Male.TabStop = true;
            this.Crewman_Sex_Male.Text = "Мale";
            this.Crewman_Sex_Male.UseVisualStyleBackColor = true;
            // 
            // Airplane_ID
            // 
            this.Airplane_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Airplane_ID.Location = new System.Drawing.Point(974, 84);
            this.Airplane_ID.Name = "Airplane_ID";
            this.Airplane_ID.Size = new System.Drawing.Size(123, 24);
            this.Airplane_ID.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(991, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Airplane\'s ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1399, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Airplane\'s model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(980, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Count of spaces";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1181, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Airplane\'s crew";
            // 
            // Airplane_YearOfConstruction
            // 
            this.Airplane_YearOfConstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Airplane_YearOfConstruction.Location = new System.Drawing.Point(974, 242);
            this.Airplane_YearOfConstruction.Name = "Airplane_YearOfConstruction";
            this.Airplane_YearOfConstruction.Size = new System.Drawing.Size(123, 24);
            this.Airplane_YearOfConstruction.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(979, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 40);
            this.label6.TabIndex = 49;
            this.label6.Text = "Airplane\'s year \r\nof construction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1399, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 40);
            this.label4.TabIndex = 52;
            this.label4.Text = "Airplane\'s date\r\nof maintenance";
            // 
            // Airplane_LoadCarryingCapacity
            // 
            this.Airplane_LoadCarryingCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Airplane_LoadCarryingCapacity.Location = new System.Drawing.Point(1142, 242);
            this.Airplane_LoadCarryingCapacity.Name = "Airplane_LoadCarryingCapacity";
            this.Airplane_LoadCarryingCapacity.Size = new System.Drawing.Size(195, 24);
            this.Airplane_LoadCarryingCapacity.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1162, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 40);
            this.label8.TabIndex = 53;
            this.label8.Text = "      Airplane\'s load-\r\ncarrying capacity (kg)";
            // 
            // Crewman_FirstName
            // 
            this.Crewman_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Crewman_FirstName.Location = new System.Drawing.Point(15, 82);
            this.Crewman_FirstName.Name = "Crewman_FirstName";
            this.Crewman_FirstName.Size = new System.Drawing.Size(140, 24);
            this.Crewman_FirstName.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(44, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 56;
            this.label10.Text = "First name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(136, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Crewman";
            // 
            // Crewman_SecondName
            // 
            this.Crewman_SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Crewman_SecondName.Location = new System.Drawing.Point(185, 83);
            this.Crewman_SecondName.Name = "Crewman_SecondName";
            this.Crewman_SecondName.Size = new System.Drawing.Size(134, 24);
            this.Crewman_SecondName.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(195, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 18);
            this.label12.TabIndex = 59;
            this.label12.Text = "Second Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(57, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 18);
            this.label13.TabIndex = 61;
            this.label13.Text = "Position";
            // 
            // Crewman_Position
            // 
            this.Crewman_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Crewman_Position.FormattingEnabled = true;
            this.Crewman_Position.Location = new System.Drawing.Point(15, 148);
            this.Crewman_Position.Name = "Crewman_Position";
            this.Crewman_Position.Size = new System.Drawing.Size(140, 24);
            this.Crewman_Position.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(233, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 18);
            this.label14.TabIndex = 65;
            this.label14.Text = "Age";
            // 
            // Crewman_Age
            // 
            this.Crewman_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Crewman_Age.Location = new System.Drawing.Point(185, 150);
            this.Crewman_Age.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Crewman_Age.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Crewman_Age.Name = "Crewman_Age";
            this.Crewman_Age.Size = new System.Drawing.Size(134, 24);
            this.Crewman_Age.TabIndex = 64;
            this.Crewman_Age.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(15, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 20);
            this.label15.TabIndex = 66;
            this.label15.Text = "Experience (years)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(230, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 20);
            this.label16.TabIndex = 68;
            this.label16.Text = "Sex";
            // 
            // Airplane_Add
            // 
            this.Airplane_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Airplane_Add.Location = new System.Drawing.Point(974, 334);
            this.Airplane_Add.Name = "Airplane_Add";
            this.Airplane_Add.Size = new System.Drawing.Size(134, 53);
            this.Airplane_Add.TabIndex = 69;
            this.Airplane_Add.Text = "Add to list of airplanes";
            this.Airplane_Add.UseVisualStyleBackColor = true;
            this.Airplane_Add.Click += new System.EventHandler(this.Airplane_Add_Click);
            // 
            // Crewman_Experience
            // 
            this.Crewman_Experience.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Crewman_Experience.Location = new System.Drawing.Point(15, 217);
            this.Crewman_Experience.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Crewman_Experience.Name = "Crewman_Experience";
            this.Crewman_Experience.Size = new System.Drawing.Size(140, 24);
            this.Crewman_Experience.TabIndex = 70;
            // 
            // Airplane_Crew
            // 
            this.Airplane_Crew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Airplane_Crew.FormattingEnabled = true;
            this.Airplane_Crew.Location = new System.Drawing.Point(1142, 151);
            this.Airplane_Crew.Name = "Airplane_Crew";
            this.Airplane_Crew.Size = new System.Drawing.Size(195, 42);
            this.Airplane_Crew.TabIndex = 71;
            // 
            // Company_Name
            // 
            this.Company_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Company_Name.Location = new System.Drawing.Point(445, 83);
            this.Company_Name.Name = "Company_Name";
            this.Company_Name.Size = new System.Drawing.Size(123, 24);
            this.Company_Name.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(450, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 72;
            this.label5.Text = "Company name";
            // 
            // Company_Country
            // 
            this.Company_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Company_Country.Location = new System.Drawing.Point(603, 83);
            this.Company_Country.Name = "Company_Country";
            this.Company_Country.Size = new System.Drawing.Size(123, 24);
            this.Company_Country.TabIndex = 75;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(631, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 18);
            this.label17.TabIndex = 74;
            this.label17.Text = "Country";
            // 
            // Company_Year
            // 
            this.Company_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Company_Year.Location = new System.Drawing.Point(765, 83);
            this.Company_Year.Name = "Company_Year";
            this.Company_Year.Size = new System.Drawing.Size(123, 24);
            this.Company_Year.TabIndex = 77;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(764, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 18);
            this.label18.TabIndex = 76;
            this.label18.Text = "Year of foundation";
            // 
            // Company_Type_Cargo
            // 
            this.Company_Type_Cargo.AutoSize = true;
            this.Company_Type_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Company_Type_Cargo.Location = new System.Drawing.Point(598, 151);
            this.Company_Type_Cargo.Name = "Company_Type_Cargo";
            this.Company_Type_Cargo.Size = new System.Drawing.Size(65, 22);
            this.Company_Type_Cargo.TabIndex = 78;
            this.Company_Type_Cargo.Text = "cargo";
            this.Company_Type_Cargo.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(442, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 36);
            this.label19.TabIndex = 79;
            this.label19.Text = "         Types of\r\nproduced airplanes:";
            // 
            // Company_Type_Passenger
            // 
            this.Company_Type_Passenger.AutoSize = true;
            this.Company_Type_Passenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Company_Type_Passenger.Location = new System.Drawing.Point(688, 151);
            this.Company_Type_Passenger.Name = "Company_Type_Passenger";
            this.Company_Type_Passenger.Size = new System.Drawing.Size(96, 22);
            this.Company_Type_Passenger.TabIndex = 80;
            this.Company_Type_Passenger.Text = "passenger";
            this.Company_Type_Passenger.UseVisualStyleBackColor = true;
            // 
            // Company_Type_Military
            // 
            this.Company_Type_Military.AutoSize = true;
            this.Company_Type_Military.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Company_Type_Military.Location = new System.Drawing.Point(815, 151);
            this.Company_Type_Military.Name = "Company_Type_Military";
            this.Company_Type_Military.Size = new System.Drawing.Size(73, 22);
            this.Company_Type_Military.TabIndex = 81;
            this.Company_Type_Military.Text = "military";
            this.Company_Type_Military.UseVisualStyleBackColor = true;
            // 
            // Company_Add
            // 
            this.Company_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Company_Add.Location = new System.Drawing.Point(523, 199);
            this.Company_Add.Name = "Company_Add";
            this.Company_Add.Size = new System.Drawing.Size(123, 53);
            this.Company_Add.TabIndex = 82;
            this.Company_Add.Text = "Add to list of companies";
            this.Company_Add.UseVisualStyleBackColor = true;
            this.Company_Add.Click += new System.EventHandler(this.Company_Add_Click);
            // 
            // Company_List
            // 
            this.Company_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Company_List.FormattingEnabled = true;
            this.Company_List.ItemHeight = 18;
            this.Company_List.Location = new System.Drawing.Point(453, 293);
            this.Company_List.Name = "Company_List";
            this.Company_List.Size = new System.Drawing.Size(435, 94);
            this.Company_List.TabIndex = 83;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(602, 272);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 18);
            this.label20.TabIndex = 84;
            this.label20.Text = "List of companies";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(997, 404);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 18);
            this.label21.TabIndex = 85;
            this.label21.Text = "List of airplanes";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // Airplane_Model
            // 
            this.Airplane_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Airplane_Model.FormattingEnabled = true;
            this.Airplane_Model.Location = new System.Drawing.Point(1379, 81);
            this.Airplane_Model.Name = "Airplane_Model";
            this.Airplane_Model.Size = new System.Drawing.Size(164, 26);
            this.Airplane_Model.TabIndex = 86;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(622, 36);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 20);
            this.label22.TabIndex = 87;
            this.label22.Text = "Company";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(1204, 36);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 20);
            this.label23.TabIndex = 88;
            this.label23.Text = "Airplane";
            // 
            // Crewman_List
            // 
            this.Crewman_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Crewman_List.FormattingEnabled = true;
            this.Crewman_List.ItemHeight = 18;
            this.Crewman_List.Location = new System.Drawing.Point(15, 366);
            this.Crewman_List.Name = "Crewman_List";
            this.Crewman_List.Size = new System.Drawing.Size(330, 94);
            this.Crewman_List.TabIndex = 89;
            this.Crewman_List.SelectedIndexChanged += new System.EventHandler(this.Crewman_List_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(104, 345);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 18);
            this.label24.TabIndex = 90;
            this.label24.Text = "List of crewmans";
            // 
            // Crewman_Clear
            // 
            this.Crewman_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Crewman_Clear.Location = new System.Drawing.Point(244, 282);
            this.Crewman_Clear.Name = "Crewman_Clear";
            this.Crewman_Clear.Size = new System.Drawing.Size(86, 32);
            this.Crewman_Clear.TabIndex = 91;
            this.Crewman_Clear.Text = "Clear";
            this.Crewman_Clear.UseVisualStyleBackColor = true;
            this.Crewman_Clear.Click += new System.EventHandler(this.Crewman_Clear_Click);
            // 
            // Company_Clear
            // 
            this.Company_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Company_Clear.Location = new System.Drawing.Point(698, 209);
            this.Company_Clear.Name = "Company_Clear";
            this.Company_Clear.Size = new System.Drawing.Size(86, 32);
            this.Company_Clear.TabIndex = 92;
            this.Company_Clear.Text = "Clear";
            this.Company_Clear.UseVisualStyleBackColor = true;
            this.Company_Clear.Click += new System.EventHandler(this.Company_Clear_Click);
            // 
            // Airplane_Clear
            // 
            this.Airplane_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Airplane_Clear.Location = new System.Drawing.Point(1185, 345);
            this.Airplane_Clear.Name = "Airplane_Clear";
            this.Airplane_Clear.Size = new System.Drawing.Size(86, 32);
            this.Airplane_Clear.TabIndex = 93;
            this.Airplane_Clear.Text = "Clear";
            this.Airplane_Clear.UseVisualStyleBackColor = true;
            this.Airplane_Clear.Click += new System.EventHandler(this.Airplane_Clear_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(843, 552);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(86, 32);
            this.Save.TabIndex = 94;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Read
            // 
            this.Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Read.Location = new System.Drawing.Point(1185, 552);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(86, 32);
            this.Read.TabIndex = 95;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Open_Dialog
            // 
            this.Open_Dialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 607);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Airplane_Clear);
            this.Controls.Add(this.Company_Clear);
            this.Controls.Add(this.Crewman_Clear);
            this.Controls.Add(this.Crewman_List);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Airplane_Model);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Company_List);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Company_Add);
            this.Controls.Add(this.Company_Type_Military);
            this.Controls.Add(this.Company_Type_Passenger);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Company_Type_Cargo);
            this.Controls.Add(this.Company_Year);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Company_Country);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Company_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Airplane_Crew);
            this.Controls.Add(this.Crewman_Experience);
            this.Controls.Add(this.Airplane_Add);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Crewman_Age);
            this.Controls.Add(this.Crewman_Position);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Crewman_SecondName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Crewman_FirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Airplane_LoadCarryingCapacity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Airplane_YearOfConstruction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Airplane_List);
            this.Controls.Add(this.Crewman_Add);
            this.Controls.Add(this.Airplane_Space);
            this.Controls.Add(this.Airplane_Type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Airplane_DateOfMaintenance);
            this.Controls.Add(this.Crewman_Sex_Female);
            this.Controls.Add(this.Crewman_Sex_Male);
            this.Controls.Add(this.Airplane_ID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Airplane_Space)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crewman_Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crewman_Experience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Airplane_List;
        private System.Windows.Forms.Button Crewman_Add;
        private System.Windows.Forms.NumericUpDown Airplane_Space;
        private System.Windows.Forms.ComboBox Airplane_Type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar Airplane_DateOfMaintenance;
        private System.Windows.Forms.RadioButton Crewman_Sex_Female;
        private System.Windows.Forms.RadioButton Crewman_Sex_Male;
        private System.Windows.Forms.TextBox Airplane_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Airplane_YearOfConstruction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Airplane_LoadCarryingCapacity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Crewman_FirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Crewman_SecondName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Crewman_Position;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown Crewman_Age;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Airplane_Add;
        private System.Windows.Forms.NumericUpDown Crewman_Experience;
        private System.Windows.Forms.CheckedListBox Airplane_Crew;
        private System.Windows.Forms.TextBox Company_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Company_Country;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Company_Year;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox Company_Type_Cargo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox Company_Type_Passenger;
        private System.Windows.Forms.CheckBox Company_Type_Military;
        private System.Windows.Forms.Button Company_Add;
        private System.Windows.Forms.ListBox Company_List;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox Airplane_Model;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListBox Crewman_List;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button Crewman_Clear;
        private System.Windows.Forms.Button Company_Clear;
        private System.Windows.Forms.Button Airplane_Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.SaveFileDialog Save_Dialog;
        private System.Windows.Forms.OpenFileDialog Open_Dialog;
    }
}

