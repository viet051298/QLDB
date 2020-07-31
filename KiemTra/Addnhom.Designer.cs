namespace KiemTra
{
    partial class Addnhom
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
            this.label2 = new System.Windows.Forms.Label();
            this.txttennhom = new System.Windows.Forms.TextBox();
            this.btnthemnhom = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhóm";
            // 
            // txttennhom
            // 
            this.txttennhom.Location = new System.Drawing.Point(235, 66);
            this.txttennhom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttennhom.Name = "txttennhom";
            this.txttennhom.Size = new System.Drawing.Size(220, 22);
            this.txttennhom.TabIndex = 3;
            // 
            // btnthemnhom
            // 
            this.btnthemnhom.Location = new System.Drawing.Point(104, 132);
            this.btnthemnhom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthemnhom.Name = "btnthemnhom";
            this.btnthemnhom.Size = new System.Drawing.Size(100, 28);
            this.btnthemnhom.TabIndex = 4;
            this.btnthemnhom.Text = "Đồng ý";
            this.btnthemnhom.UseVisualStyleBackColor = true;
            this.btnthemnhom.Click += new System.EventHandler(this.Btnthemnhom_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(281, 132);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(100, 28);
            this.btnhuy.TabIndex = 5;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.Btnhuy_Click);
            // 
            // Addnhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 217);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnthemnhom);
            this.Controls.Add(this.txttennhom);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Addnhom";
            this.Text = "Addnhom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Addnhom_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttennhom;
        private System.Windows.Forms.Button btnthemnhom;
        private System.Windows.Forms.Button btnhuy;
    }
}