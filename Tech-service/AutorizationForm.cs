using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech_service
{
    public partial class AutorizationForm : Form
    {
        private int password;
        Form1 mainOwner;
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Указать свой E-mail как контактный!
            MessageBox.Show("Свяжитесь с администратором! E-Mail: example@mail.ru");
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            this.autorizationTableTableAdapter.Fill(this.techDS.AutorizationTable);
            mainOwner = this.Owner as Form1;
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntrBttn_Click(object sender, EventArgs e)
        {
            mainOwner = this.Owner as Form1;
            password = Convert.ToInt32(this.autorizationTableTableAdapter.GetHashPass(LoginTextBox.Text));
            if (password == Convert.ToInt32(PasswordTextBox.Text.GetHashCode()))
            {

                mainOwner.CommentLable.Text = this.autorizationTableTableAdapter.GetComment(LoginTextBox.Text);
                mainOwner.autorizationFlag = true;
                this.Close();
            }
            else { MessageBox.Show("Идентификатор/Пароль неверны!"); }
            
        }

        private void LoginTextBox_Click(object sender, EventArgs e)
        {
            LoginTextBox.Text = null;
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = null;
        }

        private void LoginTextBox_Leave(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == null)
            {
                LoginTextBox.Text = "Идентификатор";
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == null)
            {
                PasswordTextBox.Text = "Пароль";
            }
        }
    }
}
