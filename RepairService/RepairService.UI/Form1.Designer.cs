namespace RepairService.UI
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
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonSmartphone = new System.Windows.Forms.RadioButton();
            this.ButtonTablet = new System.Windows.Forms.RadioButton();
            this.ButtonLaptop = new System.Windows.Forms.RadioButton();
            this.ButtonPC = new System.Windows.Forms.RadioButton();
            this.ListOfFaults = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.PriceBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.CustomFormat = "dd.MM.yyyy   hh:mm";
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.Location = new System.Drawing.Point(438, 26);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(128, 20);
            this.Date.TabIndex = 0;
            this.Date.Value = new System.DateTime(2018, 4, 14, 22, 10, 16, 0);
            // 
            // CustomerName
            // 
            this.CustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerName.Location = new System.Drawing.Point(15, 29);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(339, 20);
            this.CustomerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата";
            // 
            // ModelName
            // 
            this.ModelName.Location = new System.Drawing.Point(15, 117);
            this.ModelName.Name = "ModelName";
            this.ModelName.Size = new System.Drawing.Size(410, 20);
            this.ModelName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Модель";
            // 
            // ButtonSmartphone
            // 
            this.ButtonSmartphone.AutoSize = true;
            this.ButtonSmartphone.Location = new System.Drawing.Point(6, 14);
            this.ButtonSmartphone.Name = "ButtonSmartphone";
            this.ButtonSmartphone.Size = new System.Drawing.Size(77, 17);
            this.ButtonSmartphone.TabIndex = 6;
            this.ButtonSmartphone.TabStop = true;
            this.ButtonSmartphone.Text = "Смартфон";
            this.ButtonSmartphone.UseVisualStyleBackColor = true;
            this.ButtonSmartphone.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // ButtonTablet
            // 
            this.ButtonTablet.AutoSize = true;
            this.ButtonTablet.Location = new System.Drawing.Point(89, 14);
            this.ButtonTablet.Name = "ButtonTablet";
            this.ButtonTablet.Size = new System.Drawing.Size(70, 17);
            this.ButtonTablet.TabIndex = 7;
            this.ButtonTablet.TabStop = true;
            this.ButtonTablet.Text = "Планшет";
            this.ButtonTablet.UseVisualStyleBackColor = true;
            this.ButtonTablet.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // ButtonLaptop
            // 
            this.ButtonLaptop.AutoSize = true;
            this.ButtonLaptop.Location = new System.Drawing.Point(165, 14);
            this.ButtonLaptop.Name = "ButtonLaptop";
            this.ButtonLaptop.Size = new System.Drawing.Size(66, 17);
            this.ButtonLaptop.TabIndex = 8;
            this.ButtonLaptop.TabStop = true;
            this.ButtonLaptop.Text = "Ноутбук";
            this.ButtonLaptop.UseVisualStyleBackColor = true;
            this.ButtonLaptop.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // ButtonPC
            // 
            this.ButtonPC.AutoSize = true;
            this.ButtonPC.Location = new System.Drawing.Point(237, 14);
            this.ButtonPC.Name = "ButtonPC";
            this.ButtonPC.Size = new System.Drawing.Size(40, 17);
            this.ButtonPC.TabIndex = 9;
            this.ButtonPC.TabStop = true;
            this.ButtonPC.Text = "ПК";
            this.ButtonPC.UseVisualStyleBackColor = true;
            this.ButtonPC.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // ListOfFaults
            // 
            this.ListOfFaults.FormattingEnabled = true;
            this.ListOfFaults.Location = new System.Drawing.Point(15, 162);
            this.ListOfFaults.Name = "ListOfFaults";
            this.ListOfFaults.Size = new System.Drawing.Size(551, 134);
            this.ListOfFaults.TabIndex = 10;
            this.ListOfFaults.SelectedIndexChanged += new System.EventHandler(this.ListOfFaults_SelectedIndexChanged_1);
            this.ListOfFaults.DoubleClick += new System.EventHandler(this.ListOfFaults_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Неисправности";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(23, 302);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 12;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Location = new System.Drawing.Point(104, 302);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 13;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(410, 371);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 14;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(491, 371);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpen.TabIndex = 15;
            this.ButtonOpen.Text = "Открыть";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click_1);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(15, 370);
            this.PriceBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(120, 20);
            this.PriceBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Итог";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.ButtonPC);
            this.GroupBox.Controls.Add(this.ButtonLaptop);
            this.GroupBox.Controls.Add(this.ButtonTablet);
            this.GroupBox.Controls.Add(this.ButtonSmartphone);
            this.GroupBox.Location = new System.Drawing.Point(15, 55);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(281, 37);
            this.GroupBox.TabIndex = 18;
            this.GroupBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "руб.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 402);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListOfFaults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.Date);
            this.Name = "Form1";
            this.Text = "Ремонтный сервис";
            ((System.ComponentModel.ISupportInitialize)(this.PriceBox)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.Form1_Load);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton ButtonSmartphone;
        private System.Windows.Forms.RadioButton ButtonTablet;
        private System.Windows.Forms.RadioButton ButtonLaptop;
        private System.Windows.Forms.RadioButton ButtonPC;
        private System.Windows.Forms.ListBox ListOfFaults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.NumericUpDown PriceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label label6;
    }
}

