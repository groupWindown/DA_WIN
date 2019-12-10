namespace QuanLy_NhanSu
{
    partial class frm_NhapLieu_KT_KL
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.btn_Sua_KyLuat = new System.Windows.Forms.Button();
            this.btn_Xoa_KyLuat = new System.Windows.Forms.Button();
            this.btn_Them_KyLuat = new System.Windows.Forms.Button();
            this.txt_TenKyLuat = new System.Windows.Forms.TextBox();
            this.txt_MaKyLuat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_KhenThuong = new System.Windows.Forms.GroupBox();
            this.txt_TienThuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gridControl_KhenThuong = new DevExpress.XtraGrid.GridControl();
            this.lOAIKHENTHUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQLNS = new QuanLy_NhanSu.DataSetQLNS();
            this.gridView_KhenThuong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOAIKHENTHUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAITENKHENTHUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIENTHUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Sua_KhenThuong = new System.Windows.Forms.Button();
            this.btn_Xoa_KhenThuong = new System.Windows.Forms.Button();
            this.btn_Them_KhenThuong = new System.Windows.Forms.Button();
            this.txt_LoaiKhenThuong = new System.Windows.Forms.TextBox();
            this.txt_MaKhenThuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_KyLuat = new System.Windows.Forms.GroupBox();
            this.gridControl_KyLuat = new DevExpress.XtraGrid.GridControl();
            this.dS_KYLUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_KyLuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKYLUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKYLUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHINHTHUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIENKYLUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_TienKyLuat = new System.Windows.Forms.TextBox();
            this.txt_HinhThuc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dAOTAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIKHENTHUONGTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.LOAIKHENTHUONGTableAdapter();
            this.tableAdapterManager = new QuanLy_NhanSu.DataSetQLNSTableAdapters.TableAdapterManager();
            this.dS_KYLUATTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.DS_KYLUATTableAdapter();
            this.dAOTAOTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.DAOTAOTableAdapter();
            this.dANHMUCTANGCABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dANHMUCTANGCATableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.DANHMUCTANGCATableAdapter();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox_DanhMucTangCa = new System.Windows.Forms.GroupBox();
            this.gridControl_DMTangCa = new DevExpress.XtraGrid.GridControl();
            this.gridView_DMTangCa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOAICA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAICA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHESO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOGIOTANGCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Sua_DMTC = new System.Windows.Forms.Button();
            this.btn_Xoa_DMTC = new System.Windows.Forms.Button();
            this.btn_Them_DMTC = new System.Windows.Forms.Button();
            this.txt_SoGioTangCa = new System.Windows.Forms.TextBox();
            this.txt_HeSo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenLoaiCa = new System.Windows.Forms.TextBox();
            this.txt_MaLoaiCa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox_PhongBan = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gridControl_PhongBan = new DevExpress.XtraGrid.GridControl();
            this.gridView_PhongBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPHONGBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENPHONGBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATRUONGPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Sua_PhongBan = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Xoa_PhongBan = new System.Windows.Forms.Button();
            this.btn_Them_PhongBan = new System.Windows.Forms.Button();
            this.groupBox_ChucVu = new System.Windows.Forms.GroupBox();
            this.gridControl_ChucVu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMACHUCVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENCHUCVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Sua_ChucVu = new System.Windows.Forms.Button();
            this.btn_Xoa_ChucVu = new System.Windows.Forms.Button();
            this.btn_Them_ChucVu = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox_QuocTich = new System.Windows.Forms.GroupBox();
            this.gridControl_QuocTich = new DevExpress.XtraGrid.GridControl();
            this.gridView_QuocTich = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAQUOCTICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENQUOCTICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Sua_QuocTich = new System.Windows.Forms.Button();
            this.btn_Xoa_QuocTich = new System.Windows.Forms.Button();
            this.btn_Them_QuocTich = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox_TonGiao = new System.Windows.Forms.GroupBox();
            this.gridControl_TonGiao = new DevExpress.XtraGrid.GridControl();
            this.gridView_TonGiao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMATONGIAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTONGIAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Sua_TonGiao = new System.Windows.Forms.Button();
            this.btn_Xoa_TonGiao = new System.Windows.Forms.Button();
            this.btn_Them_TonGiao = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox_DanToc = new System.Windows.Forms.GroupBox();
            this.gridControl_DanToc = new DevExpress.XtraGrid.GridControl();
            this.gridView_DanToc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADANTOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENDANTOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Sua_DanToc = new System.Windows.Forms.Button();
            this.btn_Xoa_DanToc = new System.Windows.Forms.Button();
            this.btn_Them_DanToc = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox_NguoiDungNhomNguoiDun = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.nHOMNGUOIDUNGComboBox = new System.Windows.Forms.ComboBox();
            this.gridControl_NDNND = new DevExpress.XtraGrid.GridControl();
            this.gridView_NDNND = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANHOM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_TaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView_TaiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATKHAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOATDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Them_NDNND = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl_ManHinh = new DevExpress.XtraGrid.GridControl();
            this.gridView_ManHinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMANHINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMANHINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Sua_ManHinh = new System.Windows.Forms.Button();
            this.btn_Xoa_ManHinh = new System.Windows.Forms.Button();
            this.btn_Them_ManHinh = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btn_Sua_NhomNguoiDung = new System.Windows.Forms.Button();
            this.btn_Xoa_NhomNguoiDung = new System.Windows.Forms.Button();
            this.btn_Them_NhomNguoiDung = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMNGUOIDUNGTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.NHOMNGUOIDUNGTableAdapter();
            this.mANHINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mANHINHTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.MANHINHTableAdapter();
            this.nGUOIDUNGNHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOIDUNGNHOMNGUOIDUNGTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.NGUOIDUNGNHOMNGUOIDUNGTableAdapter();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.TAIKHOANTableAdapter();
            this.mANHOMComboBox = new System.Windows.Forms.ComboBox();
            this.tENNHOMTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gHICHUTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cHUCVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUCVUTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.CHUCVUTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qUOCTICHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUOCTICHTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.QUOCTICHTableAdapter();
            this.tONGIAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tONGIAOTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.TONGIAOTableAdapter();
            this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGBANTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.PHONGBANTableAdapter();
            this.dANTOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dANTOCTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.DANTOCTableAdapter();
            this.mAMANHINHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENMANHINHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAPHONGBANTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENPHONGBANTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mATRUONGPHONGTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mATONGIAOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENTONGIAOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mADANTOCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENDANTOCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAQUOCTICHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENQUOCTICHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mACHUCVUTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENCHUCVUTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupBox_KhenThuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KhenThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIKHENTHUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_KhenThuong)).BeginInit();
            this.groupBox_KyLuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KyLuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_KYLUATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_KyLuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAOTAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCTANGCABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox_DanhMucTangCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DMTangCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DMTangCa)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox_PhongBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PhongBan)).BeginInit();
            this.groupBox_ChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox_QuocTich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuocTich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_QuocTich)).BeginInit();
            this.groupBox_TonGiao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TonGiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TonGiao)).BeginInit();
            this.groupBox_DanToc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanToc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DanToc)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            this.groupBox_NguoiDungNhomNguoiDun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NDNND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_NDNND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TaiKhoan)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ManHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ManHinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANHINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGNHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENNHOMTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHICHUTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUOCTICHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGIAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANTOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMANHINHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMANHINHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAPHONGBANTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENPHONGBANTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATRUONGPHONGTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATONGIAOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTONGIAOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mADANTOCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENDANTOCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAQUOCTICHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENQUOCTICHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACHUCVUTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENCHUCVUTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sua_KyLuat
            // 
            this.btn_Sua_KyLuat.Location = new System.Drawing.Point(520, 72);
            this.btn_Sua_KyLuat.Name = "btn_Sua_KyLuat";
            this.btn_Sua_KyLuat.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_KyLuat.TabIndex = 11;
            this.btn_Sua_KyLuat.Text = "Sửa";
            this.btn_Sua_KyLuat.UseVisualStyleBackColor = true;
            this.btn_Sua_KyLuat.Click += new System.EventHandler(this.btn_Sua_KyLuat_Click);
            // 
            // btn_Xoa_KyLuat
            // 
            this.btn_Xoa_KyLuat.Location = new System.Drawing.Point(439, 72);
            this.btn_Xoa_KyLuat.Name = "btn_Xoa_KyLuat";
            this.btn_Xoa_KyLuat.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_KyLuat.TabIndex = 10;
            this.btn_Xoa_KyLuat.Text = "Xóa";
            this.btn_Xoa_KyLuat.UseVisualStyleBackColor = true;
            this.btn_Xoa_KyLuat.Click += new System.EventHandler(this.btn_Xoa_KyLuat_Click);
            // 
            // btn_Them_KyLuat
            // 
            this.btn_Them_KyLuat.Location = new System.Drawing.Point(358, 72);
            this.btn_Them_KyLuat.Name = "btn_Them_KyLuat";
            this.btn_Them_KyLuat.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_KyLuat.TabIndex = 8;
            this.btn_Them_KyLuat.Text = "Thêm";
            this.btn_Them_KyLuat.UseVisualStyleBackColor = true;
            this.btn_Them_KyLuat.Click += new System.EventHandler(this.btn_Them_KyLuat_Click);
            // 
            // txt_TenKyLuat
            // 
            this.txt_TenKyLuat.Location = new System.Drawing.Point(139, 53);
            this.txt_TenKyLuat.Name = "txt_TenKyLuat";
            this.txt_TenKyLuat.Size = new System.Drawing.Size(199, 26);
            this.txt_TenKyLuat.TabIndex = 7;
            // 
            // txt_MaKyLuat
            // 
            this.txt_MaKyLuat.Location = new System.Drawing.Point(139, 19);
            this.txt_MaKyLuat.Name = "txt_MaKyLuat";
            this.txt_MaKyLuat.Size = new System.Drawing.Size(199, 26);
            this.txt_MaKyLuat.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên kỷ luật";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã kỷ luật";
            // 
            // groupBox_KhenThuong
            // 
            this.groupBox_KhenThuong.Controls.Add(this.txt_TienThuong);
            this.groupBox_KhenThuong.Controls.Add(this.label7);
            this.groupBox_KhenThuong.Controls.Add(this.gridControl_KhenThuong);
            this.groupBox_KhenThuong.Controls.Add(this.btn_Sua_KhenThuong);
            this.groupBox_KhenThuong.Controls.Add(this.btn_Xoa_KhenThuong);
            this.groupBox_KhenThuong.Controls.Add(this.btn_Them_KhenThuong);
            this.groupBox_KhenThuong.Controls.Add(this.txt_LoaiKhenThuong);
            this.groupBox_KhenThuong.Controls.Add(this.txt_MaKhenThuong);
            this.groupBox_KhenThuong.Controls.Add(this.label2);
            this.groupBox_KhenThuong.Controls.Add(this.label3);
            this.groupBox_KhenThuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_KhenThuong.Location = new System.Drawing.Point(313, 381);
            this.groupBox_KhenThuong.Name = "groupBox_KhenThuong";
            this.groupBox_KhenThuong.Size = new System.Drawing.Size(619, 314);
            this.groupBox_KhenThuong.TabIndex = 7;
            this.groupBox_KhenThuong.TabStop = false;
            this.groupBox_KhenThuong.Text = "Khen thưởng";
            // 
            // txt_TienThuong
            // 
            this.txt_TienThuong.Location = new System.Drawing.Point(139, 88);
            this.txt_TienThuong.Name = "txt_TienThuong";
            this.txt_TienThuong.Size = new System.Drawing.Size(199, 26);
            this.txt_TienThuong.TabIndex = 14;
            this.txt_TienThuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_HeSo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tiền thưởng";
            // 
            // gridControl_KhenThuong
            // 
            this.gridControl_KhenThuong.DataSource = this.lOAIKHENTHUONGBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl_KhenThuong.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl_KhenThuong.Location = new System.Drawing.Point(22, 120);
            this.gridControl_KhenThuong.MainView = this.gridView_KhenThuong;
            this.gridControl_KhenThuong.Name = "gridControl_KhenThuong";
            this.gridControl_KhenThuong.Size = new System.Drawing.Size(573, 178);
            this.gridControl_KhenThuong.TabIndex = 12;
            this.gridControl_KhenThuong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_KhenThuong});
            // 
            // lOAIKHENTHUONGBindingSource
            // 
            this.lOAIKHENTHUONGBindingSource.DataMember = "LOAIKHENTHUONG";
            this.lOAIKHENTHUONGBindingSource.DataSource = this.dataSetQLNS;
            // 
            // dataSetQLNS
            // 
            this.dataSetQLNS.DataSetName = "DataSetQLNS";
            this.dataSetQLNS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView_KhenThuong
            // 
            this.gridView_KhenThuong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOAIKHENTHUONG,
            this.colLOAITENKHENTHUONG,
            this.colTIENTHUONG});
            this.gridView_KhenThuong.GridControl = this.gridControl_KhenThuong;
            this.gridView_KhenThuong.Name = "gridView_KhenThuong";
            // 
            // colMALOAIKHENTHUONG
            // 
            this.colMALOAIKHENTHUONG.Caption = "Mã loại khen thưởng";
            this.colMALOAIKHENTHUONG.FieldName = "MALOAIKHENTHUONG";
            this.colMALOAIKHENTHUONG.Name = "colMALOAIKHENTHUONG";
            this.colMALOAIKHENTHUONG.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.colMALOAIKHENTHUONG.Visible = true;
            this.colMALOAIKHENTHUONG.VisibleIndex = 0;
            // 
            // colLOAITENKHENTHUONG
            // 
            this.colLOAITENKHENTHUONG.Caption = "Loại khen thưởng";
            this.colLOAITENKHENTHUONG.FieldName = "LOAITENKHENTHUONG";
            this.colLOAITENKHENTHUONG.Name = "colLOAITENKHENTHUONG";
            this.colLOAITENKHENTHUONG.Visible = true;
            this.colLOAITENKHENTHUONG.VisibleIndex = 1;
            // 
            // colTIENTHUONG
            // 
            this.colTIENTHUONG.Caption = "Tiền thưởng";
            this.colTIENTHUONG.FieldName = "TIENTHUONG";
            this.colTIENTHUONG.Name = "colTIENTHUONG";
            this.colTIENTHUONG.Visible = true;
            this.colTIENTHUONG.VisibleIndex = 2;
            // 
            // btn_Sua_KhenThuong
            // 
            this.btn_Sua_KhenThuong.Location = new System.Drawing.Point(520, 51);
            this.btn_Sua_KhenThuong.Name = "btn_Sua_KhenThuong";
            this.btn_Sua_KhenThuong.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_KhenThuong.TabIndex = 11;
            this.btn_Sua_KhenThuong.Text = "Sửa";
            this.btn_Sua_KhenThuong.UseVisualStyleBackColor = true;
            this.btn_Sua_KhenThuong.Click += new System.EventHandler(this.btn_Sua_KhenThuong_Click);
            // 
            // btn_Xoa_KhenThuong
            // 
            this.btn_Xoa_KhenThuong.Location = new System.Drawing.Point(439, 51);
            this.btn_Xoa_KhenThuong.Name = "btn_Xoa_KhenThuong";
            this.btn_Xoa_KhenThuong.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_KhenThuong.TabIndex = 10;
            this.btn_Xoa_KhenThuong.Text = "Xóa";
            this.btn_Xoa_KhenThuong.UseVisualStyleBackColor = true;
            this.btn_Xoa_KhenThuong.Click += new System.EventHandler(this.btn_Xoa_KhenThuong_Click);
            // 
            // btn_Them_KhenThuong
            // 
            this.btn_Them_KhenThuong.Location = new System.Drawing.Point(358, 51);
            this.btn_Them_KhenThuong.Name = "btn_Them_KhenThuong";
            this.btn_Them_KhenThuong.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_KhenThuong.TabIndex = 8;
            this.btn_Them_KhenThuong.Text = "Thêm";
            this.btn_Them_KhenThuong.UseVisualStyleBackColor = true;
            this.btn_Them_KhenThuong.Click += new System.EventHandler(this.btn_Them_KhenThuong_Click);
            // 
            // txt_LoaiKhenThuong
            // 
            this.txt_LoaiKhenThuong.Location = new System.Drawing.Point(139, 53);
            this.txt_LoaiKhenThuong.Name = "txt_LoaiKhenThuong";
            this.txt_LoaiKhenThuong.Size = new System.Drawing.Size(199, 26);
            this.txt_LoaiKhenThuong.TabIndex = 7;
            // 
            // txt_MaKhenThuong
            // 
            this.txt_MaKhenThuong.Location = new System.Drawing.Point(139, 19);
            this.txt_MaKhenThuong.Name = "txt_MaKhenThuong";
            this.txt_MaKhenThuong.Size = new System.Drawing.Size(199, 26);
            this.txt_MaKhenThuong.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại khen thưởng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã khen thưởng";
            // 
            // groupBox_KyLuat
            // 
            this.groupBox_KyLuat.Controls.Add(this.gridControl_KyLuat);
            this.groupBox_KyLuat.Controls.Add(this.txt_TienKyLuat);
            this.groupBox_KyLuat.Controls.Add(this.txt_HinhThuc);
            this.groupBox_KyLuat.Controls.Add(this.label8);
            this.groupBox_KyLuat.Controls.Add(this.label9);
            this.groupBox_KyLuat.Controls.Add(this.btn_Sua_KyLuat);
            this.groupBox_KyLuat.Controls.Add(this.btn_Xoa_KyLuat);
            this.groupBox_KyLuat.Controls.Add(this.btn_Them_KyLuat);
            this.groupBox_KyLuat.Controls.Add(this.txt_TenKyLuat);
            this.groupBox_KyLuat.Controls.Add(this.txt_MaKyLuat);
            this.groupBox_KyLuat.Controls.Add(this.label1);
            this.groupBox_KyLuat.Controls.Add(this.label4);
            this.groupBox_KyLuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_KyLuat.Location = new System.Drawing.Point(689, 4);
            this.groupBox_KyLuat.Name = "groupBox_KyLuat";
            this.groupBox_KyLuat.Size = new System.Drawing.Size(619, 371);
            this.groupBox_KyLuat.TabIndex = 8;
            this.groupBox_KyLuat.TabStop = false;
            this.groupBox_KyLuat.Text = "Kỷ luật";
            // 
            // gridControl_KyLuat
            // 
            this.gridControl_KyLuat.DataSource = this.dS_KYLUATBindingSource;
            this.gridControl_KyLuat.Location = new System.Drawing.Point(28, 156);
            this.gridControl_KyLuat.MainView = this.gridView_KyLuat;
            this.gridControl_KyLuat.Name = "gridControl_KyLuat";
            this.gridControl_KyLuat.Size = new System.Drawing.Size(567, 197);
            this.gridControl_KyLuat.TabIndex = 16;
            this.gridControl_KyLuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_KyLuat});
            this.gridControl_KyLuat.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // dS_KYLUATBindingSource
            // 
            this.dS_KYLUATBindingSource.DataMember = "DS_KYLUAT";
            this.dS_KYLUATBindingSource.DataSource = this.dataSetQLNS;
            // 
            // gridView_KyLuat
            // 
            this.gridView_KyLuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKYLUAT,
            this.colTENKYLUAT,
            this.colHINHTHUC,
            this.colTIENKYLUAT});
            this.gridView_KyLuat.GridControl = this.gridControl_KyLuat;
            this.gridView_KyLuat.Name = "gridView_KyLuat";
            // 
            // colMAKYLUAT
            // 
            this.colMAKYLUAT.Caption = "Mã kỷ luật";
            this.colMAKYLUAT.FieldName = "MAKYLUAT";
            this.colMAKYLUAT.Name = "colMAKYLUAT";
            this.colMAKYLUAT.Visible = true;
            this.colMAKYLUAT.VisibleIndex = 0;
            // 
            // colTENKYLUAT
            // 
            this.colTENKYLUAT.Caption = "Tên kỷ luật";
            this.colTENKYLUAT.FieldName = "TENKYLUAT";
            this.colTENKYLUAT.Name = "colTENKYLUAT";
            this.colTENKYLUAT.Visible = true;
            this.colTENKYLUAT.VisibleIndex = 1;
            // 
            // colHINHTHUC
            // 
            this.colHINHTHUC.Caption = "Hình thức";
            this.colHINHTHUC.FieldName = "HINHTHUC";
            this.colHINHTHUC.Name = "colHINHTHUC";
            this.colHINHTHUC.Visible = true;
            this.colHINHTHUC.VisibleIndex = 2;
            // 
            // colTIENKYLUAT
            // 
            this.colTIENKYLUAT.Caption = "Tiền kỷ luật";
            this.colTIENKYLUAT.FieldName = "TIENKYLUAT";
            this.colTIENKYLUAT.Name = "colTIENKYLUAT";
            this.colTIENKYLUAT.Visible = true;
            this.colTIENKYLUAT.VisibleIndex = 3;
            // 
            // txt_TienKyLuat
            // 
            this.txt_TienKyLuat.Location = new System.Drawing.Point(139, 124);
            this.txt_TienKyLuat.Name = "txt_TienKyLuat";
            this.txt_TienKyLuat.Size = new System.Drawing.Size(199, 26);
            this.txt_TienKyLuat.TabIndex = 15;
            this.txt_TienKyLuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_HeSo_KeyPress);
            // 
            // txt_HinhThuc
            // 
            this.txt_HinhThuc.Location = new System.Drawing.Point(139, 90);
            this.txt_HinhThuc.Name = "txt_HinhThuc";
            this.txt_HinhThuc.Size = new System.Drawing.Size(199, 26);
            this.txt_HinhThuc.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tiền kỷ luật";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Hình thức";
            // 
            // dAOTAOBindingSource
            // 
            this.dAOTAOBindingSource.DataMember = "DAOTAO";
            this.dAOTAOBindingSource.DataSource = this.dataSetQLNS;
            // 
            // lOAIKHENTHUONGTableAdapter
            // 
            this.lOAIKHENTHUONGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOAIKHENTHUONGTableAdapter = this.lOAIKHENTHUONGTableAdapter;
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
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.TONGIAOTableAdapter = null;
            this.tableAdapterManager.TONGLUONGTableAdapter = null;
            this.tableAdapterManager.TRINHDOHOCVANTableAdapter = null;
            this.tableAdapterManager.TRINHDOTINHOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLy_NhanSu.DataSetQLNSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_KYLUATTableAdapter
            // 
            this.dS_KYLUATTableAdapter.ClearBeforeFill = true;
            // 
            // dAOTAOTableAdapter
            // 
            this.dAOTAOTableAdapter.ClearBeforeFill = true;
            // 
            // dANHMUCTANGCABindingSource
            // 
            this.dANHMUCTANGCABindingSource.DataMember = "DANHMUCTANGCA";
            this.dANHMUCTANGCABindingSource.DataSource = this.dataSetQLNS;
            // 
            // dANHMUCTANGCATableAdapter
            // 
            this.dANHMUCTANGCATableAdapter.ClearBeforeFill = true;
            // 
            // tabPane1
            // 
            this.tabPane1.Appearance.BackColor = System.Drawing.Color.White;
            this.tabPane1.Appearance.Options.UseBackColor = true;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Location = new System.Drawing.Point(4, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(1341, 768);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1341, 768);
            this.tabPane1.TabIndex = 10;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Danh mục Lương";
            this.tabNavigationPage1.Controls.Add(this.groupBox_DanhMucTangCa);
            this.tabNavigationPage1.Controls.Add(this.groupBox_KyLuat);
            this.tabNavigationPage1.Controls.Add(this.groupBox_KhenThuong);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1341, 741);
            // 
            // groupBox_DanhMucTangCa
            // 
            this.groupBox_DanhMucTangCa.Controls.Add(this.gridControl_DMTangCa);
            this.groupBox_DanhMucTangCa.Controls.Add(this.btn_Sua_DMTC);
            this.groupBox_DanhMucTangCa.Controls.Add(this.btn_Xoa_DMTC);
            this.groupBox_DanhMucTangCa.Controls.Add(this.btn_Them_DMTC);
            this.groupBox_DanhMucTangCa.Controls.Add(this.txt_SoGioTangCa);
            this.groupBox_DanhMucTangCa.Controls.Add(this.txt_HeSo);
            this.groupBox_DanhMucTangCa.Controls.Add(this.label5);
            this.groupBox_DanhMucTangCa.Controls.Add(this.label6);
            this.groupBox_DanhMucTangCa.Controls.Add(this.txt_TenLoaiCa);
            this.groupBox_DanhMucTangCa.Controls.Add(this.txt_MaLoaiCa);
            this.groupBox_DanhMucTangCa.Controls.Add(this.label10);
            this.groupBox_DanhMucTangCa.Controls.Add(this.label11);
            this.groupBox_DanhMucTangCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DanhMucTangCa.Location = new System.Drawing.Point(24, 4);
            this.groupBox_DanhMucTangCa.Name = "groupBox_DanhMucTangCa";
            this.groupBox_DanhMucTangCa.Size = new System.Drawing.Size(614, 371);
            this.groupBox_DanhMucTangCa.TabIndex = 10;
            this.groupBox_DanhMucTangCa.TabStop = false;
            this.groupBox_DanhMucTangCa.Text = "Danh mục tăng ca";
            // 
            // gridControl_DMTangCa
            // 
            this.gridControl_DMTangCa.DataSource = this.dANHMUCTANGCABindingSource;
            this.gridControl_DMTangCa.Location = new System.Drawing.Point(27, 156);
            this.gridControl_DMTangCa.MainView = this.gridView_DMTangCa;
            this.gridControl_DMTangCa.Name = "gridControl_DMTangCa";
            this.gridControl_DMTangCa.Size = new System.Drawing.Size(563, 197);
            this.gridControl_DMTangCa.TabIndex = 27;
            this.gridControl_DMTangCa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DMTangCa});
            // 
            // gridView_DMTangCa
            // 
            this.gridView_DMTangCa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOAICA,
            this.colTENLOAICA,
            this.colHESO,
            this.colSOGIOTANGCA});
            this.gridView_DMTangCa.GridControl = this.gridControl_DMTangCa;
            this.gridView_DMTangCa.Name = "gridView_DMTangCa";
            // 
            // colMALOAICA
            // 
            this.colMALOAICA.Caption = "Mã loại ca";
            this.colMALOAICA.FieldName = "MALOAICA";
            this.colMALOAICA.Name = "colMALOAICA";
            this.colMALOAICA.Visible = true;
            this.colMALOAICA.VisibleIndex = 0;
            // 
            // colTENLOAICA
            // 
            this.colTENLOAICA.Caption = "Tên loại ca";
            this.colTENLOAICA.FieldName = "TENLOAICA";
            this.colTENLOAICA.Name = "colTENLOAICA";
            this.colTENLOAICA.Visible = true;
            this.colTENLOAICA.VisibleIndex = 1;
            // 
            // colHESO
            // 
            this.colHESO.Caption = "Hệ số";
            this.colHESO.FieldName = "HESO";
            this.colHESO.Name = "colHESO";
            this.colHESO.Visible = true;
            this.colHESO.VisibleIndex = 2;
            // 
            // colSOGIOTANGCA
            // 
            this.colSOGIOTANGCA.Caption = "Số giờ tăng ca";
            this.colSOGIOTANGCA.FieldName = "SOGIOTANGCA";
            this.colSOGIOTANGCA.Name = "colSOGIOTANGCA";
            this.colSOGIOTANGCA.Visible = true;
            this.colSOGIOTANGCA.VisibleIndex = 3;
            // 
            // btn_Sua_DMTC
            // 
            this.btn_Sua_DMTC.Location = new System.Drawing.Point(515, 72);
            this.btn_Sua_DMTC.Name = "btn_Sua_DMTC";
            this.btn_Sua_DMTC.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_DMTC.TabIndex = 26;
            this.btn_Sua_DMTC.Text = "Sửa";
            this.btn_Sua_DMTC.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa_DMTC
            // 
            this.btn_Xoa_DMTC.Location = new System.Drawing.Point(434, 72);
            this.btn_Xoa_DMTC.Name = "btn_Xoa_DMTC";
            this.btn_Xoa_DMTC.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_DMTC.TabIndex = 25;
            this.btn_Xoa_DMTC.Text = "Xóa";
            this.btn_Xoa_DMTC.UseVisualStyleBackColor = true;
            // 
            // btn_Them_DMTC
            // 
            this.btn_Them_DMTC.Location = new System.Drawing.Point(353, 72);
            this.btn_Them_DMTC.Name = "btn_Them_DMTC";
            this.btn_Them_DMTC.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_DMTC.TabIndex = 24;
            this.btn_Them_DMTC.Text = "Thêm";
            this.btn_Them_DMTC.UseVisualStyleBackColor = true;
            // 
            // txt_SoGioTangCa
            // 
            this.txt_SoGioTangCa.Location = new System.Drawing.Point(138, 124);
            this.txt_SoGioTangCa.Name = "txt_SoGioTangCa";
            this.txt_SoGioTangCa.Size = new System.Drawing.Size(199, 26);
            this.txt_SoGioTangCa.TabIndex = 23;
            // 
            // txt_HeSo
            // 
            this.txt_HeSo.Location = new System.Drawing.Point(138, 90);
            this.txt_HeSo.Name = "txt_HeSo";
            this.txt_HeSo.Size = new System.Drawing.Size(199, 26);
            this.txt_HeSo.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số giờ tăng ca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hệ số";
            // 
            // txt_TenLoaiCa
            // 
            this.txt_TenLoaiCa.Location = new System.Drawing.Point(138, 53);
            this.txt_TenLoaiCa.Name = "txt_TenLoaiCa";
            this.txt_TenLoaiCa.Size = new System.Drawing.Size(199, 26);
            this.txt_TenLoaiCa.TabIndex = 19;
            // 
            // txt_MaLoaiCa
            // 
            this.txt_MaLoaiCa.Location = new System.Drawing.Point(138, 19);
            this.txt_MaLoaiCa.Name = "txt_MaLoaiCa";
            this.txt_MaLoaiCa.Size = new System.Drawing.Size(199, 26);
            this.txt_MaLoaiCa.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tên loại ca";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Mã loại ca";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Danh mục Thông Tin";
            this.tabNavigationPage2.Controls.Add(this.groupBox_PhongBan);
            this.tabNavigationPage2.Controls.Add(this.groupBox_ChucVu);
            this.tabNavigationPage2.Controls.Add(this.groupBox_QuocTich);
            this.tabNavigationPage2.Controls.Add(this.groupBox_TonGiao);
            this.tabNavigationPage2.Controls.Add(this.groupBox_DanToc);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1341, 741);
            // 
            // groupBox_PhongBan
            // 
            this.groupBox_PhongBan.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.groupBox_PhongBan.Controls.Add(this.mAPHONGBANTextEdit);
            this.groupBox_PhongBan.Controls.Add(this.tENPHONGBANTextEdit);
            this.groupBox_PhongBan.Controls.Add(this.mATRUONGPHONGTextEdit);
            this.groupBox_PhongBan.Controls.Add(this.label12);
            this.groupBox_PhongBan.Controls.Add(this.gridControl_PhongBan);
            this.groupBox_PhongBan.Controls.Add(this.label13);
            this.groupBox_PhongBan.Controls.Add(this.btn_Sua_PhongBan);
            this.groupBox_PhongBan.Controls.Add(this.label14);
            this.groupBox_PhongBan.Controls.Add(this.btn_Xoa_PhongBan);
            this.groupBox_PhongBan.Controls.Add(this.btn_Them_PhongBan);
            this.groupBox_PhongBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_PhongBan.Location = new System.Drawing.Point(3, 360);
            this.groupBox_PhongBan.Name = "groupBox_PhongBan";
            this.groupBox_PhongBan.Size = new System.Drawing.Size(632, 371);
            this.groupBox_PhongBan.TabIndex = 9;
            this.groupBox_PhongBan.TabStop = false;
            this.groupBox_PhongBan.Text = "Phòng ban";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Mã trưởng phòng";
            // 
            // gridControl_PhongBan
            // 
            this.gridControl_PhongBan.DataSource = this.pHONGBANBindingSource;
            this.gridControl_PhongBan.Location = new System.Drawing.Point(6, 136);
            this.gridControl_PhongBan.MainView = this.gridView_PhongBan;
            this.gridControl_PhongBan.Name = "gridControl_PhongBan";
            this.gridControl_PhongBan.Size = new System.Drawing.Size(606, 229);
            this.gridControl_PhongBan.TabIndex = 25;
            this.gridControl_PhongBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_PhongBan});
            // 
            // gridView_PhongBan
            // 
            this.gridView_PhongBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPHONGBAN,
            this.colTENPHONGBAN,
            this.colMATRUONGPHONG});
            this.gridView_PhongBan.GridControl = this.gridControl_PhongBan;
            this.gridView_PhongBan.Name = "gridView_PhongBan";
            // 
            // colMAPHONGBAN
            // 
            this.colMAPHONGBAN.Caption = "Mã phòng ban";
            this.colMAPHONGBAN.FieldName = "MAPHONGBAN";
            this.colMAPHONGBAN.Name = "colMAPHONGBAN";
            this.colMAPHONGBAN.Visible = true;
            this.colMAPHONGBAN.VisibleIndex = 0;
            // 
            // colTENPHONGBAN
            // 
            this.colTENPHONGBAN.Caption = "Tên phòng ban";
            this.colTENPHONGBAN.FieldName = "TENPHONGBAN";
            this.colTENPHONGBAN.Name = "colTENPHONGBAN";
            this.colTENPHONGBAN.Visible = true;
            this.colTENPHONGBAN.VisibleIndex = 1;
            // 
            // colMATRUONGPHONG
            // 
            this.colMATRUONGPHONG.Caption = "Mã trưởng phòng";
            this.colMATRUONGPHONG.FieldName = "MATRUONGPHONG";
            this.colMATRUONGPHONG.Name = "colMATRUONGPHONG";
            this.colMATRUONGPHONG.Visible = true;
            this.colMATRUONGPHONG.VisibleIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "Mã phòng ban";
            // 
            // btn_Sua_PhongBan
            // 
            this.btn_Sua_PhongBan.Location = new System.Drawing.Point(519, 69);
            this.btn_Sua_PhongBan.Name = "btn_Sua_PhongBan";
            this.btn_Sua_PhongBan.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_PhongBan.TabIndex = 19;
            this.btn_Sua_PhongBan.Text = "Sửa";
            this.btn_Sua_PhongBan.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 19);
            this.label14.TabIndex = 13;
            this.label14.Text = "Phòng ban";
            // 
            // btn_Xoa_PhongBan
            // 
            this.btn_Xoa_PhongBan.Location = new System.Drawing.Point(438, 69);
            this.btn_Xoa_PhongBan.Name = "btn_Xoa_PhongBan";
            this.btn_Xoa_PhongBan.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_PhongBan.TabIndex = 18;
            this.btn_Xoa_PhongBan.Text = "Xóa";
            this.btn_Xoa_PhongBan.UseVisualStyleBackColor = true;
            // 
            // btn_Them_PhongBan
            // 
            this.btn_Them_PhongBan.Location = new System.Drawing.Point(357, 69);
            this.btn_Them_PhongBan.Name = "btn_Them_PhongBan";
            this.btn_Them_PhongBan.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_PhongBan.TabIndex = 16;
            this.btn_Them_PhongBan.Text = "Thêm";
            this.btn_Them_PhongBan.UseVisualStyleBackColor = true;
            // 
            // groupBox_ChucVu
            // 
            this.groupBox_ChucVu.Controls.Add(this.mACHUCVUTextEdit);
            this.groupBox_ChucVu.Controls.Add(this.tENCHUCVUTextEdit);
            this.groupBox_ChucVu.Controls.Add(this.gridControl_ChucVu);
            this.groupBox_ChucVu.Controls.Add(this.btn_Sua_ChucVu);
            this.groupBox_ChucVu.Controls.Add(this.btn_Xoa_ChucVu);
            this.groupBox_ChucVu.Controls.Add(this.btn_Them_ChucVu);
            this.groupBox_ChucVu.Controls.Add(this.label15);
            this.groupBox_ChucVu.Controls.Add(this.label16);
            this.groupBox_ChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ChucVu.Location = new System.Drawing.Point(3, 3);
            this.groupBox_ChucVu.Name = "groupBox_ChucVu";
            this.groupBox_ChucVu.Size = new System.Drawing.Size(632, 339);
            this.groupBox_ChucVu.TabIndex = 8;
            this.groupBox_ChucVu.TabStop = false;
            this.groupBox_ChucVu.Text = "Chức vụ ";
            // 
            // gridControl_ChucVu
            // 
            this.gridControl_ChucVu.DataSource = this.cHUCVUBindingSource;
            this.gridControl_ChucVu.Location = new System.Drawing.Point(6, 91);
            this.gridControl_ChucVu.MainView = this.gridView1;
            this.gridControl_ChucVu.Name = "gridControl_ChucVu";
            this.gridControl_ChucVu.Size = new System.Drawing.Size(606, 228);
            this.gridControl_ChucVu.TabIndex = 22;
            this.gridControl_ChucVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMACHUCVU,
            this.colTENCHUCVU});
            this.gridView1.GridControl = this.gridControl_ChucVu;
            this.gridView1.Name = "gridView1";
            // 
            // colMACHUCVU
            // 
            this.colMACHUCVU.FieldName = "MACHUCVU";
            this.colMACHUCVU.Name = "colMACHUCVU";
            this.colMACHUCVU.OptionsColumn.ReadOnly = true;
            this.colMACHUCVU.Visible = true;
            this.colMACHUCVU.VisibleIndex = 0;
            // 
            // colTENCHUCVU
            // 
            this.colTENCHUCVU.FieldName = "TENCHUCVU";
            this.colTENCHUCVU.Name = "colTENCHUCVU";
            this.colTENCHUCVU.Visible = true;
            this.colTENCHUCVU.VisibleIndex = 1;
            // 
            // btn_Sua_ChucVu
            // 
            this.btn_Sua_ChucVu.Location = new System.Drawing.Point(508, 39);
            this.btn_Sua_ChucVu.Name = "btn_Sua_ChucVu";
            this.btn_Sua_ChucVu.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_ChucVu.TabIndex = 11;
            this.btn_Sua_ChucVu.Text = "Sửa";
            this.btn_Sua_ChucVu.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa_ChucVu
            // 
            this.btn_Xoa_ChucVu.Location = new System.Drawing.Point(427, 39);
            this.btn_Xoa_ChucVu.Name = "btn_Xoa_ChucVu";
            this.btn_Xoa_ChucVu.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_ChucVu.TabIndex = 10;
            this.btn_Xoa_ChucVu.Text = "Xóa";
            this.btn_Xoa_ChucVu.UseVisualStyleBackColor = true;
            // 
            // btn_Them_ChucVu
            // 
            this.btn_Them_ChucVu.Location = new System.Drawing.Point(346, 39);
            this.btn_Them_ChucVu.Name = "btn_Them_ChucVu";
            this.btn_Them_ChucVu.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_ChucVu.TabIndex = 8;
            this.btn_Them_ChucVu.Text = "Thêm";
            this.btn_Them_ChucVu.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "Chức vụ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã chức vụ";
            // 
            // groupBox_QuocTich
            // 
            this.groupBox_QuocTich.Controls.Add(this.mAQUOCTICHTextEdit);
            this.groupBox_QuocTich.Controls.Add(this.tENQUOCTICHTextEdit);
            this.groupBox_QuocTich.Controls.Add(this.gridControl_QuocTich);
            this.groupBox_QuocTich.Controls.Add(this.btn_Sua_QuocTich);
            this.groupBox_QuocTich.Controls.Add(this.btn_Xoa_QuocTich);
            this.groupBox_QuocTich.Controls.Add(this.btn_Them_QuocTich);
            this.groupBox_QuocTich.Controls.Add(this.label17);
            this.groupBox_QuocTich.Controls.Add(this.label18);
            this.groupBox_QuocTich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_QuocTich.Location = new System.Drawing.Point(654, 3);
            this.groupBox_QuocTich.Name = "groupBox_QuocTich";
            this.groupBox_QuocTich.Size = new System.Drawing.Size(651, 239);
            this.groupBox_QuocTich.TabIndex = 7;
            this.groupBox_QuocTich.TabStop = false;
            this.groupBox_QuocTich.Text = "Quốc tịch";
            // 
            // gridControl_QuocTich
            // 
            this.gridControl_QuocTich.DataSource = this.qUOCTICHBindingSource;
            this.gridControl_QuocTich.Location = new System.Drawing.Point(6, 91);
            this.gridControl_QuocTich.MainView = this.gridView_QuocTich;
            this.gridControl_QuocTich.Name = "gridControl_QuocTich";
            this.gridControl_QuocTich.Size = new System.Drawing.Size(625, 142);
            this.gridControl_QuocTich.TabIndex = 21;
            this.gridControl_QuocTich.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_QuocTich});
            // 
            // gridView_QuocTich
            // 
            this.gridView_QuocTich.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAQUOCTICH,
            this.colTENQUOCTICH});
            this.gridView_QuocTich.GridControl = this.gridControl_QuocTich;
            this.gridView_QuocTich.Name = "gridView_QuocTich";
            // 
            // colMAQUOCTICH
            // 
            this.colMAQUOCTICH.Caption = "Mã quốc tịch";
            this.colMAQUOCTICH.FieldName = "MAQUOCTICH";
            this.colMAQUOCTICH.Name = "colMAQUOCTICH";
            this.colMAQUOCTICH.Visible = true;
            this.colMAQUOCTICH.VisibleIndex = 0;
            // 
            // colTENQUOCTICH
            // 
            this.colTENQUOCTICH.Caption = "Quốc tịch";
            this.colTENQUOCTICH.FieldName = "TENQUOCTICH";
            this.colTENQUOCTICH.Name = "colTENQUOCTICH";
            this.colTENQUOCTICH.Visible = true;
            this.colTENQUOCTICH.VisibleIndex = 1;
            // 
            // btn_Sua_QuocTich
            // 
            this.btn_Sua_QuocTich.Location = new System.Drawing.Point(494, 39);
            this.btn_Sua_QuocTich.Name = "btn_Sua_QuocTich";
            this.btn_Sua_QuocTich.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_QuocTich.TabIndex = 11;
            this.btn_Sua_QuocTich.Text = "Sửa";
            this.btn_Sua_QuocTich.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa_QuocTich
            // 
            this.btn_Xoa_QuocTich.Location = new System.Drawing.Point(413, 39);
            this.btn_Xoa_QuocTich.Name = "btn_Xoa_QuocTich";
            this.btn_Xoa_QuocTich.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_QuocTich.TabIndex = 10;
            this.btn_Xoa_QuocTich.Text = "Xóa";
            this.btn_Xoa_QuocTich.UseVisualStyleBackColor = true;
            // 
            // btn_Them_QuocTich
            // 
            this.btn_Them_QuocTich.Location = new System.Drawing.Point(332, 39);
            this.btn_Them_QuocTich.Name = "btn_Them_QuocTich";
            this.btn_Them_QuocTich.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_QuocTich.TabIndex = 8;
            this.btn_Them_QuocTich.Text = "Thêm";
            this.btn_Them_QuocTich.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 19);
            this.label17.TabIndex = 3;
            this.label17.Text = "Quốc tịch";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = "Mã quốc tịch";
            // 
            // groupBox_TonGiao
            // 
            this.groupBox_TonGiao.Controls.Add(this.mATONGIAOTextEdit);
            this.groupBox_TonGiao.Controls.Add(this.tENTONGIAOTextEdit);
            this.groupBox_TonGiao.Controls.Add(this.gridControl_TonGiao);
            this.groupBox_TonGiao.Controls.Add(this.btn_Sua_TonGiao);
            this.groupBox_TonGiao.Controls.Add(this.btn_Xoa_TonGiao);
            this.groupBox_TonGiao.Controls.Add(this.btn_Them_TonGiao);
            this.groupBox_TonGiao.Controls.Add(this.label19);
            this.groupBox_TonGiao.Controls.Add(this.label20);
            this.groupBox_TonGiao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TonGiao.Location = new System.Drawing.Point(654, 492);
            this.groupBox_TonGiao.Name = "groupBox_TonGiao";
            this.groupBox_TonGiao.Size = new System.Drawing.Size(651, 239);
            this.groupBox_TonGiao.TabIndex = 6;
            this.groupBox_TonGiao.TabStop = false;
            this.groupBox_TonGiao.Text = "Tôn giáo";
            // 
            // gridControl_TonGiao
            // 
            this.gridControl_TonGiao.DataSource = this.tONGIAOBindingSource;
            this.gridControl_TonGiao.Location = new System.Drawing.Point(6, 91);
            this.gridControl_TonGiao.MainView = this.gridView_TonGiao;
            this.gridControl_TonGiao.Name = "gridControl_TonGiao";
            this.gridControl_TonGiao.Size = new System.Drawing.Size(625, 142);
            this.gridControl_TonGiao.TabIndex = 22;
            this.gridControl_TonGiao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_TonGiao});
            // 
            // gridView_TonGiao
            // 
            this.gridView_TonGiao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMATONGIAO,
            this.colTENTONGIAO});
            this.gridView_TonGiao.GridControl = this.gridControl_TonGiao;
            this.gridView_TonGiao.Name = "gridView_TonGiao";
            // 
            // colMATONGIAO
            // 
            this.colMATONGIAO.Caption = "Mã tôn giáo";
            this.colMATONGIAO.FieldName = "MATONGIAO";
            this.colMATONGIAO.Name = "colMATONGIAO";
            this.colMATONGIAO.Visible = true;
            this.colMATONGIAO.VisibleIndex = 0;
            // 
            // colTENTONGIAO
            // 
            this.colTENTONGIAO.Caption = "Tôn giáo";
            this.colTENTONGIAO.FieldName = "TENTONGIAO";
            this.colTENTONGIAO.Name = "colTENTONGIAO";
            this.colTENTONGIAO.Visible = true;
            this.colTENTONGIAO.VisibleIndex = 1;
            // 
            // btn_Sua_TonGiao
            // 
            this.btn_Sua_TonGiao.Location = new System.Drawing.Point(494, 43);
            this.btn_Sua_TonGiao.Name = "btn_Sua_TonGiao";
            this.btn_Sua_TonGiao.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_TonGiao.TabIndex = 11;
            this.btn_Sua_TonGiao.Text = "Sửa";
            this.btn_Sua_TonGiao.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa_TonGiao
            // 
            this.btn_Xoa_TonGiao.Location = new System.Drawing.Point(413, 43);
            this.btn_Xoa_TonGiao.Name = "btn_Xoa_TonGiao";
            this.btn_Xoa_TonGiao.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_TonGiao.TabIndex = 10;
            this.btn_Xoa_TonGiao.Text = "Xóa";
            this.btn_Xoa_TonGiao.UseVisualStyleBackColor = true;
            // 
            // btn_Them_TonGiao
            // 
            this.btn_Them_TonGiao.Location = new System.Drawing.Point(332, 43);
            this.btn_Them_TonGiao.Name = "btn_Them_TonGiao";
            this.btn_Them_TonGiao.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_TonGiao.TabIndex = 8;
            this.btn_Them_TonGiao.Text = "Thêm";
            this.btn_Them_TonGiao.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 19);
            this.label19.TabIndex = 3;
            this.label19.Text = "Tôn giáo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 19);
            this.label20.TabIndex = 0;
            this.label20.Text = "Mã tôn giáo";
            // 
            // groupBox_DanToc
            // 
            this.groupBox_DanToc.Controls.Add(this.mADANTOCTextEdit);
            this.groupBox_DanToc.Controls.Add(this.tENDANTOCTextEdit);
            this.groupBox_DanToc.Controls.Add(this.gridControl_DanToc);
            this.groupBox_DanToc.Controls.Add(this.btn_Sua_DanToc);
            this.groupBox_DanToc.Controls.Add(this.btn_Xoa_DanToc);
            this.groupBox_DanToc.Controls.Add(this.btn_Them_DanToc);
            this.groupBox_DanToc.Controls.Add(this.label21);
            this.groupBox_DanToc.Controls.Add(this.label22);
            this.groupBox_DanToc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DanToc.Location = new System.Drawing.Point(654, 248);
            this.groupBox_DanToc.Name = "groupBox_DanToc";
            this.groupBox_DanToc.Size = new System.Drawing.Size(651, 239);
            this.groupBox_DanToc.TabIndex = 5;
            this.groupBox_DanToc.TabStop = false;
            this.groupBox_DanToc.Text = "Dân tộc";
            // 
            // gridControl_DanToc
            // 
            this.gridControl_DanToc.DataSource = this.dANTOCBindingSource;
            this.gridControl_DanToc.Location = new System.Drawing.Point(6, 90);
            this.gridControl_DanToc.MainView = this.gridView_DanToc;
            this.gridControl_DanToc.Name = "gridControl_DanToc";
            this.gridControl_DanToc.Size = new System.Drawing.Size(625, 143);
            this.gridControl_DanToc.TabIndex = 22;
            this.gridControl_DanToc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DanToc});
            // 
            // gridView_DanToc
            // 
            this.gridView_DanToc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADANTOC,
            this.colTENDANTOC});
            this.gridView_DanToc.GridControl = this.gridControl_DanToc;
            this.gridView_DanToc.Name = "gridView_DanToc";
            // 
            // colMADANTOC
            // 
            this.colMADANTOC.Caption = "Mã dân tộc";
            this.colMADANTOC.FieldName = "MADANTOC";
            this.colMADANTOC.Name = "colMADANTOC";
            this.colMADANTOC.Visible = true;
            this.colMADANTOC.VisibleIndex = 0;
            // 
            // colTENDANTOC
            // 
            this.colTENDANTOC.Caption = "Dân tộc";
            this.colTENDANTOC.FieldName = "TENDANTOC";
            this.colTENDANTOC.Name = "colTENDANTOC";
            this.colTENDANTOC.Visible = true;
            this.colTENDANTOC.VisibleIndex = 1;
            // 
            // btn_Sua_DanToc
            // 
            this.btn_Sua_DanToc.Location = new System.Drawing.Point(494, 34);
            this.btn_Sua_DanToc.Name = "btn_Sua_DanToc";
            this.btn_Sua_DanToc.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_DanToc.TabIndex = 11;
            this.btn_Sua_DanToc.Text = "Sửa";
            this.btn_Sua_DanToc.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa_DanToc
            // 
            this.btn_Xoa_DanToc.Location = new System.Drawing.Point(413, 34);
            this.btn_Xoa_DanToc.Name = "btn_Xoa_DanToc";
            this.btn_Xoa_DanToc.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_DanToc.TabIndex = 10;
            this.btn_Xoa_DanToc.Text = "Xóa";
            this.btn_Xoa_DanToc.UseVisualStyleBackColor = true;
            // 
            // btn_Them_DanToc
            // 
            this.btn_Them_DanToc.Location = new System.Drawing.Point(332, 34);
            this.btn_Them_DanToc.Name = "btn_Them_DanToc";
            this.btn_Them_DanToc.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_DanToc.TabIndex = 8;
            this.btn_Them_DanToc.Text = "Thêm";
            this.btn_Them_DanToc.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 19);
            this.label21.TabIndex = 3;
            this.label21.Text = "Dân tộc";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 19);
            this.label22.TabIndex = 0;
            this.label22.Text = "Mã dân tộc";
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Danh muc Phân Quyền";
            this.tabNavigationPage3.Controls.Add(this.groupBox_NguoiDungNhomNguoiDun);
            this.tabNavigationPage3.Controls.Add(this.groupBox2);
            this.tabNavigationPage3.Controls.Add(this.groupBox1);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1341, 741);
            // 
            // groupBox_NguoiDungNhomNguoiDun
            // 
            this.groupBox_NguoiDungNhomNguoiDun.Controls.Add(this.label23);
            this.groupBox_NguoiDungNhomNguoiDun.Controls.Add(this.nHOMNGUOIDUNGComboBox);
            this.groupBox_NguoiDungNhomNguoiDun.Controls.Add(this.gridControl_NDNND);
            this.groupBox_NguoiDungNhomNguoiDun.Controls.Add(this.gridControl_TaiKhoan);
            this.groupBox_NguoiDungNhomNguoiDun.Controls.Add(this.btn_Them_NDNND);
            this.groupBox_NguoiDungNhomNguoiDun.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_NguoiDungNhomNguoiDun.Location = new System.Drawing.Point(3, 363);
            this.groupBox_NguoiDungNhomNguoiDun.Name = "groupBox_NguoiDungNhomNguoiDun";
            this.groupBox_NguoiDungNhomNguoiDun.Size = new System.Drawing.Size(1039, 276);
            this.groupBox_NguoiDungNhomNguoiDun.TabIndex = 5;
            this.groupBox_NguoiDungNhomNguoiDun.TabStop = false;
            this.groupBox_NguoiDungNhomNguoiDun.Text = "Người dùng nhóm người dùng";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(27, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(118, 19);
            this.label23.TabIndex = 24;
            this.label23.Text = "Nhóm người dùng";
            // 
            // nHOMNGUOIDUNGComboBox
            // 
            this.nHOMNGUOIDUNGComboBox.DisplayMember = "TENNHOM";
            this.nHOMNGUOIDUNGComboBox.FormattingEnabled = true;
            this.nHOMNGUOIDUNGComboBox.Location = new System.Drawing.Point(151, 38);
            this.nHOMNGUOIDUNGComboBox.Name = "nHOMNGUOIDUNGComboBox";
            this.nHOMNGUOIDUNGComboBox.Size = new System.Drawing.Size(280, 27);
            this.nHOMNGUOIDUNGComboBox.TabIndex = 23;
            this.nHOMNGUOIDUNGComboBox.ValueMember = "MANHOM";
            // 
            // gridControl_NDNND
            // 
            this.gridControl_NDNND.DataSource = this.nGUOIDUNGNHOMNGUOIDUNGBindingSource;
            this.gridControl_NDNND.Location = new System.Drawing.Point(597, 67);
            this.gridControl_NDNND.MainView = this.gridView_NDNND;
            this.gridControl_NDNND.Name = "gridControl_NDNND";
            this.gridControl_NDNND.Size = new System.Drawing.Size(400, 200);
            this.gridControl_NDNND.TabIndex = 23;
            this.gridControl_NDNND.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_NDNND});
            // 
            // gridView_NDNND
            // 
            this.gridView_NDNND.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV1,
            this.colMANHOM1,
            this.colGHICHU1});
            this.gridView_NDNND.GridControl = this.gridControl_NDNND;
            this.gridView_NDNND.Name = "gridView_NDNND";
            // 
            // colMANV1
            // 
            this.colMANV1.Caption = "Mã nhân viên";
            this.colMANV1.FieldName = "MANV";
            this.colMANV1.Name = "colMANV1";
            this.colMANV1.Visible = true;
            this.colMANV1.VisibleIndex = 0;
            // 
            // colMANHOM1
            // 
            this.colMANHOM1.Caption = "Mã nhóm";
            this.colMANHOM1.FieldName = "MANHOM";
            this.colMANHOM1.Name = "colMANHOM1";
            this.colMANHOM1.Visible = true;
            this.colMANHOM1.VisibleIndex = 1;
            // 
            // colGHICHU1
            // 
            this.colGHICHU1.Caption = "Ghi chú";
            this.colGHICHU1.FieldName = "GHICHU";
            this.colGHICHU1.Name = "colGHICHU1";
            this.colGHICHU1.Visible = true;
            this.colGHICHU1.VisibleIndex = 2;
            // 
            // gridControl_TaiKhoan
            // 
            this.gridControl_TaiKhoan.DataSource = this.tAIKHOANBindingSource;
            this.gridControl_TaiKhoan.Location = new System.Drawing.Point(31, 71);
            this.gridControl_TaiKhoan.MainView = this.gridView_TaiKhoan;
            this.gridControl_TaiKhoan.Name = "gridControl_TaiKhoan";
            this.gridControl_TaiKhoan.Size = new System.Drawing.Size(400, 200);
            this.gridControl_TaiKhoan.TabIndex = 22;
            this.gridControl_TaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_TaiKhoan});
            // 
            // gridView_TaiKhoan
            // 
            this.gridView_TaiKhoan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colMATKHAU,
            this.colHOATDONG});
            this.gridView_TaiKhoan.GridControl = this.gridControl_TaiKhoan;
            this.gridView_TaiKhoan.Name = "gridView_TaiKhoan";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colMATKHAU
            // 
            this.colMATKHAU.Caption = "Mật khẩu";
            this.colMATKHAU.FieldName = "MATKHAU";
            this.colMATKHAU.Name = "colMATKHAU";
            this.colMATKHAU.Visible = true;
            this.colMATKHAU.VisibleIndex = 1;
            // 
            // colHOATDONG
            // 
            this.colHOATDONG.Caption = "Hoạt động";
            this.colHOATDONG.FieldName = "HOATDONG";
            this.colHOATDONG.Name = "colHOATDONG";
            this.colHOATDONG.Visible = true;
            this.colHOATDONG.VisibleIndex = 2;
            // 
            // btn_Them_NDNND
            // 
            this.btn_Them_NDNND.Location = new System.Drawing.Point(473, 119);
            this.btn_Them_NDNND.Name = "btn_Them_NDNND";
            this.btn_Them_NDNND.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_NDNND.TabIndex = 19;
            this.btn_Them_NDNND.Text = "Thêm";
            this.btn_Them_NDNND.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mAMANHINHTextEdit);
            this.groupBox2.Controls.Add(this.tENMANHINHTextEdit);
            this.groupBox2.Controls.Add(this.gridControl_ManHinh);
            this.groupBox2.Controls.Add(this.btn_Sua_ManHinh);
            this.groupBox2.Controls.Add(this.btn_Xoa_ManHinh);
            this.groupBox2.Controls.Add(this.btn_Them_ManHinh);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(692, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 354);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Màn Hình";
            // 
            // gridControl_ManHinh
            // 
            this.gridControl_ManHinh.DataSource = this.mANHINHBindingSource;
            this.gridControl_ManHinh.Location = new System.Drawing.Point(31, 102);
            this.gridControl_ManHinh.MainView = this.gridView_ManHinh;
            this.gridControl_ManHinh.Name = "gridControl_ManHinh";
            this.gridControl_ManHinh.Size = new System.Drawing.Size(541, 200);
            this.gridControl_ManHinh.TabIndex = 19;
            this.gridControl_ManHinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ManHinh});
            // 
            // gridView_ManHinh
            // 
            this.gridView_ManHinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMANHINH,
            this.colTENMANHINH});
            this.gridView_ManHinh.GridControl = this.gridControl_ManHinh;
            this.gridView_ManHinh.Name = "gridView_ManHinh";
            // 
            // colMAMANHINH
            // 
            this.colMAMANHINH.Caption = "Mã màn hình";
            this.colMAMANHINH.FieldName = "MAMANHINH";
            this.colMAMANHINH.Name = "colMAMANHINH";
            this.colMAMANHINH.Visible = true;
            this.colMAMANHINH.VisibleIndex = 0;
            // 
            // colTENMANHINH
            // 
            this.colTENMANHINH.Caption = "Tên màn hình";
            this.colTENMANHINH.FieldName = "TENMANHINH";
            this.colTENMANHINH.Name = "colTENMANHINH";
            this.colTENMANHINH.Visible = true;
            this.colTENMANHINH.VisibleIndex = 1;
            // 
            // btn_Sua_ManHinh
            // 
            this.btn_Sua_ManHinh.Location = new System.Drawing.Point(497, 45);
            this.btn_Sua_ManHinh.Name = "btn_Sua_ManHinh";
            this.btn_Sua_ManHinh.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_ManHinh.TabIndex = 18;
            this.btn_Sua_ManHinh.Text = "Sửa";
            this.btn_Sua_ManHinh.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa_ManHinh
            // 
            this.btn_Xoa_ManHinh.Location = new System.Drawing.Point(416, 45);
            this.btn_Xoa_ManHinh.Name = "btn_Xoa_ManHinh";
            this.btn_Xoa_ManHinh.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_ManHinh.TabIndex = 17;
            this.btn_Xoa_ManHinh.Text = "Xóa";
            this.btn_Xoa_ManHinh.UseVisualStyleBackColor = true;
            // 
            // btn_Them_ManHinh
            // 
            this.btn_Them_ManHinh.Location = new System.Drawing.Point(335, 45);
            this.btn_Them_ManHinh.Name = "btn_Them_ManHinh";
            this.btn_Them_ManHinh.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_ManHinh.TabIndex = 16;
            this.btn_Them_ManHinh.Text = "Thêm";
            this.btn_Them_ManHinh.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(27, 67);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 19);
            this.label24.TabIndex = 13;
            this.label24.Text = "Tên màn hình";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(27, 33);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 19);
            this.label25.TabIndex = 12;
            this.label25.Text = "Mã màn hình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Controls.Add(this.mANHOMComboBox);
            this.groupBox1.Controls.Add(this.tENNHOMTextEdit);
            this.groupBox1.Controls.Add(this.gHICHUTextEdit);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.btn_Sua_NhomNguoiDung);
            this.groupBox1.Controls.Add(this.btn_Xoa_NhomNguoiDung);
            this.groupBox1.Controls.Add(this.btn_Them_NhomNguoiDung);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 354);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm người dùng";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(27, 102);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 19);
            this.label26.TabIndex = 19;
            this.label26.Text = "Ghi chú";
            // 
            // btn_Sua_NhomNguoiDung
            // 
            this.btn_Sua_NhomNguoiDung.Location = new System.Drawing.Point(494, 62);
            this.btn_Sua_NhomNguoiDung.Name = "btn_Sua_NhomNguoiDung";
            this.btn_Sua_NhomNguoiDung.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_NhomNguoiDung.TabIndex = 18;
            this.btn_Sua_NhomNguoiDung.Text = "Sửa";
            this.btn_Sua_NhomNguoiDung.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa_NhomNguoiDung
            // 
            this.btn_Xoa_NhomNguoiDung.Location = new System.Drawing.Point(413, 62);
            this.btn_Xoa_NhomNguoiDung.Name = "btn_Xoa_NhomNguoiDung";
            this.btn_Xoa_NhomNguoiDung.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_NhomNguoiDung.TabIndex = 17;
            this.btn_Xoa_NhomNguoiDung.Text = "Xóa";
            this.btn_Xoa_NhomNguoiDung.UseVisualStyleBackColor = true;
            // 
            // btn_Them_NhomNguoiDung
            // 
            this.btn_Them_NhomNguoiDung.Location = new System.Drawing.Point(332, 62);
            this.btn_Them_NhomNguoiDung.Name = "btn_Them_NhomNguoiDung";
            this.btn_Them_NhomNguoiDung.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_NhomNguoiDung.TabIndex = 16;
            this.btn_Them_NhomNguoiDung.Text = "Thêm";
            this.btn_Them_NhomNguoiDung.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(27, 67);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 19);
            this.label27.TabIndex = 13;
            this.label27.Text = "Tên nhóm";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(27, 33);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 19);
            this.label28.TabIndex = 12;
            this.label28.Text = "Mã nhóm";
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataMember = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGBindingSource.DataSource = this.dataSetQLNS;
            // 
            // nHOMNGUOIDUNGTableAdapter
            // 
            this.nHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // mANHINHBindingSource
            // 
            this.mANHINHBindingSource.DataMember = "MANHINH";
            this.mANHINHBindingSource.DataSource = this.dataSetQLNS;
            // 
            // mANHINHTableAdapter
            // 
            this.mANHINHTableAdapter.ClearBeforeFill = true;
            // 
            // nGUOIDUNGNHOMNGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGNHOMNGUOIDUNGBindingSource.DataMember = "NGUOIDUNGNHOMNGUOIDUNG";
            this.nGUOIDUNGNHOMNGUOIDUNGBindingSource.DataSource = this.dataSetQLNS;
            // 
            // nGUOIDUNGNHOMNGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNGNHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
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
            // mANHOMComboBox
            // 
            this.mANHOMComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHOMNGUOIDUNGBindingSource, "MANHOM", true));
            this.mANHOMComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANHOMComboBox.FormattingEnabled = true;
            this.mANHOMComboBox.Location = new System.Drawing.Point(117, 26);
            this.mANHOMComboBox.Name = "mANHOMComboBox";
            this.mANHOMComboBox.Size = new System.Drawing.Size(208, 28);
            this.mANHOMComboBox.TabIndex = 22;
            // 
            // tENNHOMTextEdit
            // 
            this.tENNHOMTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHOMNGUOIDUNGBindingSource, "TENNHOM", true));
            this.tENNHOMTextEdit.Location = new System.Drawing.Point(117, 63);
            this.tENNHOMTextEdit.Name = "tENNHOMTextEdit";
            this.tENNHOMTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENNHOMTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENNHOMTextEdit.Size = new System.Drawing.Size(208, 26);
            this.tENNHOMTextEdit.TabIndex = 24;
            // 
            // gHICHUTextEdit
            // 
            this.gHICHUTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHOMNGUOIDUNGBindingSource, "GHICHU", true));
            this.gHICHUTextEdit.Location = new System.Drawing.Point(117, 98);
            this.gHICHUTextEdit.Name = "gHICHUTextEdit";
            this.gHICHUTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gHICHUTextEdit.Properties.Appearance.Options.UseFont = true;
            this.gHICHUTextEdit.Size = new System.Drawing.Size(208, 26);
            this.gHICHUTextEdit.TabIndex = 26;
            // 
            // cHUCVUBindingSource
            // 
            this.cHUCVUBindingSource.DataMember = "CHUCVU";
            this.cHUCVUBindingSource.DataSource = this.dataSetQLNS;
            // 
            // cHUCVUTableAdapter
            // 
            this.cHUCVUTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.nHOMNGUOIDUNGBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(7, 136);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(582, 212);
            this.gridControl1.TabIndex = 27;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANHOM,
            this.colTENNHOM,
            this.colGHICHU});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colMANHOM
            // 
            this.colMANHOM.FieldName = "MANHOM";
            this.colMANHOM.Name = "colMANHOM";
            this.colMANHOM.Visible = true;
            this.colMANHOM.VisibleIndex = 0;
            // 
            // colTENNHOM
            // 
            this.colTENNHOM.FieldName = "TENNHOM";
            this.colTENNHOM.Name = "colTENNHOM";
            this.colTENNHOM.Visible = true;
            this.colTENNHOM.VisibleIndex = 1;
            // 
            // colGHICHU
            // 
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 2;
            // 
            // qUOCTICHBindingSource
            // 
            this.qUOCTICHBindingSource.DataMember = "QUOCTICH";
            this.qUOCTICHBindingSource.DataSource = this.dataSetQLNS;
            // 
            // qUOCTICHTableAdapter
            // 
            this.qUOCTICHTableAdapter.ClearBeforeFill = true;
            // 
            // tONGIAOBindingSource
            // 
            this.tONGIAOBindingSource.DataMember = "TONGIAO";
            this.tONGIAOBindingSource.DataSource = this.dataSetQLNS;
            // 
            // tONGIAOTableAdapter
            // 
            this.tONGIAOTableAdapter.ClearBeforeFill = true;
            // 
            // pHONGBANBindingSource
            // 
            this.pHONGBANBindingSource.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource.DataSource = this.dataSetQLNS;
            // 
            // pHONGBANTableAdapter
            // 
            this.pHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // dANTOCBindingSource
            // 
            this.dANTOCBindingSource.DataMember = "DANTOC";
            this.dANTOCBindingSource.DataSource = this.dataSetQLNS;
            // 
            // dANTOCTableAdapter
            // 
            this.dANTOCTableAdapter.ClearBeforeFill = true;
            // 
            // mAMANHINHTextEdit
            // 
            this.mAMANHINHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mANHINHBindingSource, "MAMANHINH", true));
            this.mAMANHINHTextEdit.Location = new System.Drawing.Point(122, 29);
            this.mAMANHINHTextEdit.Name = "mAMANHINHTextEdit";
            this.mAMANHINHTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAMANHINHTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mAMANHINHTextEdit.Size = new System.Drawing.Size(207, 26);
            this.mAMANHINHTextEdit.TabIndex = 20;
            // 
            // tENMANHINHTextEdit
            // 
            this.tENMANHINHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mANHINHBindingSource, "TENMANHINH", true));
            this.tENMANHINHTextEdit.Location = new System.Drawing.Point(122, 64);
            this.tENMANHINHTextEdit.Name = "tENMANHINHTextEdit";
            this.tENMANHINHTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENMANHINHTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENMANHINHTextEdit.Size = new System.Drawing.Size(207, 26);
            this.tENMANHINHTextEdit.TabIndex = 22;
            // 
            // mAPHONGBANTextEdit
            // 
            this.mAPHONGBANTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHONGBANBindingSource, "MAPHONGBAN", true));
            this.mAPHONGBANTextEdit.Location = new System.Drawing.Point(149, 34);
            this.mAPHONGBANTextEdit.Name = "mAPHONGBANTextEdit";
            this.mAPHONGBANTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAPHONGBANTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mAPHONGBANTextEdit.Size = new System.Drawing.Size(202, 26);
            this.mAPHONGBANTextEdit.TabIndex = 26;
            // 
            // tENPHONGBANTextEdit
            // 
            this.tENPHONGBANTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHONGBANBindingSource, "TENPHONGBAN", true));
            this.tENPHONGBANTextEdit.Location = new System.Drawing.Point(149, 66);
            this.tENPHONGBANTextEdit.Name = "tENPHONGBANTextEdit";
            this.tENPHONGBANTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENPHONGBANTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENPHONGBANTextEdit.Size = new System.Drawing.Size(202, 26);
            this.tENPHONGBANTextEdit.TabIndex = 28;
            // 
            // mATRUONGPHONGTextEdit
            // 
            this.mATRUONGPHONGTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHONGBANBindingSource, "MATRUONGPHONG", true));
            this.mATRUONGPHONGTextEdit.Location = new System.Drawing.Point(149, 98);
            this.mATRUONGPHONGTextEdit.Name = "mATRUONGPHONGTextEdit";
            this.mATRUONGPHONGTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mATRUONGPHONGTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mATRUONGPHONGTextEdit.Size = new System.Drawing.Size(202, 26);
            this.mATRUONGPHONGTextEdit.TabIndex = 30;
            // 
            // mATONGIAOTextEdit
            // 
            this.mATONGIAOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tONGIAOBindingSource, "MATONGIAO", true));
            this.mATONGIAOTextEdit.Location = new System.Drawing.Point(124, 24);
            this.mATONGIAOTextEdit.Name = "mATONGIAOTextEdit";
            this.mATONGIAOTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mATONGIAOTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mATONGIAOTextEdit.Size = new System.Drawing.Size(202, 26);
            this.mATONGIAOTextEdit.TabIndex = 23;
            // 
            // tENTONGIAOTextEdit
            // 
            this.tENTONGIAOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tONGIAOBindingSource, "TENTONGIAO", true));
            this.tENTONGIAOTextEdit.Location = new System.Drawing.Point(124, 56);
            this.tENTONGIAOTextEdit.Name = "tENTONGIAOTextEdit";
            this.tENTONGIAOTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENTONGIAOTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENTONGIAOTextEdit.Size = new System.Drawing.Size(202, 26);
            this.tENTONGIAOTextEdit.TabIndex = 25;
            // 
            // mADANTOCTextEdit
            // 
            this.mADANTOCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dANTOCBindingSource, "MADANTOC", true));
            this.mADANTOCTextEdit.Location = new System.Drawing.Point(105, 24);
            this.mADANTOCTextEdit.Name = "mADANTOCTextEdit";
            this.mADANTOCTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mADANTOCTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mADANTOCTextEdit.Size = new System.Drawing.Size(221, 26);
            this.mADANTOCTextEdit.TabIndex = 23;
            // 
            // tENDANTOCTextEdit
            // 
            this.tENDANTOCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dANTOCBindingSource, "TENDANTOC", true));
            this.tENDANTOCTextEdit.Location = new System.Drawing.Point(105, 57);
            this.tENDANTOCTextEdit.Name = "tENDANTOCTextEdit";
            this.tENDANTOCTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENDANTOCTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENDANTOCTextEdit.Size = new System.Drawing.Size(221, 26);
            this.tENDANTOCTextEdit.TabIndex = 25;
            // 
            // mAQUOCTICHTextEdit
            // 
            this.mAQUOCTICHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qUOCTICHBindingSource, "MAQUOCTICH", true));
            this.mAQUOCTICHTextEdit.Location = new System.Drawing.Point(115, 26);
            this.mAQUOCTICHTextEdit.Name = "mAQUOCTICHTextEdit";
            this.mAQUOCTICHTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAQUOCTICHTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mAQUOCTICHTextEdit.Size = new System.Drawing.Size(211, 26);
            this.mAQUOCTICHTextEdit.TabIndex = 22;
            // 
            // tENQUOCTICHTextEdit
            // 
            this.tENQUOCTICHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qUOCTICHBindingSource, "TENQUOCTICH", true));
            this.tENQUOCTICHTextEdit.Location = new System.Drawing.Point(115, 59);
            this.tENQUOCTICHTextEdit.Name = "tENQUOCTICHTextEdit";
            this.tENQUOCTICHTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENQUOCTICHTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENQUOCTICHTextEdit.Size = new System.Drawing.Size(211, 26);
            this.tENQUOCTICHTextEdit.TabIndex = 24;
            // 
            // mACHUCVUTextEdit
            // 
            this.mACHUCVUTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cHUCVUBindingSource, "MACHUCVU", true));
            this.mACHUCVUTextEdit.Location = new System.Drawing.Point(110, 21);
            this.mACHUCVUTextEdit.Name = "mACHUCVUTextEdit";
            this.mACHUCVUTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mACHUCVUTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mACHUCVUTextEdit.Size = new System.Drawing.Size(230, 26);
            this.mACHUCVUTextEdit.TabIndex = 23;
            // 
            // tENCHUCVUTextEdit
            // 
            this.tENCHUCVUTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cHUCVUBindingSource, "TENCHUCVU", true));
            this.tENCHUCVUTextEdit.Location = new System.Drawing.Point(110, 55);
            this.tENCHUCVUTextEdit.Name = "tENCHUCVUTextEdit";
            this.tENCHUCVUTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENCHUCVUTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENCHUCVUTextEdit.Size = new System.Drawing.Size(230, 26);
            this.tENCHUCVUTextEdit.TabIndex = 25;
            // 
            // frm_NhapLieu_KT_KL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "frm_NhapLieu_KT_KL";
            this.Size = new System.Drawing.Size(1346, 768);
            this.Load += new System.EventHandler(this.frm_NhapLieu_KT_KL_Load);
            this.groupBox_KhenThuong.ResumeLayout(false);
            this.groupBox_KhenThuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KhenThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIKHENTHUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_KhenThuong)).EndInit();
            this.groupBox_KyLuat.ResumeLayout(false);
            this.groupBox_KyLuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KyLuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_KYLUATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_KyLuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAOTAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCTANGCABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.groupBox_DanhMucTangCa.ResumeLayout(false);
            this.groupBox_DanhMucTangCa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DMTangCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DMTangCa)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox_PhongBan.ResumeLayout(false);
            this.groupBox_PhongBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PhongBan)).EndInit();
            this.groupBox_ChucVu.ResumeLayout(false);
            this.groupBox_ChucVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox_QuocTich.ResumeLayout(false);
            this.groupBox_QuocTich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuocTich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_QuocTich)).EndInit();
            this.groupBox_TonGiao.ResumeLayout(false);
            this.groupBox_TonGiao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TonGiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TonGiao)).EndInit();
            this.groupBox_DanToc.ResumeLayout(false);
            this.groupBox_DanToc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanToc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DanToc)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            this.groupBox_NguoiDungNhomNguoiDun.ResumeLayout(false);
            this.groupBox_NguoiDungNhomNguoiDun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NDNND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_NDNND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TaiKhoan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ManHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ManHinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANHINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGNHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENNHOMTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHICHUTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUOCTICHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGIAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANTOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMANHINHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMANHINHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAPHONGBANTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENPHONGBANTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATRUONGPHONGTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATONGIAOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTONGIAOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mADANTOCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENDANTOCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAQUOCTICHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENQUOCTICHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACHUCVUTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENCHUCVUTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Sua_KyLuat;
        private System.Windows.Forms.Button btn_Xoa_KyLuat;
        private System.Windows.Forms.Button btn_Them_KyLuat;
        private System.Windows.Forms.TextBox txt_TenKyLuat;
        private System.Windows.Forms.TextBox txt_MaKyLuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_KhenThuong;
        private System.Windows.Forms.Button btn_Sua_KhenThuong;
        private System.Windows.Forms.Button btn_Xoa_KhenThuong;
        private System.Windows.Forms.Button btn_Them_KhenThuong;
        private System.Windows.Forms.TextBox txt_LoaiKhenThuong;
        private System.Windows.Forms.TextBox txt_MaKhenThuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_KyLuat;
        private DevExpress.XtraGrid.GridControl gridControl_KhenThuong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_KhenThuong;
        private DataSetQLNS dataSetQLNS;
        private System.Windows.Forms.BindingSource lOAIKHENTHUONGBindingSource;
        private DataSetQLNSTableAdapters.LOAIKHENTHUONGTableAdapter lOAIKHENTHUONGTableAdapter;
        private DataSetQLNSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAIKHENTHUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAITENKHENTHUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colTIENTHUONG;
        private System.Windows.Forms.TextBox txt_TienThuong;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.GridControl gridControl_KyLuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_KyLuat;
        private System.Windows.Forms.TextBox txt_TienKyLuat;
        private System.Windows.Forms.TextBox txt_HinhThuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource dS_KYLUATBindingSource;
        private DataSetQLNSTableAdapters.DS_KYLUATTableAdapter dS_KYLUATTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKYLUAT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKYLUAT;
        private DevExpress.XtraGrid.Columns.GridColumn colHINHTHUC;
        private DevExpress.XtraGrid.Columns.GridColumn colTIENKYLUAT;
        private System.Windows.Forms.BindingSource dAOTAOBindingSource;
        private DataSetQLNSTableAdapters.DAOTAOTableAdapter dAOTAOTableAdapter;
        private System.Windows.Forms.BindingSource dANHMUCTANGCABindingSource;
        private DataSetQLNSTableAdapters.DANHMUCTANGCATableAdapter dANHMUCTANGCATableAdapter;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private System.Windows.Forms.GroupBox groupBox_DanhMucTangCa;
        private DevExpress.XtraGrid.GridControl gridControl_DMTangCa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DMTangCa;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAICA;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAICA;
        private DevExpress.XtraGrid.Columns.GridColumn colHESO;
        private DevExpress.XtraGrid.Columns.GridColumn colSOGIOTANGCA;
        private System.Windows.Forms.Button btn_Sua_DMTC;
        private System.Windows.Forms.Button btn_Xoa_DMTC;
        private System.Windows.Forms.Button btn_Them_DMTC;
        private System.Windows.Forms.TextBox txt_SoGioTangCa;
        private System.Windows.Forms.TextBox txt_HeSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TenLoaiCa;
        private System.Windows.Forms.TextBox txt_MaLoaiCa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.GroupBox groupBox_PhongBan;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraGrid.GridControl gridControl_PhongBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_PhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONGBAN;
        private DevExpress.XtraGrid.Columns.GridColumn colTENPHONGBAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMATRUONGPHONG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Sua_PhongBan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Xoa_PhongBan;
        private System.Windows.Forms.Button btn_Them_PhongBan;
        private System.Windows.Forms.GroupBox groupBox_ChucVu;
        private DevExpress.XtraGrid.GridControl gridControl_ChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACHUCVU;
        private DevExpress.XtraGrid.Columns.GridColumn colTENCHUCVU;
        private System.Windows.Forms.Button btn_Sua_ChucVu;
        private System.Windows.Forms.Button btn_Xoa_ChucVu;
        private System.Windows.Forms.Button btn_Them_ChucVu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox_QuocTich;
        private DevExpress.XtraGrid.GridControl gridControl_QuocTich;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_QuocTich;
        private DevExpress.XtraGrid.Columns.GridColumn colMAQUOCTICH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENQUOCTICH;
        private System.Windows.Forms.Button btn_Sua_QuocTich;
        private System.Windows.Forms.Button btn_Xoa_QuocTich;
        private System.Windows.Forms.Button btn_Them_QuocTich;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox_TonGiao;
        private DevExpress.XtraGrid.GridControl gridControl_TonGiao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_TonGiao;
        private DevExpress.XtraGrid.Columns.GridColumn colMATONGIAO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTONGIAO;
        private System.Windows.Forms.Button btn_Sua_TonGiao;
        private System.Windows.Forms.Button btn_Xoa_TonGiao;
        private System.Windows.Forms.Button btn_Them_TonGiao;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox_DanToc;
        private DevExpress.XtraGrid.GridControl gridControl_DanToc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DanToc;
        private DevExpress.XtraGrid.Columns.GridColumn colMADANTOC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENDANTOC;
        private System.Windows.Forms.Button btn_Sua_DanToc;
        private System.Windows.Forms.Button btn_Xoa_DanToc;
        private System.Windows.Forms.Button btn_Them_DanToc;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private System.Windows.Forms.GroupBox groupBox_NguoiDungNhomNguoiDun;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox nHOMNGUOIDUNGComboBox;
        private DevExpress.XtraGrid.GridControl gridControl_NDNND;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_NDNND;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHOM1;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU1;
        private DevExpress.XtraGrid.GridControl gridControl_TaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_TaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMATKHAU;
        private DevExpress.XtraGrid.Columns.GridColumn colHOATDONG;
        private System.Windows.Forms.Button btn_Them_NDNND;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl_ManHinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ManHinh;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMANHINH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMANHINH;
        private System.Windows.Forms.Button btn_Sua_ManHinh;
        private System.Windows.Forms.Button btn_Xoa_ManHinh;
        private System.Windows.Forms.Button btn_Them_ManHinh;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btn_Sua_NhomNguoiDung;
        private System.Windows.Forms.Button btn_Xoa_NhomNguoiDung;
        private System.Windows.Forms.Button btn_Them_NhomNguoiDung;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private DataSetQLNSTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter;
        private System.Windows.Forms.BindingSource mANHINHBindingSource;
        private DataSetQLNSTableAdapters.MANHINHTableAdapter mANHINHTableAdapter;
        private System.Windows.Forms.BindingSource nGUOIDUNGNHOMNGUOIDUNGBindingSource;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private DataSetQLNSTableAdapters.NGUOIDUNGNHOMNGUOIDUNGTableAdapter nGUOIDUNGNHOMNGUOIDUNGTableAdapter;
        private DataSetQLNSTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private System.Windows.Forms.ComboBox mANHOMComboBox;
        private DevExpress.XtraEditors.TextEdit tENNHOMTextEdit;
        private DevExpress.XtraEditors.TextEdit gHICHUTextEdit;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private DataSetQLNSTableAdapters.CHUCVUTableAdapter cHUCVUTableAdapter;
        private System.Windows.Forms.BindingSource qUOCTICHBindingSource;
        private DataSetQLNSTableAdapters.QUOCTICHTableAdapter qUOCTICHTableAdapter;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        private System.Windows.Forms.BindingSource tONGIAOBindingSource;
        private System.Windows.Forms.BindingSource dANTOCBindingSource;
        private DataSetQLNSTableAdapters.TONGIAOTableAdapter tONGIAOTableAdapter;
        private DataSetQLNSTableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
        private DataSetQLNSTableAdapters.DANTOCTableAdapter dANTOCTableAdapter;
        private DevExpress.XtraEditors.TextEdit mAMANHINHTextEdit;
        private DevExpress.XtraEditors.TextEdit tENMANHINHTextEdit;
        private DevExpress.XtraEditors.TextEdit mAPHONGBANTextEdit;
        private DevExpress.XtraEditors.TextEdit tENPHONGBANTextEdit;
        private DevExpress.XtraEditors.TextEdit mATRUONGPHONGTextEdit;
        private DevExpress.XtraEditors.TextEdit mAQUOCTICHTextEdit;
        private DevExpress.XtraEditors.TextEdit tENQUOCTICHTextEdit;
        private DevExpress.XtraEditors.TextEdit mATONGIAOTextEdit;
        private DevExpress.XtraEditors.TextEdit tENTONGIAOTextEdit;
        private DevExpress.XtraEditors.TextEdit mADANTOCTextEdit;
        private DevExpress.XtraEditors.TextEdit tENDANTOCTextEdit;
        private DevExpress.XtraEditors.TextEdit mACHUCVUTextEdit;
        private DevExpress.XtraEditors.TextEdit tENCHUCVUTextEdit;
    }
}