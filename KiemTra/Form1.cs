using KiemTra.DAL.Entity;
using System;
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
    public partial class Form1 : Form
    {
        string path = @"D:\dot net\KiemTra\KiemTra\DATA\nhom.txt"; //path nhóm
        string path1 = @"D:\dot net\KiemTra\KiemTra\DATA\lienlac.txt"; //path liên lạc
        public Form1()
        {
            InitializeComponent();
            List<Nhom> nhom = Nhom.getNhomfromfile(path);
            dtgvnhom.AutoGenerateColumns = false;
            dtgvnhom.DataSource = nhom;
            List<LienLac> lienlac = LienLac.getLienlacfromfile(path1);
            dtgvlienlac.AutoGenerateColumns = false;
            dtgvlienlac.DataSource = lienlac;

        }

        //kích chuột vào liên lạc và hiển thị thông tin của hàng xuống dưới
        private void Dtgvlienlac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = dtgvlienlac.Rows[index];
                txttengoi.Text = selectRow.Cells["TenGoi"].Value.ToString();
                txtemail.Text = selectRow.Cells["Email"].Value.ToString();
                txtsdt.Text = selectRow.Cells["SDT"].Value.ToString();
            }
        }

        //kích chuột vào tên nhóm và hiển thị thông tin ra dtgv liên lạc
        private void Dtgvnhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectRow = dtgvnhom.Rows[index];
                string tenNhom = selectRow.Cells["TenNhom"].Value.ToString();
                string maNhom = Nhom.getMaTuTenNhom(tenNhom, path);

                dtgvlienlac.AutoGenerateColumns = false;
                dtgvlienlac.DataSource = LienLac.getLienLacTuMaNhom(maNhom, path1);
            }
        }

        //thêm nhóm
        private void Btnthemnhom_Click(object sender, EventArgs e)
        {
            var addnhom = new Addnhom(this);
            addnhom.Show();
        }

        //thêm liên lạc
        private void Btnthemlienlac_Click(object sender, EventArgs e)
        {
            dtgvnhom.CurrentRow.Selected = true;
            string tennhom = dtgvnhom.SelectedCells[0].Value.ToString();
            string manhom = Nhom.getMaTuTenNhom(tennhom, path);

            var addlienlac = new Addlienlac(this,manhom);
            addlienlac.Show();


        }

        //xóa nhóm
        private void Btnxoanhom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
              "Ban co that su muon xoa khong?",
              "Thong bao",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                bool flag = dtgvnhom.CurrentRow.Selected;
                if (flag)
                {
                    string tenNhom = dtgvnhom.SelectedCells[0].Value.ToString();
                    string maNhom = Nhom.getMaTuTenNhom(tenNhom, path);
                    Nhom.xoaNhom(path, maNhom);
                }

                MessageBox.Show("Da xoa thanh cong!",
                 "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //refresh
            refreshdtgvnhom();
        }

        // xóa liên lạc
        private void Btnxoalienlac_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có Muốn Xóa?",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning)== System.Windows.Forms.DialogResult.OK)
            {
                bool flag = dtgvlienlac.CurrentRow.Selected;
                if (flag)
                {
                    string tenGoi = dtgvlienlac.SelectedCells[0].Value.ToString();
                    string Email = LienLac.getEmailTuTenGoi(tenGoi, path1);
                    //Console.WriteLine(maNhom);
                    LienLac.xoalienlac(Email, path1);
                }
                MessageBox.Show("Da xoa thanh cong!",
                 "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //refersh
            refreshDtgvLienLac();

        }
        // Refresh dtgvLienLac
        public void refreshDtgvLienLac()
        {
            dtgvnhom.CurrentRow.Selected = true;
            string tenNhom = dtgvnhom.SelectedCells[0].Value.ToString();
            string maNhom = Nhom.getMaTuTenNhom(tenNhom, path);

            dtgvlienlac.AutoGenerateColumns = false;
            dtgvlienlac.DataSource = LienLac.getLienLacTuMaNhom(maNhom, path1);
            dtgvlienlac.Refresh();
        }

        // Refresh dtgvNhom
        public void refreshdtgvnhom()
        {
            dtgvnhom.AutoGenerateColumns = false;
            dtgvnhom.DataSource = Nhom.getNhomfromfile(path);
            dtgvnhom.Refresh();
        }

        //tim kiếm
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string tenGoi = txttimkiem.Text;
                List<LienLac> lstSearch = LienLac.timLienLac(path1, tenGoi);
                dtgvlienlac.DataSource = lstSearch;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
