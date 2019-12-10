namespace QuanLy_NhanSu
{
    partial class frm_NhapLieu
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
            this.dANTOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetQLNS = new QuanLy_NhanSu.DataSetQLNS();
            this.tONGIAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUOCTICHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUCVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dANTOCTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.DANTOCTableAdapter();
            this.pHONGBANTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.PHONGBANTableAdapter();
            this.qUOCTICHTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.QUOCTICHTableAdapter();
            this.tONGIAOTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.TONGIAOTableAdapter();
            this.tableAdapterManager = new QuanLy_NhanSu.DataSetQLNSTableAdapters.TableAdapterManager();
            this.cHUCVUTableAdapter = new QuanLy_NhanSu.DataSetQLNSTableAdapters.CHUCVUTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaDanToc = new System.Windows.Forms.TextBox();
            this.txt_TenDanToc = new System.Windows.Forms.TextBox();
            this.btn_Them_DanToc = new System.Windows.Forms.Button();
            this.btn_Xoa_DanToc = new System.Windows.Forms.Button();
            this.btn_Sua_DanToc = new System.Windows.Forms.Button();
            this.gridControl_DanToc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView_DanToc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADANTOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENDANTOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox_DanToc = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_MaTonGiao = new System.Windows.Forms.TextBox();
            this.txt_TenTonGiao = new System.Windows.Forms.TextBox();
            this.btn_Them_TonGiao = new System.Windows.Forms.Button();
            this.btn_Xoa_TonGiao = new System.Windows.Forms.Button();
            this.btn_Sua_TonGiao = new System.Windows.Forms.Button();
            this.gridControl_TonGiao = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView_TonGiao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMATONGIAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTONGIAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox_TonGiao = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaQuocTich = new System.Windows.Forms.TextBox();
            this.txt_TenQuocTich = new System.Windows.Forms.TextBox();
            this.btn_Them_QuocTich = new System.Windows.Forms.Button();
            this.btn_Xoa_QuocTich = new System.Windows.Forms.Button();
            this.btn_Sua_QuocTich = new System.Windows.Forms.Button();
            this.gridControl_QuocTich = new DevExpress.XtraGrid.GridControl();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView_QuocTich = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAQUOCTICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENQUOCTICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox_QuocTich = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaCV = new System.Windows.Forms.TextBox();
            this.txt_TenCV = new System.Windows.Forms.TextBox();
            this.btn_Them_ChucVu = new System.Windows.Forms.Button();
            this.btn_Xoa_ChucVu = new System.Windows.Forms.Button();
            this.btn_Sua_ChucVu = new System.Windows.Forms.Button();
            this.gridControl_ChucVu = new DevExpress.XtraGrid.GridControl();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMACHUCVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENCHUCVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox_ChucVu = new System.Windows.Forms.GroupBox();
            this.btn_Them_PhongBan = new System.Windows.Forms.Button();
            this.txt_MaPhongBan = new System.Windows.Forms.TextBox();
            this.btn_Xoa_PhongBan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Sua_PhongBan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TenPhongBan = new System.Windows.Forms.TextBox();
            this.gridControl_PhongBan = new DevExpress.XtraGrid.GridControl();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView_PhongBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPHONGBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENPHONGBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATRUONGPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_MaTruongPhong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_PhongBan = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dANTOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGIAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUOCTICHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanToc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DanToc)).BeginInit();
            this.groupBox_DanToc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TonGiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TonGiao)).BeginInit();
            this.groupBox_TonGiao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuocTich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_QuocTich)).BeginInit();
            this.groupBox_QuocTich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            this.groupBox_ChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PhongBan)).BeginInit();
            this.groupBox_PhongBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dANTOCBindingSource
            // 
            this.dANTOCBindingSource.DataMember = "DANTOC";
            this.dANTOCBindingSource.DataSource = this.dataSetQLNS;
            // 
            // dataSetQLNS
            // 
            this.dataSetQLNS.DataSetName = "DataSetQLNS";
            this.dataSetQLNS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tONGIAOBindingSource
            // 
            this.tONGIAOBindingSource.DataMember = "TONGIAO";
            this.tONGIAOBindingSource.DataSource = this.dataSetQLNS;
            // 
            // qUOCTICHBindingSource
            // 
            this.qUOCTICHBindingSource.DataMember = "QUOCTICH";
            this.qUOCTICHBindingSource.DataSource = this.dataSetQLNS;
            // 
            // cHUCVUBindingSource
            // 
            this.cHUCVUBindingSource.DataMember = "CHUCVU";
            this.cHUCVUBindingSource.DataSource = this.dataSetQLNS;
            // 
            // pHONGBANBindingSource
            // 
            this.pHONGBANBindingSource.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource.DataSource = this.dataSetQLNS;
            // 
            // dANTOCTableAdapter
            // 
            this.dANTOCTableAdapter.ClearBeforeFill = true;
            // 
            // pHONGBANTableAdapter
            // 
            this.pHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // qUOCTICHTableAdapter
            // 
            this.qUOCTICHTableAdapter.ClearBeforeFill = true;
            // 
            // tONGIAOTableAdapter
            // 
            this.tONGIAOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DANTOCTableAdapter = this.dANTOCTableAdapter;
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
            this.tableAdapterManager.PHONGBANTableAdapter = this.pHONGBANTableAdapter;
            this.tableAdapterManager.QUANLYKYLUATTableAdapter = null;
            this.tableAdapterManager.QUANLYNGHIVIECTableAdapter = null;
            this.tableAdapterManager.QUANLYTHAISANTableAdapter = null;
            this.tableAdapterManager.QUOCTICHTableAdapter = this.qUOCTICHTableAdapter;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.TONGIAOTableAdapter = this.tONGIAOTableAdapter;
            this.tableAdapterManager.TONGLUONGTableAdapter = null;
            this.tableAdapterManager.TRINHDOHOCVANTableAdapter = null;
            this.tableAdapterManager.TRINHDOTINHOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLy_NhanSu.DataSetQLNSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cHUCVUTableAdapter
            // 
            this.cHUCVUTableAdapter.ClearBeforeFill = true;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl_TonGiao;
            this.gridView2.Name = "gridView2";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl_QuocTich;
            this.gridView3.Name = "gridView3";
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControl_ChucVu;
            this.gridView4.Name = "gridView4";
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.gridControl_PhongBan;
            this.gridView5.Name = "gridView5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dân tộc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dân tộc";
            // 
            // txt_MaDanToc
            // 
            this.txt_MaDanToc.Location = new System.Drawing.Point(106, 24);
            this.txt_MaDanToc.Name = "txt_MaDanToc";
            this.txt_MaDanToc.Size = new System.Drawing.Size(199, 26);
            this.txt_MaDanToc.TabIndex = 6;
            // 
            // txt_TenDanToc
            // 
            this.txt_TenDanToc.Location = new System.Drawing.Point(106, 58);
            this.txt_TenDanToc.Name = "txt_TenDanToc";
            this.txt_TenDanToc.Size = new System.Drawing.Size(199, 26);
            this.txt_TenDanToc.TabIndex = 7;
            // 
            // btn_Them_DanToc
            // 
            this.btn_Them_DanToc.Location = new System.Drawing.Point(332, 34);
            this.btn_Them_DanToc.Name = "btn_Them_DanToc";
            this.btn_Them_DanToc.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_DanToc.TabIndex = 8;
            this.btn_Them_DanToc.Text = "Thêm";
            this.btn_Them_DanToc.UseVisualStyleBackColor = true;
            this.btn_Them_DanToc.Click += new System.EventHandler(this.btn_Them_DanToc_Click);
            // 
            // btn_Xoa_DanToc
            // 
            this.btn_Xoa_DanToc.Location = new System.Drawing.Point(413, 34);
            this.btn_Xoa_DanToc.Name = "btn_Xoa_DanToc";
            this.btn_Xoa_DanToc.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_DanToc.TabIndex = 10;
            this.btn_Xoa_DanToc.Text = "Xóa";
            this.btn_Xoa_DanToc.UseVisualStyleBackColor = true;
            this.btn_Xoa_DanToc.Click += new System.EventHandler(this.btn_Xoa_DanToc_Click);
            // 
            // btn_Sua_DanToc
            // 
            this.btn_Sua_DanToc.Location = new System.Drawing.Point(494, 34);
            this.btn_Sua_DanToc.Name = "btn_Sua_DanToc";
            this.btn_Sua_DanToc.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_DanToc.TabIndex = 11;
            this.btn_Sua_DanToc.Text = "Sửa";
            this.btn_Sua_DanToc.UseVisualStyleBackColor = true;
            this.btn_Sua_DanToc.Click += new System.EventHandler(this.btn_Sua_DanToc_Click);
            // 
            // gridControl_DanToc
            // 
            this.gridControl_DanToc.DataSource = this.dANTOCBindingSource;
            this.gridControl_DanToc.Location = new System.Drawing.Point(24, 90);
            this.gridControl_DanToc.MainView = this.gridView_DanToc;
            this.gridControl_DanToc.Name = "gridControl_DanToc";
            this.gridControl_DanToc.Size = new System.Drawing.Size(557, 117);
            this.gridControl_DanToc.TabIndex = 22;
            this.gridControl_DanToc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DanToc});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMACHUCVU,
            this.colTENCHUCVU});
            this.gridView1.GridControl = this.gridControl_ChucVu;
            this.gridView1.Name = "gridView1";
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
            // groupBox_DanToc
            // 
            this.groupBox_DanToc.Controls.Add(this.gridControl_DanToc);
            this.groupBox_DanToc.Controls.Add(this.btn_Sua_DanToc);
            this.groupBox_DanToc.Controls.Add(this.btn_Xoa_DanToc);
            this.groupBox_DanToc.Controls.Add(this.btn_Them_DanToc);
            this.groupBox_DanToc.Controls.Add(this.txt_TenDanToc);
            this.groupBox_DanToc.Controls.Add(this.txt_MaDanToc);
            this.groupBox_DanToc.Controls.Add(this.label4);
            this.groupBox_DanToc.Controls.Add(this.label1);
            this.groupBox_DanToc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DanToc.Location = new System.Drawing.Point(693, 260);
            this.groupBox_DanToc.Name = "groupBox_DanToc";
            this.groupBox_DanToc.Size = new System.Drawing.Size(607, 225);
            this.groupBox_DanToc.TabIndex = 0;
            this.groupBox_DanToc.TabStop = false;
            this.groupBox_DanToc.Text = "Dân tộc";
            this.groupBox_DanToc.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã tôn giáo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tôn giáo";
            // 
            // txt_MaTonGiao
            // 
            this.txt_MaTonGiao.Location = new System.Drawing.Point(122, 25);
            this.txt_MaTonGiao.Name = "txt_MaTonGiao";
            this.txt_MaTonGiao.Size = new System.Drawing.Size(199, 26);
            this.txt_MaTonGiao.TabIndex = 6;
            // 
            // txt_TenTonGiao
            // 
            this.txt_TenTonGiao.Location = new System.Drawing.Point(122, 59);
            this.txt_TenTonGiao.Name = "txt_TenTonGiao";
            this.txt_TenTonGiao.Size = new System.Drawing.Size(199, 26);
            this.txt_TenTonGiao.TabIndex = 7;
            // 
            // btn_Them_TonGiao
            // 
            this.btn_Them_TonGiao.Location = new System.Drawing.Point(332, 43);
            this.btn_Them_TonGiao.Name = "btn_Them_TonGiao";
            this.btn_Them_TonGiao.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_TonGiao.TabIndex = 8;
            this.btn_Them_TonGiao.Text = "Thêm";
            this.btn_Them_TonGiao.UseVisualStyleBackColor = true;
            this.btn_Them_TonGiao.Click += new System.EventHandler(this.btn_Them_TonGiao_Click);
            // 
            // btn_Xoa_TonGiao
            // 
            this.btn_Xoa_TonGiao.Location = new System.Drawing.Point(413, 43);
            this.btn_Xoa_TonGiao.Name = "btn_Xoa_TonGiao";
            this.btn_Xoa_TonGiao.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_TonGiao.TabIndex = 10;
            this.btn_Xoa_TonGiao.Text = "Xóa";
            this.btn_Xoa_TonGiao.UseVisualStyleBackColor = true;
            this.btn_Xoa_TonGiao.Click += new System.EventHandler(this.btn_Xoa_TonGiao_Click);
            // 
            // btn_Sua_TonGiao
            // 
            this.btn_Sua_TonGiao.Location = new System.Drawing.Point(494, 43);
            this.btn_Sua_TonGiao.Name = "btn_Sua_TonGiao";
            this.btn_Sua_TonGiao.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_TonGiao.TabIndex = 11;
            this.btn_Sua_TonGiao.Text = "Sửa";
            this.btn_Sua_TonGiao.UseVisualStyleBackColor = true;
            this.btn_Sua_TonGiao.Click += new System.EventHandler(this.btn_Sua_TonGiao_Click);
            // 
            // gridControl_TonGiao
            // 
            this.gridControl_TonGiao.DataSource = this.tONGIAOBindingSource;
            this.gridControl_TonGiao.Location = new System.Drawing.Point(24, 91);
            this.gridControl_TonGiao.MainView = this.gridView_TonGiao;
            this.gridControl_TonGiao.Name = "gridControl_TonGiao";
            this.gridControl_TonGiao.Size = new System.Drawing.Size(557, 117);
            this.gridControl_TonGiao.TabIndex = 22;
            this.gridControl_TonGiao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_TonGiao});
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.gridControl_TonGiao;
            this.gridView6.Name = "gridView6";
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
            // groupBox_TonGiao
            // 
            this.groupBox_TonGiao.Controls.Add(this.gridControl_TonGiao);
            this.groupBox_TonGiao.Controls.Add(this.btn_Sua_TonGiao);
            this.groupBox_TonGiao.Controls.Add(this.btn_Xoa_TonGiao);
            this.groupBox_TonGiao.Controls.Add(this.btn_Them_TonGiao);
            this.groupBox_TonGiao.Controls.Add(this.txt_TenTonGiao);
            this.groupBox_TonGiao.Controls.Add(this.txt_MaTonGiao);
            this.groupBox_TonGiao.Controls.Add(this.label9);
            this.groupBox_TonGiao.Controls.Add(this.label12);
            this.groupBox_TonGiao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TonGiao.Location = new System.Drawing.Point(693, 504);
            this.groupBox_TonGiao.Name = "groupBox_TonGiao";
            this.groupBox_TonGiao.Size = new System.Drawing.Size(607, 225);
            this.groupBox_TonGiao.TabIndex = 1;
            this.groupBox_TonGiao.TabStop = false;
            this.groupBox_TonGiao.Text = "Tôn giáo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã quốc tịch";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quốc tịch";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_MaQuocTich
            // 
            this.txt_MaQuocTich.Location = new System.Drawing.Point(106, 22);
            this.txt_MaQuocTich.Name = "txt_MaQuocTich";
            this.txt_MaQuocTich.Size = new System.Drawing.Size(199, 26);
            this.txt_MaQuocTich.TabIndex = 6;
            this.txt_MaQuocTich.TextChanged += new System.EventHandler(this.txt_MaQuocTich_TextChanged);
            // 
            // txt_TenQuocTich
            // 
            this.txt_TenQuocTich.Location = new System.Drawing.Point(106, 56);
            this.txt_TenQuocTich.Name = "txt_TenQuocTich";
            this.txt_TenQuocTich.Size = new System.Drawing.Size(199, 26);
            this.txt_TenQuocTich.TabIndex = 7;
            this.txt_TenQuocTich.TextChanged += new System.EventHandler(this.txt_TenQuocTich_TextChanged);
            // 
            // btn_Them_QuocTich
            // 
            this.btn_Them_QuocTich.Location = new System.Drawing.Point(332, 39);
            this.btn_Them_QuocTich.Name = "btn_Them_QuocTich";
            this.btn_Them_QuocTich.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_QuocTich.TabIndex = 8;
            this.btn_Them_QuocTich.Text = "Thêm";
            this.btn_Them_QuocTich.UseVisualStyleBackColor = true;
            this.btn_Them_QuocTich.Click += new System.EventHandler(this.btn_Them_QuocTich_Click);
            // 
            // btn_Xoa_QuocTich
            // 
            this.btn_Xoa_QuocTich.Location = new System.Drawing.Point(413, 39);
            this.btn_Xoa_QuocTich.Name = "btn_Xoa_QuocTich";
            this.btn_Xoa_QuocTich.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_QuocTich.TabIndex = 10;
            this.btn_Xoa_QuocTich.Text = "Xóa";
            this.btn_Xoa_QuocTich.UseVisualStyleBackColor = true;
            this.btn_Xoa_QuocTich.Click += new System.EventHandler(this.btn_Xoa_QuocTich_Click);
            // 
            // btn_Sua_QuocTich
            // 
            this.btn_Sua_QuocTich.Location = new System.Drawing.Point(494, 39);
            this.btn_Sua_QuocTich.Name = "btn_Sua_QuocTich";
            this.btn_Sua_QuocTich.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_QuocTich.TabIndex = 11;
            this.btn_Sua_QuocTich.Text = "Sửa";
            this.btn_Sua_QuocTich.UseVisualStyleBackColor = true;
            this.btn_Sua_QuocTich.Click += new System.EventHandler(this.btn_Sua_QuocTich_Click);
            // 
            // gridControl_QuocTich
            // 
            this.gridControl_QuocTich.DataSource = this.qUOCTICHBindingSource;
            this.gridControl_QuocTich.Location = new System.Drawing.Point(24, 91);
            this.gridControl_QuocTich.MainView = this.gridView_QuocTich;
            this.gridControl_QuocTich.Name = "gridControl_QuocTich";
            this.gridControl_QuocTich.Size = new System.Drawing.Size(557, 117);
            this.gridControl_QuocTich.TabIndex = 21;
            this.gridControl_QuocTich.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_QuocTich});
            // 
            // gridView7
            // 
            this.gridView7.GridControl = this.gridControl_QuocTich;
            this.gridView7.Name = "gridView7";
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
            // groupBox_QuocTich
            // 
            this.groupBox_QuocTich.Controls.Add(this.gridControl_QuocTich);
            this.groupBox_QuocTich.Controls.Add(this.btn_Sua_QuocTich);
            this.groupBox_QuocTich.Controls.Add(this.btn_Xoa_QuocTich);
            this.groupBox_QuocTich.Controls.Add(this.btn_Them_QuocTich);
            this.groupBox_QuocTich.Controls.Add(this.txt_TenQuocTich);
            this.groupBox_QuocTich.Controls.Add(this.txt_MaQuocTich);
            this.groupBox_QuocTich.Controls.Add(this.label2);
            this.groupBox_QuocTich.Controls.Add(this.label3);
            this.groupBox_QuocTich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_QuocTich.Location = new System.Drawing.Point(693, 15);
            this.groupBox_QuocTich.Name = "groupBox_QuocTich";
            this.groupBox_QuocTich.Size = new System.Drawing.Size(607, 225);
            this.groupBox_QuocTich.TabIndex = 2;
            this.groupBox_QuocTich.TabStop = false;
            this.groupBox_QuocTich.Text = "Quốc tịch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Chức vụ";
            // 
            // txt_MaCV
            // 
            this.txt_MaCV.Location = new System.Drawing.Point(125, 22);
            this.txt_MaCV.Name = "txt_MaCV";
            this.txt_MaCV.Size = new System.Drawing.Size(199, 26);
            this.txt_MaCV.TabIndex = 6;
            // 
            // txt_TenCV
            // 
            this.txt_TenCV.Location = new System.Drawing.Point(125, 56);
            this.txt_TenCV.Name = "txt_TenCV";
            this.txt_TenCV.Size = new System.Drawing.Size(199, 26);
            this.txt_TenCV.TabIndex = 7;
            // 
            // btn_Them_ChucVu
            // 
            this.btn_Them_ChucVu.Location = new System.Drawing.Point(346, 39);
            this.btn_Them_ChucVu.Name = "btn_Them_ChucVu";
            this.btn_Them_ChucVu.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_ChucVu.TabIndex = 8;
            this.btn_Them_ChucVu.Text = "Thêm";
            this.btn_Them_ChucVu.UseVisualStyleBackColor = true;
            this.btn_Them_ChucVu.Click += new System.EventHandler(this.btn_Them_ChucVu_Click);
            // 
            // btn_Xoa_ChucVu
            // 
            this.btn_Xoa_ChucVu.Location = new System.Drawing.Point(427, 39);
            this.btn_Xoa_ChucVu.Name = "btn_Xoa_ChucVu";
            this.btn_Xoa_ChucVu.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_ChucVu.TabIndex = 10;
            this.btn_Xoa_ChucVu.Text = "Xóa";
            this.btn_Xoa_ChucVu.UseVisualStyleBackColor = true;
            this.btn_Xoa_ChucVu.Click += new System.EventHandler(this.btn_Xoa_ChucVu_Click);
            // 
            // btn_Sua_ChucVu
            // 
            this.btn_Sua_ChucVu.Location = new System.Drawing.Point(508, 39);
            this.btn_Sua_ChucVu.Name = "btn_Sua_ChucVu";
            this.btn_Sua_ChucVu.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_ChucVu.TabIndex = 11;
            this.btn_Sua_ChucVu.Text = "Sửa";
            this.btn_Sua_ChucVu.UseVisualStyleBackColor = true;
            this.btn_Sua_ChucVu.Click += new System.EventHandler(this.btn_Sua_ChucVu_Click);
            // 
            // gridControl_ChucVu
            // 
            this.gridControl_ChucVu.DataSource = this.cHUCVUBindingSource;
            this.gridControl_ChucVu.Location = new System.Drawing.Point(26, 91);
            this.gridControl_ChucVu.MainView = this.gridView1;
            this.gridControl_ChucVu.Name = "gridControl_ChucVu";
            this.gridControl_ChucVu.Size = new System.Drawing.Size(568, 217);
            this.gridControl_ChucVu.TabIndex = 22;
            this.gridControl_ChucVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView8
            // 
            this.gridView8.GridControl = this.gridControl_ChucVu;
            this.gridView8.Name = "gridView8";
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
            // groupBox_ChucVu
            // 
            this.groupBox_ChucVu.Controls.Add(this.gridControl_ChucVu);
            this.groupBox_ChucVu.Controls.Add(this.btn_Sua_ChucVu);
            this.groupBox_ChucVu.Controls.Add(this.btn_Xoa_ChucVu);
            this.groupBox_ChucVu.Controls.Add(this.btn_Them_ChucVu);
            this.groupBox_ChucVu.Controls.Add(this.txt_TenCV);
            this.groupBox_ChucVu.Controls.Add(this.txt_MaCV);
            this.groupBox_ChucVu.Controls.Add(this.label5);
            this.groupBox_ChucVu.Controls.Add(this.label6);
            this.groupBox_ChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ChucVu.Location = new System.Drawing.Point(42, 15);
            this.groupBox_ChucVu.Name = "groupBox_ChucVu";
            this.groupBox_ChucVu.Size = new System.Drawing.Size(618, 325);
            this.groupBox_ChucVu.TabIndex = 3;
            this.groupBox_ChucVu.TabStop = false;
            this.groupBox_ChucVu.Text = "Chức vụ - Phòng ban";
            this.groupBox_ChucVu.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btn_Them_PhongBan
            // 
            this.btn_Them_PhongBan.Location = new System.Drawing.Point(357, 69);
            this.btn_Them_PhongBan.Name = "btn_Them_PhongBan";
            this.btn_Them_PhongBan.Size = new System.Drawing.Size(75, 29);
            this.btn_Them_PhongBan.TabIndex = 16;
            this.btn_Them_PhongBan.Text = "Thêm";
            this.btn_Them_PhongBan.UseVisualStyleBackColor = true;
            this.btn_Them_PhongBan.Click += new System.EventHandler(this.btn_Them_PhongBan_Click);
            // 
            // txt_MaPhongBan
            // 
            this.txt_MaPhongBan.Location = new System.Drawing.Point(139, 38);
            this.txt_MaPhongBan.Name = "txt_MaPhongBan";
            this.txt_MaPhongBan.Size = new System.Drawing.Size(199, 26);
            this.txt_MaPhongBan.TabIndex = 14;
            // 
            // btn_Xoa_PhongBan
            // 
            this.btn_Xoa_PhongBan.Location = new System.Drawing.Point(438, 69);
            this.btn_Xoa_PhongBan.Name = "btn_Xoa_PhongBan";
            this.btn_Xoa_PhongBan.Size = new System.Drawing.Size(75, 29);
            this.btn_Xoa_PhongBan.TabIndex = 18;
            this.btn_Xoa_PhongBan.Text = "Xóa";
            this.btn_Xoa_PhongBan.UseVisualStyleBackColor = true;
            this.btn_Xoa_PhongBan.Click += new System.EventHandler(this.btn_Xoa_PhongBan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Phòng ban";
            // 
            // btn_Sua_PhongBan
            // 
            this.btn_Sua_PhongBan.Location = new System.Drawing.Point(519, 69);
            this.btn_Sua_PhongBan.Name = "btn_Sua_PhongBan";
            this.btn_Sua_PhongBan.Size = new System.Drawing.Size(75, 29);
            this.btn_Sua_PhongBan.TabIndex = 19;
            this.btn_Sua_PhongBan.Text = "Sửa";
            this.btn_Sua_PhongBan.UseVisualStyleBackColor = true;
            this.btn_Sua_PhongBan.Click += new System.EventHandler(this.btn_Sua_PhongBan_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mã phòng ban";
            // 
            // txt_TenPhongBan
            // 
            this.txt_TenPhongBan.Location = new System.Drawing.Point(139, 72);
            this.txt_TenPhongBan.Name = "txt_TenPhongBan";
            this.txt_TenPhongBan.Size = new System.Drawing.Size(199, 26);
            this.txt_TenPhongBan.TabIndex = 15;
            // 
            // gridControl_PhongBan
            // 
            this.gridControl_PhongBan.DataSource = this.pHONGBANBindingSource;
            this.gridControl_PhongBan.Location = new System.Drawing.Point(24, 136);
            this.gridControl_PhongBan.MainView = this.gridView_PhongBan;
            this.gridControl_PhongBan.Name = "gridControl_PhongBan";
            this.gridControl_PhongBan.Size = new System.Drawing.Size(570, 204);
            this.gridControl_PhongBan.TabIndex = 25;
            this.gridControl_PhongBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_PhongBan});
            // 
            // gridView9
            // 
            this.gridView9.GridControl = this.gridControl_PhongBan;
            this.gridView9.Name = "gridView9";
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
            // txt_MaTruongPhong
            // 
            this.txt_MaTruongPhong.Location = new System.Drawing.Point(139, 104);
            this.txt_MaTruongPhong.Name = "txt_MaTruongPhong";
            this.txt_MaTruongPhong.Size = new System.Drawing.Size(199, 26);
            this.txt_MaTruongPhong.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Mã trưởng phòng";
            // 
            // groupBox_PhongBan
            // 
            this.groupBox_PhongBan.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.groupBox_PhongBan.Controls.Add(this.label10);
            this.groupBox_PhongBan.Controls.Add(this.txt_MaTruongPhong);
            this.groupBox_PhongBan.Controls.Add(this.gridControl_PhongBan);
            this.groupBox_PhongBan.Controls.Add(this.txt_TenPhongBan);
            this.groupBox_PhongBan.Controls.Add(this.label8);
            this.groupBox_PhongBan.Controls.Add(this.btn_Sua_PhongBan);
            this.groupBox_PhongBan.Controls.Add(this.label7);
            this.groupBox_PhongBan.Controls.Add(this.btn_Xoa_PhongBan);
            this.groupBox_PhongBan.Controls.Add(this.txt_MaPhongBan);
            this.groupBox_PhongBan.Controls.Add(this.btn_Them_PhongBan);
            this.groupBox_PhongBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_PhongBan.Location = new System.Drawing.Point(42, 372);
            this.groupBox_PhongBan.Name = "groupBox_PhongBan";
            this.groupBox_PhongBan.Size = new System.Drawing.Size(618, 357);
            this.groupBox_PhongBan.TabIndex = 4;
            this.groupBox_PhongBan.TabStop = false;
            this.groupBox_PhongBan.Text = "Phòng ban";
            // 
            // frm_NhapLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_PhongBan);
            this.Controls.Add(this.groupBox_ChucVu);
            this.Controls.Add(this.groupBox_QuocTich);
            this.Controls.Add(this.groupBox_TonGiao);
            this.Controls.Add(this.groupBox_DanToc);
            this.Name = "frm_NhapLieu";
            this.Size = new System.Drawing.Size(1370, 752);
            this.Load += new System.EventHandler(this.frm_NhapLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dANTOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetQLNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGIAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUOCTICHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DanToc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DanToc)).EndInit();
            this.groupBox_DanToc.ResumeLayout(false);
            this.groupBox_DanToc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TonGiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TonGiao)).EndInit();
            this.groupBox_TonGiao.ResumeLayout(false);
            this.groupBox_TonGiao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuocTich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_QuocTich)).EndInit();
            this.groupBox_QuocTich.ResumeLayout(false);
            this.groupBox_QuocTich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            this.groupBox_ChucVu.ResumeLayout(false);
            this.groupBox_ChucVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PhongBan)).EndInit();
            this.groupBox_PhongBan.ResumeLayout(false);
            this.groupBox_PhongBan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetQLNS dataSetQLNS;
        private DataSetQLNSTableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        private DataSetQLNSTableAdapters.DANTOCTableAdapter dANTOCTableAdapter;
        private System.Windows.Forms.BindingSource dANTOCBindingSource;
        private DataSetQLNSTableAdapters.TONGIAOTableAdapter tONGIAOTableAdapter;
        private System.Windows.Forms.BindingSource tONGIAOBindingSource;
        private DataSetQLNSTableAdapters.QUOCTICHTableAdapter qUOCTICHTableAdapter;
        private System.Windows.Forms.BindingSource qUOCTICHBindingSource;
        private DataSetQLNSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource;
        private DataSetQLNSTableAdapters.CHUCVUTableAdapter cHUCVUTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.GridControl gridControl_TonGiao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_TonGiao;
        private DevExpress.XtraGrid.Columns.GridColumn colMATONGIAO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTONGIAO;
        private DevExpress.XtraGrid.GridControl gridControl_QuocTich;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_QuocTich;
        private DevExpress.XtraGrid.Columns.GridColumn colMAQUOCTICH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENQUOCTICH;
        private DevExpress.XtraGrid.GridControl gridControl_ChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACHUCVU;
        private DevExpress.XtraGrid.Columns.GridColumn colTENCHUCVU;
        private DevExpress.XtraGrid.GridControl gridControl_PhongBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_PhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONGBAN;
        private DevExpress.XtraGrid.Columns.GridColumn colTENPHONGBAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMATRUONGPHONG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaDanToc;
        private System.Windows.Forms.TextBox txt_TenDanToc;
        private System.Windows.Forms.Button btn_Them_DanToc;
        private System.Windows.Forms.Button btn_Xoa_DanToc;
        private System.Windows.Forms.Button btn_Sua_DanToc;
        private DevExpress.XtraGrid.GridControl gridControl_DanToc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DanToc;
        private DevExpress.XtraGrid.Columns.GridColumn colMADANTOC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENDANTOC;
        private System.Windows.Forms.GroupBox groupBox_DanToc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_MaTonGiao;
        private System.Windows.Forms.TextBox txt_TenTonGiao;
        private System.Windows.Forms.Button btn_Them_TonGiao;
        private System.Windows.Forms.Button btn_Xoa_TonGiao;
        private System.Windows.Forms.Button btn_Sua_TonGiao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private System.Windows.Forms.GroupBox groupBox_TonGiao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaQuocTich;
        private System.Windows.Forms.TextBox txt_TenQuocTich;
        private System.Windows.Forms.Button btn_Them_QuocTich;
        private System.Windows.Forms.Button btn_Xoa_QuocTich;
        private System.Windows.Forms.Button btn_Sua_QuocTich;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private System.Windows.Forms.GroupBox groupBox_QuocTich;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaCV;
        private System.Windows.Forms.TextBox txt_TenCV;
        private System.Windows.Forms.Button btn_Them_ChucVu;
        private System.Windows.Forms.Button btn_Xoa_ChucVu;
        private System.Windows.Forms.Button btn_Sua_ChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private System.Windows.Forms.GroupBox groupBox_ChucVu;
        private System.Windows.Forms.Button btn_Them_PhongBan;
        private System.Windows.Forms.TextBox txt_MaPhongBan;
        private System.Windows.Forms.Button btn_Xoa_PhongBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Sua_PhongBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TenPhongBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private System.Windows.Forms.TextBox txt_MaTruongPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox_PhongBan;
    }
}