namespace Tech_service
{
    partial class AddClientsForm
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
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label data_RozdeniyaLabel;
            System.Windows.Forms.Label telefon1Label;
            System.Windows.Forms.Label telefon2Label;
            System.Windows.Forms.Label polLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClientsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.clientyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techDS = new Tech_service.TechDS();
            this.data_RozdeniyaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telefon1TextBox = new System.Windows.Forms.TextBox();
            this.telefon2TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clientyTableAdapter = new Tech_service.TechDSTableAdapters.ClientyTableAdapter();
            this.tableAdapterManager = new Tech_service.TechDSTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            fIOLabel = new System.Windows.Forms.Label();
            data_RozdeniyaLabel = new System.Windows.Forms.Label();
            telefon1Label = new System.Windows.Forms.Label();
            telefon2Label = new System.Windows.Forms.Label();
            polLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techDS)).BeginInit();
            this.SuspendLayout();
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(8, 20);
            fIOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(46, 17);
            fIOLabel.TabIndex = 2;
            fIOLabel.Text = "ФИО:";
            // 
            // data_RozdeniyaLabel
            // 
            data_RozdeniyaLabel.AutoSize = true;
            data_RozdeniyaLabel.Location = new System.Drawing.Point(8, 72);
            data_RozdeniyaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_RozdeniyaLabel.Name = "data_RozdeniyaLabel";
            data_RozdeniyaLabel.Size = new System.Drawing.Size(115, 17);
            data_RozdeniyaLabel.TabIndex = 4;
            data_RozdeniyaLabel.Text = "Дата рождения:";
            // 
            // telefon1Label
            // 
            telefon1Label.AutoSize = true;
            telefon1Label.Location = new System.Drawing.Point(8, 150);
            telefon1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefon1Label.Name = "telefon1Label";
            telefon1Label.Size = new System.Drawing.Size(94, 17);
            telefon1Label.TabIndex = 6;
            telefon1Label.Text = "Телефон №1";
            // 
            // telefon2Label
            // 
            telefon2Label.AutoSize = true;
            telefon2Label.Location = new System.Drawing.Point(8, 201);
            telefon2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefon2Label.Name = "telefon2Label";
            telefon2Label.Size = new System.Drawing.Size(94, 17);
            telefon2Label.TabIndex = 8;
            telefon2Label.Text = "Телефон №2";
            // 
            // polLabel
            // 
            polLabel.AutoSize = true;
            polLabel.Location = new System.Drawing.Point(8, 288);
            polLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            polLabel.Name = "polLabel";
            polLabel.Size = new System.Drawing.Size(34, 17);
            polLabel.TabIndex = 10;
            polLabel.Text = "Пол";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(fIOLabel);
            this.groupBox1.Controls.Add(this.fIOTextBox);
            this.groupBox1.Controls.Add(data_RozdeniyaLabel);
            this.groupBox1.Controls.Add(this.data_RozdeniyaDateTimePicker);
            this.groupBox1.Controls.Add(telefon1Label);
            this.groupBox1.Controls.Add(this.telefon1TextBox);
            this.groupBox1.Controls.Add(telefon2Label);
            this.groupBox1.Controls.Add(this.telefon2TextBox);
            this.groupBox1.Controls.Add(polLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(331, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.comboBox1.Location = new System.Drawing.Point(8, 309);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 25);
            this.comboBox1.TabIndex = 11;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientyBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(8, 42);
            this.fIOTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fIOTextBox.Multiline = true;
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(265, 25);
            this.fIOTextBox.TabIndex = 3;
            // 
            // clientyBindingSource
            // 
            this.clientyBindingSource.DataMember = "Clienty";
            this.clientyBindingSource.DataSource = this.techDS;
            // 
            // techDS
            // 
            this.techDS.DataSetName = "TechDS";
            this.techDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_RozdeniyaDateTimePicker
            // 
            this.data_RozdeniyaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientyBindingSource, "Data_Rozdeniya", true));
            this.data_RozdeniyaDateTimePicker.Location = new System.Drawing.Point(8, 93);
            this.data_RozdeniyaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data_RozdeniyaDateTimePicker.Name = "data_RozdeniyaDateTimePicker";
            this.data_RozdeniyaDateTimePicker.Size = new System.Drawing.Size(265, 23);
            this.data_RozdeniyaDateTimePicker.TabIndex = 5;
            // 
            // telefon1TextBox
            // 
            this.telefon1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientyBindingSource, "Telefon1", true));
            this.telefon1TextBox.Location = new System.Drawing.Point(8, 171);
            this.telefon1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telefon1TextBox.Name = "telefon1TextBox";
            this.telefon1TextBox.Size = new System.Drawing.Size(265, 23);
            this.telefon1TextBox.TabIndex = 7;
            // 
            // telefon2TextBox
            // 
            this.telefon2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientyBindingSource, "Telefon2", true));
            this.telefon2TextBox.Location = new System.Drawing.Point(8, 222);
            this.telefon2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telefon2TextBox.Multiline = true;
            this.telefon2TextBox.Name = "telefon2TextBox";
            this.telefon2TextBox.Size = new System.Drawing.Size(265, 29);
            this.telefon2TextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(223, 367);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 46);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientyTableAdapter
            // 
            this.clientyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutorizationTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientyTableAdapter = this.clientyTableAdapter;
            this.tableAdapterManager.RabotaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tech_service.TechDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_RabTableAdapter = null;
            this.tableAdapterManager.ZakazTableAdapter = null;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(16, 367);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 46);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 438);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClientsForm";
            this.Text = "Добавить клиента";
            this.Load += new System.EventHandler(this.AddClientsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private TechDS techDS;
        private System.Windows.Forms.BindingSource clientyBindingSource;
        private TechDSTableAdapters.ClientyTableAdapter clientyTableAdapter;
        private TechDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.DateTimePicker data_RozdeniyaDateTimePicker;
        private System.Windows.Forms.TextBox telefon1TextBox;
        private System.Windows.Forms.TextBox telefon2TextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}