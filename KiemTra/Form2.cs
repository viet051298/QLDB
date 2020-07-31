using System;
using KiemTra.DAL.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Btndangnhap_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            string user = "admin";
            string pass = "123456";
            if (user.Equals(txtdangnhap.Text) && pass.Equals(txtmatkhau.Text))
            {
                f.Show();
                Visible = false;
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau! Hay dang nhap lai.");
        }

        private void Btnthoat_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
