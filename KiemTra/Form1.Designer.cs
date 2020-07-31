namespace KiemTra
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxoalienlac = new System.Windows.Forms.Button();
            this.btnthemlienlac = new System.Windows.Forms.Button();
            this.btnxoanhom = new System.Windows.Forms.Button();
            this.btnthemnhom = new System.Windows.Forms.Button();
            this.dtgvnhom = new System.Windows.Forms.DataGridView();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttengoi = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.dtgvlienlac = new System.Windows.Forms.DataGridView();
            this.TenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlienlac)).BeginInit();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(423, 13);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(175, 22);
            this.txttimkiem.TabIndex = 5;
            this.txttimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(225, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập từ cần tìm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnxoalienlac
            // 
            this.btnxoalienlac.Image = global::KiemTra.Properties.Resources.icons8_delete_64;
            this.btnxoalienlac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoalienlac.Location = new System.Drawing.Point(612, 395);
            this.btnxoalienlac.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoalienlac.Name = "btnxoalienlac";
            this.btnxoalienlac.Size = new System.Drawing.Size(152, 81);
            this.btnxoalienlac.TabIndex = 3;
            this.btnxoalienlac.Text = "Xóa liên lạc";
            this.btnxoalienlac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoalienlac.UseVisualStyleBackColor = true;
            this.btnxoalienlac.Click += new System.EventHandler(this.Btnxoalienlac_Click);
            // 
            // btnthemlienlac
            // 
            this.btnthemlienlac.Image = global::KiemTra.Properties.Resources.icons8_add_50;
            this.btnthemlienlac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemlienlac.Location = new System.Drawing.Point(612, 338);
            this.btnthemlienlac.Margin = new System.Windows.Forms.Padding(4);
            this.btnthemlienlac.Name = "btnthemlienlac";
            this.btnthemlienlac.Size = new System.Drawing.Size(152, 49);
            this.btnthemlienlac.TabIndex = 2;
            this.btnthemlienlac.Text = "Thêm liên lạc";
            this.btnthemlienlac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemlienlac.UseVisualStyleBackColor = true;
            this.btnthemlienlac.Click += new System.EventHandler(this.Btnthemlienlac_Click);
            // 
            // btnxoanhom
            // 
            this.btnxoanhom.Image = global::KiemTra.Properties.Resources.icons8_delete_64;
            this.btnxoanhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoanhom.Location = new System.Drawing.Point(389, 395);
            this.btnxoanhom.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoanhom.Name = "btnxoanhom";
            this.btnxoanhom.Size = new System.Drawing.Size(147, 82);
            this.btnxoanhom.TabIndex = 1;
            this.btnxoanhom.Text = "Xóa nhóm";
            this.btnxoanhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoanhom.UseVisualStyleBackColor = true;
            this.btnxoanhom.Click += new System.EventHandler(this.Btnxoanhom_Click);
            // 
            // btnthemnhom
            // 
            this.btnthemnhom.Image = global::KiemTra.Properties.Resources.icons8_add_50;
            this.btnthemnhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemnhom.Location = new System.Drawing.Point(389, 338);
            this.btnthemnhom.Margin = new System.Windows.Forms.Padding(4);
            this.btnthemnhom.Name = "btnthemnhom";
            this.btnthemnhom.Size = new System.Drawing.Size(147, 49);
            this.btnthemnhom.TabIndex = 0;
            this.btnthemnhom.Text = "Thêm nhóm";
            this.btnthemnhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemnhom.UseVisualStyleBackColor = true;
            this.btnthemnhom.Click += new System.EventHandler(this.Btnthemnhom_Click);
            // 
            // dtgvnhom
            // 
            this.dtgvnhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvnhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNhom});
            this.dtgvnhom.Location = new System.Drawing.Point(28, 253);
            this.dtgvnhom.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvnhom.Name = "dtgvnhom";
            this.dtgvnhom.Size = new System.Drawing.Size(289, 223);
            this.dtgvnhom.TabIndex = 0;
            this.dtgvnhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvnhom_CellClick);
            // 
            // TenNhom
            // 
            this.TenNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Thêm nhóm";
            this.TenNhom.Name = "TenNhom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "[Tên gọi]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại";
            // 
            // txttengoi
            // 
            this.txttengoi.Location = new System.Drawing.Point(144, 81);
            this.txttengoi.Margin = new System.Windows.Forms.Padding(4);
            this.txttengoi.Name = "txttengoi";
            this.txttengoi.Size = new System.Drawing.Size(173, 22);
            this.txttengoi.TabIndex = 7;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(144, 136);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(173, 22);
            this.txtemail.TabIndex = 9;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(144, 197);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(173, 22);
            this.txtsdt.TabIndex = 10;
            // 
            // dtgvlienlac
            // 
            this.dtgvlienlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvlienlac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenGoi,
            this.Email,
            this.SDT});
            this.dtgvlienlac.Location = new System.Drawing.Point(348, 67);
            this.dtgvlienlac.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvlienlac.Name = "dtgvlienlac";
            this.dtgvlienlac.Size = new System.Drawing.Size(455, 263);
            this.dtgvlienlac.TabIndex = 4;
            this.dtgvlienlac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgvlienlac_CellClick);
            // 
            // TenGoi
            // 
            this.TenGoi.DataPropertyName = "TenGoi";
            this.TenGoi.HeaderText = "Tên gọi";
            this.TenGoi.Name = "TenGoi";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Emai";
            this.Email.Name = "Email";
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 490);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.dtgvnhom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvlienlac);
            this.Controls.Add(this.btnxoalienlac);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.btnthemlienlac);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btnxoanhom);
            this.Controls.Add(this.txttengoi);
            this.Controls.Add(this.btnthemnhom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Quản lý danh bạ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlienlac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoalienlac;
        private System.Windows.Forms.Button btnthemlienlac;
        private System.Windows.Forms.Button btnxoanhom;
        private System.Windows.Forms.Button btnthemnhom;
        private System.Windows.Forms.DataGridView dtgvnhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.TextBox txttengoi;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DataGridView dtgvlienlac;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}

