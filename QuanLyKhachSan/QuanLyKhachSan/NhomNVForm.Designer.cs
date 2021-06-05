
namespace QuanLyKhachSan
{
    partial class NhomNVForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhomNVForm));
            this.grcNhomNV = new DevExpress.XtraGrid.GridControl();
            this.nhomNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NhomNVId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CongViecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrNhomId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTrNhomId = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCVId = new System.Windows.Forms.ComboBox();
            this.congViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNhomNVId = new System.Windows.Forms.TextBox();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congViecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grcNhomNV
            // 
            this.grcNhomNV.DataSource = this.nhomNVBindingSource;
            this.grcNhomNV.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcNhomNV.Location = new System.Drawing.Point(10, 156);
            this.grcNhomNV.MainView = this.gridView1;
            this.grcNhomNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcNhomNV.Name = "grcNhomNV";
            this.grcNhomNV.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2});
            this.grcNhomNV.Size = new System.Drawing.Size(607, 208);
            this.grcNhomNV.TabIndex = 0;
            this.grcNhomNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nhomNVBindingSource
            // 
            this.nhomNVBindingSource.DataSource = typeof(QuanLyKhachSan.Models.NhomNV);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NhomNVId,
            this.TenNhom,
            this.CongViecId,
            this.TrNhomId,
            this.btnDelete,
            this.btnUpdate});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.grcNhomNV;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // NhomNVId
            // 
            this.NhomNVId.Caption = "NhomNVId";
            this.NhomNVId.FieldName = "NhomNVId";
            this.NhomNVId.MinWidth = 21;
            this.NhomNVId.Name = "NhomNVId";
            this.NhomNVId.Visible = true;
            this.NhomNVId.VisibleIndex = 0;
            this.NhomNVId.Width = 81;
            // 
            // TenNhom
            // 
            this.TenNhom.Caption = "TenNhom";
            this.TenNhom.FieldName = "TenNhom";
            this.TenNhom.MinWidth = 21;
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.Visible = true;
            this.TenNhom.VisibleIndex = 1;
            this.TenNhom.Width = 81;
            // 
            // CongViecId
            // 
            this.CongViecId.Caption = "CongViecId";
            this.CongViecId.FieldName = "CongViecId";
            this.CongViecId.MinWidth = 21;
            this.CongViecId.Name = "CongViecId";
            this.CongViecId.Visible = true;
            this.CongViecId.VisibleIndex = 2;
            this.CongViecId.Width = 81;
            // 
            // TrNhomId
            // 
            this.TrNhomId.Caption = "TrNhomId";
            this.TrNhomId.FieldName = "TrNhomId";
            this.TrNhomId.MinWidth = 21;
            this.TrNhomId.Name = "TrNhomId";
            this.TrNhomId.Visible = true;
            this.TrNhomId.VisibleIndex = 3;
            this.TrNhomId.Width = 81;
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.ColumnEdit = this.repositoryItemButtonEdit1;
            this.btnDelete.MinWidth = 21;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Visible = true;
            this.btnDelete.VisibleIndex = 4;
            this.btnDelete.Width = 81;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.ContextImageOptions.Image")));
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Cập nhật";
            this.btnUpdate.ColumnEdit = this.repositoryItemButtonEdit2;
            this.btnUpdate.MinWidth = 21;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Visible = true;
            this.btnUpdate.VisibleIndex = 5;
            this.btnUpdate.Width = 81;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit2.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit2.ContextImageOptions.Image")));
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.Click += new System.EventHandler(this.repositoryItemButtonEdit2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.cmbTrNhomId);
            this.panel1.Controls.Add(this.cmbCVId);
            this.panel1.Controls.Add(this.txtNhomNVId);
            this.panel1.Controls.Add(this.txtTenNhom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 149);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(477, 123);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 24);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.ImageOptions.Image")));
            this.btnInsert.Location = new System.Drawing.Point(359, 123);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(81, 24);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cmbTrNhomId
            // 
            this.cmbTrNhomId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nhomNVBindingSource, "TrNhomId", true));
            this.cmbTrNhomId.DataSource = this.nhanVienBindingSource;
            this.cmbTrNhomId.DisplayMember = "TenNV";
            this.cmbTrNhomId.FormattingEnabled = true;
            this.cmbTrNhomId.Location = new System.Drawing.Point(359, 18);
            this.cmbTrNhomId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTrNhomId.Name = "cmbTrNhomId";
            this.cmbTrNhomId.Size = new System.Drawing.Size(104, 21);
            this.cmbTrNhomId.TabIndex = 2;
            this.cmbTrNhomId.ValueMember = "NhanVienId";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(QuanLyKhachSan.Models.NhanVien);
            // 
            // cmbCVId
            // 
            this.cmbCVId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nhomNVBindingSource, "CongViecId", true));
            this.cmbCVId.DataSource = this.congViecBindingSource;
            this.cmbCVId.DisplayMember = "TenCV";
            this.cmbCVId.FormattingEnabled = true;
            this.cmbCVId.Location = new System.Drawing.Point(359, 88);
            this.cmbCVId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCVId.Name = "cmbCVId";
            this.cmbCVId.Size = new System.Drawing.Size(104, 21);
            this.cmbCVId.TabIndex = 2;
            this.cmbCVId.ValueMember = "CongViecId";
            // 
            // congViecBindingSource
            // 
            this.congViecBindingSource.DataSource = typeof(QuanLyKhachSan.Models.CongViec);
            // 
            // txtNhomNVId
            // 
            this.txtNhomNVId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhomNVBindingSource, "NhomNVId", true));
            this.txtNhomNVId.Location = new System.Drawing.Point(126, 19);
            this.txtNhomNVId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhomNVId.Name = "txtNhomNVId";
            this.txtNhomNVId.ReadOnly = true;
            this.txtNhomNVId.Size = new System.Drawing.Size(86, 21);
            this.txtNhomNVId.TabIndex = 1;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhomNVBindingSource, "TenNhom", true));
            this.txtTenNhom.Location = new System.Drawing.Point(126, 88);
            this.txtTenNhom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(86, 21);
            this.txtTenNhom.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Công việc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "NhomNVId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trưởng nhóm";
            // 
            // NhomNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grcNhomNV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhomNVForm";
            this.Text = "NhomNVForm";
            this.Load += new System.EventHandler(this.NhomNVForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congViecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcNhomNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NhomNVId;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn CongViecId;
        private DevExpress.XtraGrid.Columns.GridColumn TrNhomId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTrNhomId;
        private System.Windows.Forms.ComboBox cmbCVId;
        private System.Windows.Forms.TextBox txtNhomNVId;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraGrid.Columns.GridColumn btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn btnUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.BindingSource nhomNVBindingSource;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.BindingSource congViecBindingSource;
    }
}