
namespace QuanLyKhachSan
{
    partial class CongViecForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongViecForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.congViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCVId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grcCongViec = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CongViecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.congViecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenCV);
            this.panel1.Controls.Add(this.txtCVId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 140);
            this.panel1.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.ImageOptions.Image")));
            this.btnInsert.Location = new System.Drawing.Point(13, 377);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 42);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(155, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTenCV
            // 
            this.txtTenCV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.congViecBindingSource, "TenCV", true));
            this.txtTenCV.Location = new System.Drawing.Point(126, 83);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(100, 23);
            this.txtTenCV.TabIndex = 1;
            // 
            // congViecBindingSource
            // 
            this.congViecBindingSource.DataSource = typeof(QuanLyKhachSan.Models.CongViec);
            // 
            // txtCVId
            // 
            this.txtCVId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.congViecBindingSource, "CongViecId", true));
            this.txtCVId.Location = new System.Drawing.Point(126, 25);
            this.txtCVId.Name = "txtCVId";
            this.txtCVId.Size = new System.Drawing.Size(100, 23);
            this.txtCVId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên CV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CongViecId";
            // 
            // grcCongViec
            // 
            this.grcCongViec.DataSource = this.congViecBindingSource;
            this.grcCongViec.Location = new System.Drawing.Point(13, 159);
            this.grcCongViec.MainView = this.gridView1;
            this.grcCongViec.Name = "grcCongViec";
            this.grcCongViec.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryDelete,
            this.repositoryUpdate});
            this.grcCongViec.Size = new System.Drawing.Size(386, 212);
            this.grcCongViec.TabIndex = 1;
            this.grcCongViec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CongViecId,
            this.TenCV});
            this.gridView1.GridControl = this.grcCongViec;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // CongViecId
            // 
            this.CongViecId.Caption = "CongViecId";
            this.CongViecId.FieldName = "CongViecId";
            this.CongViecId.MinWidth = 25;
            this.CongViecId.Name = "CongViecId";
            this.CongViecId.Visible = true;
            this.CongViecId.VisibleIndex = 0;
            this.CongViecId.Width = 94;
            // 
            // TenCV
            // 
            this.TenCV.Caption = "TenCV";
            this.TenCV.FieldName = "TenCV";
            this.TenCV.MinWidth = 25;
            this.TenCV.Name = "TenCV";
            this.TenCV.Visible = true;
            this.TenCV.VisibleIndex = 1;
            this.TenCV.Width = 94;
            // 
            // repositoryDelete
            // 
            this.repositoryDelete.AutoHeight = false;
            this.repositoryDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryDelete.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("repositoryDelete.ContextImageOptions.Image")));
            this.repositoryDelete.Name = "repositoryDelete";
            this.repositoryDelete.Click += new System.EventHandler(this.repositoryDelete_Click);
            // 
            // repositoryUpdate
            // 
            this.repositoryUpdate.AutoHeight = false;
            this.repositoryUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryUpdate.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("repositoryUpdate.ContextImageOptions.Image")));
            this.repositoryUpdate.Name = "repositoryUpdate";
            this.repositoryUpdate.Click += new System.EventHandler(this.repositoryUpdate_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 425);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 42);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Xóa";
            this.simpleButton1.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(155, 425);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(100, 42);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Cập nhật";
            this.simpleButton2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(285, 392);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(100, 54);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Hủy";
            this.simpleButton3.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CongViecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 479);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.grcCongViec);
            this.Controls.Add(this.panel1);
            this.Name = "CongViecForm";
            this.Text = "CongViecForm";
            this.Load += new System.EventHandler(this.CongViecForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.congViecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grcCongViec;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.TextBox txtCVId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn CongViecId;
        private DevExpress.XtraGrid.Columns.GridColumn TenCV;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryUpdate;
        private System.Windows.Forms.BindingSource congViecBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}