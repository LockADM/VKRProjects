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
    public partial class RegistrUserForm : Form
    {
        public RegistrUserForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrUserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "techDS.AutorizationTable". При необходимости она может быть перемещена или удалена.
            this.autorizationTableTableAdapter.Fill(this.techDS.AutorizationTable);

        }

        private void EntrBttn_Click(object sender, EventArgs e)
        {
            try
            {
                this.autorizationTableTableAdapter.Insert(LoginTextBox.Text, Convert.ToInt32(PasswordTextBox.Text.GetHashCode()), CommentaryTextBox.Text);
                this.Validate();
                this.bindingSource1.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.techDS);
            }
            catch (Exception) { MessageBox.Show("Пользоватль с такими данными уже зарегестрирован!"); }
        }
    }
}
