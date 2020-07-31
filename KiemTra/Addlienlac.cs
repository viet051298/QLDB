using KiemTra.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra
{
   
    public partial class Addlienlac : Form
    {
        string path1 = @"D:\dot net\KiemTra\KiemTra\DATA\lienlac.txt";
        string maNhom;
        private Form1 form;
        public Addlienlac(Form1 form, string maNhom)
        {
            InitializeComponent();
            this.maNhom = maNhom;
            this.form = form;
            txtma.Text = maNhom;
        }

        private void Addlienlac_Load(object sender, EventArgs e)
        {

        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text;
            string email = txtema.Text;
            string sdt = txtso.Text;
            if (ten != null)
            {
                LienLac.add(maNhom, ten, email, sdt, path1);
                MessageBox.Show("Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void Btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addlienlac_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form.refreshDtgvLienLac();
        }
    }
}
