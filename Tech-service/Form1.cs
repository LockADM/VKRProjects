using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Tech_service
{
    public partial class Form1 : Form
    {
        // <Поля "Основной формы">
        ClientForm ClientForm;
        AutorizationForm ATForm;
        public bool autorizationFlag = false;
        PriceListForm PSForm;
        RegistrUserForm RegForm;
        double coast = 0;
        public string comment;
        // </Поля "Основной формы">
        public Form1()
        {
            InitializeComponent();
            VersionLable.Text = "Alfa Build v.0.1";
        }
        //Обработчик Ошибки связанной с нарушением отношения внутри БД (Одинаковый ключ)
        private void ZakazDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)

        {
            if (e.Exception != null &&
                e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Уникальные поля должны быть заполнены!");
            }
        }
        private void RDVGError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Данный вид работы уже выбран в данном заказе!");
            }
        }
        //Обработчка события "Загрузка основной формы"
        private void Form1_Load(object sender, EventArgs e)
        {
            ATForm = new AutorizationForm();
            ATForm.Owner = this;
            ATForm.ShowDialog();
            //Блок проверки флага авторизации
            if (autorizationFlag == true)
            {
                // <Строки Заполнения виртуальных таблиц данными>
                this.ZakazDGV.DataError +=
                            new DataGridViewDataErrorEventHandler(ZakazDGV_DataError);
                this.vid_RabTableAdapter.Fill(this.techDS.Vid_Rab);
                this.clientyTableAdapter.Fill(this.techDS.Clienty);
                this.rabotaTableAdapter.Fill(this.techDS.Rabota);
                this.zakazTableAdapter.Fill(this.techDS.Zakaz);
                zakazBindingNavigator.Enabled = true;
                ZakazDGV.Enabled = true;
                CostButton.Enabled = true;
                входToolStripMenuItem.Enabled = false;
                // </Строки Заполнения виртуальных таблиц данными>
            }
        }
        // Таймер для получения актуального времени
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CommentLable.Text == "LockADM")
            {
                регистрацияToolStripMenuItem.Enabled = true;
            }
            TimeLable.Text = DateTime.Now.ToString();
        }
        // Кнопка обновления данных
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
                this.clientyTableAdapter.Fill(this.techDS.Clienty);
                this.vid_RabTableAdapter.Fill(this.techDS.Vid_Rab);
                this.zakazTableAdapter.Fill(this.techDS.Zakaz);
                zakazBindingSource.Filter = null;
            
        }
        // Кнопка добавления нового клиента
        private void AddNewClientButton_Click(object sender, EventArgs e)
        {
                ClientForm = new ClientForm();
                ClientForm.ShowDialog();
        }
        // Кнопка открытия прейскуранта
        private void button1_Click(object sender, EventArgs e)
        {
            PSForm = new PriceListForm();
            PSForm.ShowDialog();
        }
        // Блок поиска по № Заказа
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                zakazBindingSource.Filter = "ID_Zakaza = '" + Convert.ToInt32(IDZakazaSearchTextBox.Text) + "'";
            }
            catch (FormatException) { IDZakazaSearchTextBox.Text = null; }
        }
        // Блок фильтра по датам
        private void DataSearchZakazButton_Click(object sender, EventArgs e)
        {

            string _maxDate = Convert.ToDateTime(DTP1.Value).ToString("MM.dd.yyyy"); // Перевод местной даты в интернациональный формат
            string _minDate = Convert.ToDateTime(DTP2.Value).ToString("MM.dd.yyyy"); //
            zakazBindingSource.Filter = " Data_Zakaza >= #" + _maxDate + "# AND Data_Zakaza <= #" + _minDate + "#"; // Фильтр для DateTime использует #, а не '
        }
        // Блок фильтра по статусу выполнения (Выполненные)
        private void button2_Click(object sender, EventArgs e)
        {
                zakazBindingSource.Filter = "Status = '" + true + "'";
        }
        // Блок фильтра по статусу выполнения (Невыполненные)
        private void SearchButtonBool2_Click(object sender, EventArgs e)
        {
            zakazBindingSource.Filter = "Status = '" + false + "'";
        }
        // Подсчет итоговой суммы исходя из работ в заказе
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            for (int _item = 0; _item < rabotaDataGridView.RowCount - 1; _item++)
            {
                coast = coast + Convert.ToDouble( this.vid_RabTableAdapter.ReturnCena(rabotaDataGridView.Rows[_item].Cells[1].Value.ToString()));
            }
            textBox1.Text = coast.ToString();
            CostButton.Enabled = false;
            CompBttn.Enabled = true;
            
        }
        // Завершения и создание новой записи в таблице заказа
        private void CompBttn_Click(object sender, EventArgs e)
        {
            try
            {
                ZakazDGV.CurrentRow.Cells[2].Value = DateTime.Now.ToShortDateString();
                ZakazDGV.CurrentRow.Cells[3].Value = coast;
                this.Validate();
                this.zakazBindingSource.EndEdit();
                this.rabotaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.techDS);
                CostButton.Enabled = true;
                CompBttn.Enabled = false;
                textBox1.Text = null;
                coast = 0;
            }

            catch (Exception)
            {
                MessageBox.Show("Не выбран клиент!");
            }
            
        }
        // Пункт меню (Регистрация). Открывает новую форму для регистрации ( Доступна только для Админа)
        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegForm = new RegistrUserForm();
            RegForm.ShowDialog();
        }
        // Пункт меню (Вход). Открывает новую форму для прохождения авторизации (Без авторизации данные из базы в программу не загружаются)
        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATForm = new AutorizationForm();
            ATForm.Owner = this;
            ATForm.ShowDialog();
        }
        // Обработчик активации фокуса на форме, необходим что бы отловить изменения флага авторизации и в случае успеха загрузить данные из БД в программу
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (autorizationFlag == true)
            {
                this.rabotaDataGridView.DataError += new DataGridViewDataErrorEventHandler(RDVGError);
                this.ZakazDGV.DataError +=
                            new DataGridViewDataErrorEventHandler(ZakazDGV_DataError);
                this.vid_RabTableAdapter.Fill(this.techDS.Vid_Rab);
                this.clientyTableAdapter.Fill(this.techDS.Clienty);
                this.rabotaTableAdapter.Fill(this.techDS.Rabota);
                this.zakazTableAdapter.Fill(this.techDS.Zakaz);
                zakazBindingNavigator.Enabled = true;
                ZakazDGV.Enabled = true;
                CostButton.Enabled = true;
            }
            
        }
        // Обработчик позволяет Админу разблокировать кнопку Регистрации новых пользователей
        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void DGVprint(DataGridView dvg, string dgvname)
        {
            DGVPrinter pr = new DGVPrinter();
            pr.Title = dgvname;
            pr.SubTitle = string.Format("Дата: {0}", System.DateTime.Now);
            pr.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            pr.PageNumbers = true;
            pr.PageNumberInHeader = false;
            pr.PorportionalColumns = true;
            pr.HeaderCellAlignment = StringAlignment.Near;
            pr.Footer = "Списки заказов";
            pr.FooterSpacing = 10;
            pr.PrintDataGridView(dvg);
        }
        private void спискиЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGVprint(ZakazDGV, "Списки заказов");
        }

        private void таблицаExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Cells[1, 1].Value = "Номер заказа";
            ExcelWorkSheet.Cells[1, 2].Value = "Клиент";
            ExcelWorkSheet.Cells[1, 3].Value = "Дата заказа";
            ExcelWorkSheet.Cells[1, 4].Value = "Итоговая сумма";
            ExcelWorkSheet.Cells[1, 5].Value = "Статус выполнения";
            for (int i = 0; i < ZakazDGV.Rows.Count; i++)
            {
                for (int j = 0; j < ZakazDGV.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = ZakazDGV.Rows[i].Cells[j].Value;   

                }
                string name = this.clientyTableAdapter.GetFIOFromID(Convert.ToInt32(ZakazDGV.Rows[i].Cells[1].Value));
                ExcelWorkSheet.Cells[i + 2, 2].Value = name;
            }
            
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void StatusBttn_Click(object sender, EventArgs e)
        {
            ZakazDGV.CurrentRow.Cells[4].Value = true;
            zakazBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(techDS);
        }
    }
}
