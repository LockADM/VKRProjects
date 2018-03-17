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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void clientyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientyBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.techDS);
            }
            catch (Exception) { MessageBox.Show("Необходимо заполнить все обязательные поля!"); }

        }
        private void clientyDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)

        {
            if (e.Exception != null &&
                e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Уникальные поля должны быть заполнены!");
            }
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {
            this.clientyDataGridView.DataError +=
       new DataGridViewDataErrorEventHandler(clientyDataGridView_DataError);
            this.clientyTableAdapter.Fill(this.techDS.Clienty);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clientyBindingSource.Filter = "FIO = '" + textBox1.Text + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _maxDate = Convert.ToDateTime(DTP1.Value).ToString("MM.dd.yyyy"); // Перевод местной даты в интернациональный формат
            string _minDate = Convert.ToDateTime(DTP2.Value).ToString("MM.dd.yyyy"); //
            clientyBindingSource.Filter = " Data_Rozdeniya >= #" + _maxDate + "# AND Data_Rozdeniya <= #" + _minDate + "#"; // Фильтр для DateTime использует #, а не '
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.clientyTableAdapter.Fill(this.techDS.Clienty);
            clientyBindingSource.Filter = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientyBindingSource.Filter = "POL = 'М'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientyBindingSource.Filter = "POL = 'Ж'";
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Cells[1, 1].Value = "Номер Клиента";
            ExcelWorkSheet.Cells[1, 2].Value = "ФИО";
            ExcelWorkSheet.Cells[1, 3].Value = "Дата рождения";
            ExcelWorkSheet.Cells[1, 4].Value = "Телефон 1";
            ExcelWorkSheet.Cells[1, 5].Value = "Телефон 2";
            ExcelWorkSheet.Cells[1, 6].Value = "Пол";
            for (int i = 0; i < clientyDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < clientyDataGridView.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = clientyDataGridView.Rows[i].Cells[j].Value;

                }
            }

            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
