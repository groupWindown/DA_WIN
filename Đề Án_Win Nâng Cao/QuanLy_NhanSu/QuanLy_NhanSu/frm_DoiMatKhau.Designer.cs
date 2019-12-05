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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.txt_NhapMatKhau = new System.Windows.Forms.TextBox();
            this.txt_NhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.btn_NhapLaiMatKhau = new System.Windows.Forms.Button();
            this.btn_MatKhauMoi = new System.Windows.Forms.Button();
            this.btn_DoiMK = new System.Windows.Forms.Button();
            this.dataSetQLNS = new QuanLy_NhanSu.DataSetQLNS();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.TAIKHOANTableAdapter();
            this.tableAdapterManager = new QuanLy_NhanSu.DataSetQLNSTableAdapters.TableAdapterManager();
            this.labelNV = new System.Windows.Forms.Label();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txt_MK
            // 
            this.txt_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK.Location = new System.Drawing.Point(549, 183);
            this.txt_MK.Multiline = true;
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(223, 27);
            this.txt_MK.TabIndex = 3;
            // 
            // txt_NhapMatKhau
            // 
            this.txt_NhapMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NhapMatKhau.Location = new System.Drawing.Point(549, 226);
            this.txt_NhapMatKhau.Multiline = true;
            this.txt_NhapMatKhau.Name = "txt_NhapMatKhau";
            this.txt_NhapMatKhau.Size = new System.Drawing.Size(223, 27);
            this.txt_NhapMatKhau.TabIndex = 4;
            // 
            // txt_NhapLaiMatKhau
            // 
            this.txt_NhapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NhapLaiMatKhau.Location = new System.Drawing.Point(549, 270);
            this.txt_NhapLaiMatKhau.Multiline = true;
            this.txt_NhapLaiMatKhau.Name = "txt_NhapLaiMatKhau";
            this.txt_NhapLaiMatKhau.Size = new System.Drawing.Size(223, 27);
            this.txt_NhapLaiMatKhau.TabIndex = 5;
            // 
            // btn_NhapLaiMatKhau
            // 
            this.btn_NhapLaiMatKhau.BackgroundImage = global::QuanLy_NhanSu.Properties.Resources.hideshow;
            this.btn_NhapLaiMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NhapLaiMatKhau.Location = new System.Drawing.Point(778, 270);
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
            this.btn_MatKhauMoi.Location = new System.Drawing.Point(778, 226);
            this.btn_MatKhauMoi.Name = "btn_MatKhauMoi";
            this.btn_MatKhauMoi.Size = new System.Drawing.Size(35, 27);
            this.btn_MatKhauMoi.TabIndex = 7;
            this.btn_MatKhauMoi.UseVisualStyleBackColor = true;
            this.btn_MatKhauMoi.Click += new System.EventHandler(this.btn_MatKhauMoi_Click);
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMK.Location = new System.Drawing.Point(549, 315);
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.Size = new System.Drawing.Size(223, 30);
            this.btn_DoiMK.TabIndex = 8;
            this.btn_DoiMK.Text = "Đổi Mật Khẩu";
            this.btn_DoiMK.UseVisualStyleBackColor = true;
            this.btn_DoiMK.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            // 
            // dataSetQLNS
            // 
            this.dataSetQLNS.DataSetName = "DataSetQLNS";
            this.dataSetQLNS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOANBindingSource
            // 
            this.tAIKHOANBindingSource.DataMember = "TAIKHOAN";
            this.tAIKHOANBindingSource.DataSource = this.dataSetQLNS;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGCHAMCONGTableAdapter = null;
            this.tableAdapterManager.BANGTANGCATableAdapter = null;
            this.tableAdapterManager.BANGTANGLUONGTableAdapter = null;
            this.tableAdapterManager.BAOHIEMTableAdapter = null;
            this.tableAdapterManager.CHITIETCHUYENMONTableAdapter = null;
            this.tableAdapterManager.CHITIETHOPDONGTableAdapter = null;
            this.tableAdapterManager.CHITIETKHENTHUONGTableAdapter = null;
            this.tableAdapterManager.CHITIETNGOAINGUTableAdapter = null;
            this.tableAdapterManager.CHUCVUTableAdapter = null;
            this.tableAdapterManager.CHUONGTRINHDAOTAOTableAdapter = null;
            this.tableAdapterManager.CHUYENMONTableAdapter = null;
            this.tableAdapterManager.DANHMUCTANGCATableAdapter = null;
            this.tableAdapterManager.DANTOCTableAdapter = null;
            this.tableAdapterManager.DAOTAOTableAdapter = null;
            this.tableAdapterManager.DS_KYLUATTableAdapter = null;
            this.tableAdapterManager.HINHANHTableAdapter = null;
            this.tableAdapterManager.HOPDONGLAODONGTableAdapter = null;
            this.tableAdapterManager.HOSOTUYENDUNGTableAdapter = null;
            this.tableAdapterManager.KQ_TUYENDUNGTableAdapter = null;
            this.tableAdapterManager.LOAIKHENTHUONGTableAdapter = null;
            this.tableAdapterManager.MANHINHTableAdapter = null;
            this.tableAdapterManager.NGOAINGUTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGNHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHONGBANTableAdapter = null;
            this.tableAdapterManager.QUANLYKYLUATTableAdapter = null;
            this.tableAdapterManager.QUANLYNGHIVIECTableAdapter = null;
            this.tableAdapterManager.QUANLYTHAISANTableAdapter = null;
            this.tableAdapterManager.QUOCTICHTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = this.tAIKHOANTableAdapter;
            this.tableAdapterManager.TONGIAOTableAdapter = null;
            this.tableAdapterManager.TONGLUONGTableAdapter = null;
            this.tableAdapterManager.TRINHDOHOCVANTableAdapter = null;
            this.tableAdapterManager.TRINHDOTINHOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLy_NhanSu.DataSetQLNSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // labelNV
            // 
            this.labelNV.AutoSize = true;
            this.labelNV.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNV.Location = new System.Drawing.Point(529, 128);
            this.labelNV.Name = "labelNV";
            this.labelNV.Size = new System.Drawing.Size(252, 28);
            this.labelNV.TabIndex = 0;
            this.labelNV.Text = "Đổi mật khẩu nhân viên";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dataSetQLNS;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btn_DoiMK);
            this.Controls.Add(this.btn_MatKhauMoi);
            this.Controls.Add(this.btn_NhapLaiMatKhau);
            this.Controls.Add(this.txt_NhapLaiMatKhau);
            this.Controls.Add(this.txt_NhapMatKhau);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNV);
            this.Controls.Add(this.label1);
            this.Name = "frm_DoiMatKhau";
            this.Size = new System.Drawing.Size(833, 360);
            this.Load += new System.EventHandler(this.frm_DoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.TextBox txt_NhapMatKhau;
        private System.Windows.Forms.TextBox txt_NhapLaiMatKhau;
        private System.Windows.Forms.Button btn_NhapLaiMatKhau;
        private System.Windows.Forms.Button btn_MatKhauMoi;
        private System.Windows.Forms.Button btn_DoiMK;
        private DataSetQLNS dataSetQLNS;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private DataSetQLNSTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private DataSetQLNSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label labelNV;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DataSetQLNSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
    }
}