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
    public partial class AddClientsForm : Form
    {
        public AddClientsForm()
        {
            InitializeComponent();
        }
        int countOfClients = 0;

        private void clientyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.techDS);

        }

        private void AddClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "techDS.Clienty". При необходимости она может быть перемещена или удалена.
            this.clientyTableAdapter.Fill(this.techDS.Clienty);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            countOfClients = Convert.ToInt32(this.clientyTableAdapter.ScalarQuery());
            this.clientyTableAdapter.Insert(countOfClients + 1, fIOTextBox.Text, data_RozdeniyaDateTimePicker.Value.Date, telefon1TextBox.Text, telefon2TextBox.Text, comboBox1.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.techDS);
            this.Close();
        }
    }
}
