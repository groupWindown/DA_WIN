using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_NhanSu
{
    public partial class from_TT_NhanVien : Form
    {
        public from_TT_NhanVien()
        {
            InitializeComponent();
        }

        private void from_TT_NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetQLNS.DataTable1' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'dataSetQLNS.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.dataSetQLNS.PHONGBAN);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pHONGBANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHONGBANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetQLNS);

        }
    }
}
