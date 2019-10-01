namespace QuanLy_NhanSu
{
    partial class frm_KetNoiCSDL
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
            this.userCtrlConnectDataBase1 = new ThietKeControl_PhungTheHoan.UserCtrlConnectDataBase();
            this.SuspendLayout();
            // 
            // userCtrlConnectDataBase1
            // 
            this.userCtrlConnectDataBase1.Location = new System.Drawing.Point(0, -2);
            this.userCtrlConnectDataBase1.Name = "userCtrlConnectDataBase1";
            this.userCtrlConnectDataBase1.Size = new System.Drawing.Size(493, 189);
            this.userCtrlConnectDataBase1.TabIndex = 0;
            // 
            // frm_KetNoiCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 186);
            this.Controls.Add(this.userCtrlConnectDataBase1);
            this.Name = "frm_KetNoiCSDL";
            this.Text = "frm_KetNoiCSDL";
            this.Load += new System.EventHandler(this.frm_KetNoiCSDL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ThietKeControl_PhungTheHoan.UserCtrlConnectDataBase userCtrlConnectDataBase1;
    }
}