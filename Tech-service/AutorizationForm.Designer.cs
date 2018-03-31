namespace Tech_service
{
    partial class AutorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizationForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.EntrBttn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.AutorizationBS = new System.Windows.Forms.BindingSource(this.components);
            this.techDS = new Tech_service.TechDS();
            this.autorizationTableTableAdapter = new Tech_service.TechDSTableAdapters.AutorizationTableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutorizationBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.EntrBttn);
            this.groupBox1.Controls.Add(this.ExitBtn);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Controls.Add(this.LoginTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(62, 201);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Не могу войти!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // EntrBttn
            // 
            this.EntrBttn.Image = ((System.Drawing.Image)(resources.GetObject("EntrBttn.Image")));
            this.EntrBttn.Location = new System.Drawing.Point(118, 153);
            this.EntrBttn.Name = "EntrBttn";
            this.EntrBttn.Size = new System.Drawing.Size(98, 31);
            this.EntrBttn.TabIndex = 3;
            this.EntrBttn.UseVisualStyleBackColor = true;
            this.EntrBttn.Click += new System.EventHandler(this.EntrBttn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(9, 153);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(101, 31);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.PasswordTextBox.Location = new System.Drawing.Point(9, 114);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(207, 33);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Text = "пароль";
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.LoginTextBox.Location = new System.Drawing.Point(9, 64);
            this.LoginTextBox.Multiline = true;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(207, 33);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.Text = "идентификатор";
            this.LoginTextBox.Click += new System.EventHandler(this.LoginTextBox_Click);
            this.LoginTextBox.Leave += new System.EventHandler(this.LoginTextBox_Leave);
            // 
            // AutorizationBS
            // 
            this.AutorizationBS.DataMember = "AutorizationTable";
            this.AutorizationBS.DataSource = this.techDS;
            // 
            // techDS
            // 
            this.techDS.DataSetName = "TechDS";
            this.techDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autorizationTableTableAdapter
            // 
            this.autorizationTableTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Авторизация";
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 263);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutorizationForm";
            this.Load += new System.EventHandler(this.AutorizationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutorizationBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button EntrBttn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.BindingSource AutorizationBS;
        private TechDS techDS;
        private TechDSTableAdapters.AutorizationTableTableAdapter autorizationTableTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}