
namespace QuanLyKhachSan
{
    partial class NhanVienForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienForm));
            this.grcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NhanVienId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhomNVId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.LookupNhomNV = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNhomNVId = new System.Windows.Forms.ComboBox();
            this.nhomNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.chkActice = new System.Windows.Forms.CheckBox();
            this.TimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhanVienId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupNhomNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grcNhanVien
            // 
            this.grcNhanVien.DataSource = this.nhanVienBindingSource;
            this.grcNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcNhanVien.Location = new System.Drawing.Point(10, 169);
            this.grcNhanVien.MainView = this.gridView1;
            this.grcNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcNhanVien.Name = "grcNhanVien";
            this.grcNhanVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2,
            this.repositoryItemComboBox1,
            this.LookupNhomNV});
            this.grcNhanVien.Size = new System.Drawing.Size(799, 219);
            this.grcNhanVien.TabIndex = 0;
            this.grcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grcNhanVien.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gridControl1_ViewRegistered);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(QuanLyKhachSan.Models.NhanVien);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NhanVienId,
            this.TenNV,
            this.DiaChi,
            this.NgaySinh,
            this.IsActive,
            this.NhomNVId,
            this.btnDelete,
            this.btnUpdate});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.grcNhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // NhanVienId
            // 
            this.NhanVienId.Caption = "NhanVienId";
            this.NhanVienId.FieldName = "NhanVienId";
            this.NhanVienId.MinWidth = 21;
            this.NhanVienId.Name = "NhanVienId";
            this.NhanVienId.OptionsColumn.ReadOnly = true;
            this.NhanVienId.Visible = true;
            this.NhanVienId.VisibleIndex = 0;
            this.NhanVienId.Width = 81;
            // 
            // TenNV
            // 
            this.TenNV.Caption = "TenNV";
            this.TenNV.FieldName = "TenNV";
            this.TenNV.MinWidth = 21;
            this.TenNV.Name = "TenNV";
            this.TenNV.OptionsColumn.ReadOnly = true;
            this.TenNV.Visible = true;
            this.TenNV.VisibleIndex = 1;
            this.TenNV.Width = 81;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "DiaChi";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MinWidth = 21;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.OptionsColumn.ReadOnly = true;
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 2;
            this.DiaChi.Width = 81;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "NgaySinh";
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.MinWidth = 21;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.OptionsColumn.ReadOnly = true;
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 3;
            this.NgaySinh.Width = 81;
            // 
            // IsActive
            // 
            this.IsActive.Caption = "IsActive";
            this.IsActive.FieldName = "IsActive";
            this.IsActive.MinWidth = 21;
            this.IsActive.Name = "IsActive";
            this.IsActive.OptionsColumn.ReadOnly = true;
            this.IsActive.Visible = true;
            this.IsActive.VisibleIndex = 4;
            this.IsActive.Width = 81;
            // 
            // NhomNVId
            // 
            this.NhomNVId.Caption = "NhomNVId";
            this.NhomNVId.FieldName = "NhomNVId";
            this.NhomNVId.MinWidth = 21;
            this.NhomNVId.Name = "NhomNVId";
            this.NhomNVId.OptionsColumn.ReadOnly = true;
            this.NhomNVId.Visible = true;
            this.NhomNVId.VisibleIndex = 5;
            this.NhomNVId.Width = 81;
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.ColumnEdit = this.repositoryItemButtonEdit1;
            this.btnDelete.MinWidth = 21;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OptionsColumn.ReadOnly = true;
            this.btnDelete.Visible = true;
            this.btnDelete.VisibleIndex = 6;
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
            this.btnUpdate.Caption = "Lưu";
            this.btnUpdate.ColumnEdit = this.repositoryItemButtonEdit2;
            this.btnUpdate.MinWidth = 21;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OptionsColumn.ReadOnly = true;
            this.btnUpdate.Visible = true;
            this.btnUpdate.VisibleIndex = 7;
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
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // LookupNhomNV
            // 
            this.LookupNhomNV.AutoHeight = false;
            this.LookupNhomNV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupNhomNV.Name = "LookupNhomNV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNhomNVId);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.chkActice);
            this.groupBox1.Controls.Add(this.TimeNgaySinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNhanVienId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(799, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbNhomNVId
            // 
            this.cmbNhomNVId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.nhanVienBindingSource, "NhomNV", true));
            this.cmbNhomNVId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nhanVienBindingSource, "NhomNVId", true));
            this.cmbNhomNVId.DataSource = this.nhomNVBindingSource;
            this.cmbNhomNVId.DisplayMember = "TenNhom";
            this.cmbNhomNVId.FormattingEnabled = true;
            this.cmbNhomNVId.Location = new System.Drawing.Point(636, 23);
            this.cmbNhomNVId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNhomNVId.Name = "cmbNhomNVId";
            this.cmbNhomNVId.Size = new System.Drawing.Size(104, 21);
            this.cmbNhomNVId.TabIndex = 5;
            this.cmbNhomNVId.ValueMember = "NhomNVId";
            this.cmbNhomNVId.SelectedIndexChanged += new System.EventHandler(this.cmbNhomNVId_SelectedIndexChanged);
            // 
            // nhomNVBindingSource
            // 
            this.nhomNVBindingSource.DataSource = typeof(QuanLyKhachSan.Models.NhomNV);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(610, 109);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.ImageOptions.Image")));
            this.btnInsert.Location = new System.Drawing.Point(455, 109);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(81, 31);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // chkActice
            // 
            this.chkActice.AutoSize = true;
            this.chkActice.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.nhanVienBindingSource, "IsActive", true));
            this.chkActice.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.nhanVienBindingSource, "IsActive", true));
            this.chkActice.Location = new System.Drawing.Point(280, 89);
            this.chkActice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkActice.Name = "chkActice";
            this.chkActice.Size = new System.Drawing.Size(65, 17);
            this.chkActice.TabIndex = 3;
            this.chkActice.Text = "IsActive";
            this.chkActice.UseVisualStyleBackColor = true;
            // 
            // TimeNgaySinh
            // 
            this.TimeNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienBindingSource, "NgaySinh", true));
            this.TimeNgaySinh.Location = new System.Drawing.Point(335, 43);
            this.TimeNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeNgaySinh.Name = "TimeNgaySinh";
            this.TimeNgaySinh.Size = new System.Drawing.Size(172, 21);
            this.TimeNgaySinh.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "NhomNVId";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DiaChi", true));
            this.txtDiaChi.Location = new System.Drawing.Point(95, 104);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(107, 21);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "NgaySinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DiaChi";
            // 
            // txtTenNV
            // 
            this.txtTenNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TenNV", true));
            this.txtTenNV.Location = new System.Drawing.Point(95, 61);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(107, 21);
            this.txtTenNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TenNV";
            // 
            // txtNhanVienId
            // 
            this.txtNhanVienId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "NhanVienId", true));
            this.txtNhanVienId.Location = new System.Drawing.Point(95, 24);
            this.txtNhanVienId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhanVienId.Name = "txtNhanVienId";
            this.txtNhanVienId.ReadOnly = true;
            this.txtNhanVienId.Size = new System.Drawing.Size(107, 21);
            this.txtNhanVienId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NhanVienId";
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 398);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grcNhanVien);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhanVienForm";
            this.Text = "NhanVienForm";
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupNhomNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVienId;
        private DevExpress.XtraGrid.Columns.GridColumn TenNV;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn IsActive;
        private DevExpress.XtraGrid.Columns.GridColumn NhomNVId;
        private DevExpress.XtraGrid.Columns.GridColumn btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn btnUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private System.Windows.Forms.CheckBox chkActice;
        private System.Windows.Forms.DateTimePicker TimeNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhanVienId;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookupNhomNV;
        private System.Windows.Forms.ComboBox cmbNhomNVId;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.BindingSource nhomNVBindingSource;
    }
}