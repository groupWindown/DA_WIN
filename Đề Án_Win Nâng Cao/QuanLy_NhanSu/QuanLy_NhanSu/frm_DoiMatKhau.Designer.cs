namespace QuanLy_NhanSu
{
    partial class frm_DoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_NhapMatKhau = new System.Windows.Forms.TextBox();
            this.txt_NhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.btn_NhapLaiMatKhau = new System.Windows.Forms.Button();
            this.btn_MatKhauMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 49);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 27);
            this.textBox2.TabIndex = 3;
            // 
            // txt_NhapMatKhau
            // 
            this.txt_NhapMatKhau.Location = new System.Drawing.Point(262, 92);
            this.txt_NhapMatKhau.Multiline = true;
            this.txt_NhapMatKhau.Name = "txt_NhapMatKhau";
            this.txt_NhapMatKhau.Size = new System.Drawing.Size(223, 27);
            this.txt_NhapMatKhau.TabIndex = 4;
            // 
            // txt_NhapLaiMatKhau
            // 
            this.txt_NhapLaiMatKhau.Location = new System.Drawing.Point(262, 136);
            this.txt_NhapLaiMatKhau.Multiline = true;
            this.txt_NhapLaiMatKhau.Name = "txt_NhapLaiMatKhau";
            this.txt_NhapLaiMatKhau.Size = new System.Drawing.Size(223, 27);
            this.txt_NhapLaiMatKhau.TabIndex = 5;
            // 
            // btn_NhapLaiMatKhau
            // 
            this.btn_NhapLaiMatKhau.BackgroundImage = global::QuanLy_NhanSu.Properties.Resources.hideshow;
            this.btn_NhapLaiMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NhapLaiMatKhau.Location = new System.Drawing.Point(491, 136);
            this.btn_NhapLaiMatKhau.Name = "btn_NhapLaiMatKhau";
            this.btn_NhapLaiMatKhau.Size = new System.Drawing.Size(35, 27);
            this.btn_NhapLaiMatKhau.TabIndex = 6;
            this.btn_NhapLaiMatKhau.UseVisualStyleBackColor = true;
            this.btn_NhapLaiMatKhau.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_MatKhauMoi
            // 
            this.btn_MatKhauMoi.BackgroundImage = global::QuanLy_NhanSu.Properties.Resources.hideshow;
            this.btn_MatKhauMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MatKhauMoi.Location = new System.Drawing.Point(491, 92);
            this.btn_MatKhauMoi.Name = "btn_MatKhauMoi";
            this.btn_MatKhauMoi.Size = new System.Drawing.Size(35, 27);
            this.btn_MatKhauMoi.TabIndex = 7;
            this.btn_MatKhauMoi.UseVisualStyleBackColor = true;
            this.btn_MatKhauMoi.Click += new System.EventHandler(this.btn_MatKhauMoi_Click);
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 231);
            this.Controls.Add(this.btn_MatKhauMoi);
            this.Controls.Add(this.btn_NhapLaiMatKhau);
            this.Controls.Add(this.txt_NhapLaiMatKhau);
            this.Controls.Add(this.txt_NhapMatKhau);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DoiMatKhau";
            this.Text = "frm_DoiMatKhau";
            this.Load += new System.EventHandler(this.frm_DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_NhapMatKhau;
        private System.Windows.Forms.TextBox txt_NhapLaiMatKhau;
        private System.Windows.Forms.Button btn_NhapLaiMatKhau;
        private System.Windows.Forms.Button btn_MatKhauMoi;
    }
}