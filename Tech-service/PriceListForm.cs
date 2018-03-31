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
    public partial class PriceListForm : Form
    {
        public PriceListForm()
        {
            InitializeComponent();
        }
        private void VidRabotyError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                vid_RabDataGridView.CurrentRow.Cells[1].Value = 0;

            }
        }
        private void vid_RabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vid_RabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.techDS);

        }

        private void PriceListForm_Load(object sender, EventArgs e)
        {
            this.vid_RabTableAdapter.Fill(this.techDS.Vid_Rab);
            this.vid_RabDataGridView.DataError += new DataGridViewDataErrorEventHandler(VidRabotyError);
        }

        private void PriceListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
