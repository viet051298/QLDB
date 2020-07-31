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
    public partial class Addnhom : Form
    {
        string path = @"D:\dot net\KiemTra\KiemTra\DATA\nhom.txt"; //path nhóm
        private Form1 form;
        public Addnhom(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Btnthemnhom_Click(object sender, EventArgs e)
        {
            string tenNhom = txttennhom.Text;
            if (tenNhom != null)
            {
                Nhom.add(tenNhom, path);
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

        private void Addnhom_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form.refreshdtgvnhom();
        }
    }
}
