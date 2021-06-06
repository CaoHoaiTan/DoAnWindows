
namespace QuanLyKhachSan.Form
{
    partial class ThongTinDichVuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinDichVuForm));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDichVuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCongViecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDichVu = new DevExpress.XtraGrid.GridControl();
            this.thongTinDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCongViecId = new System.Windows.Forms.ComboBox();
            this.congViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbDichVuId = new System.Windows.Forms.ComboBox();
            this.dichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinDVBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.congViecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(98, 301);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(365, 301);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(269, 301);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 32);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Visible = false;
            // 
            // btnInsert
            // 
            this.btnInsert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.ImageOptions.Image")));
            this.btnInsert.Location = new System.Drawing.Point(12, 301);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(81, 32);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(184, 301);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 32);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Công việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dịch vụ";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDichVuId,
            this.colCongViecId});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.grcDichVu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colDichVuId
            // 
            this.colDichVuId.FieldName = "DichVuId";
            this.colDichVuId.Name = "colDichVuId";
            this.colDichVuId.Visible = true;
            this.colDichVuId.VisibleIndex = 0;
            // 
            // colCongViecId
            // 
            this.colCongViecId.FieldName = "CongViecId";
            this.colCongViecId.Name = "colCongViecId";
            this.colCongViecId.Visible = true;
            this.colCongViecId.VisibleIndex = 1;
            // 
            // grcDichVu
            // 
            this.grcDichVu.DataSource = this.thongTinDVBindingSource;
            this.grcDichVu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcDichVu.Location = new System.Drawing.Point(12, 120);
            this.grcDichVu.MainView = this.gridView1;
            this.grcDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grcDichVu.Name = "grcDichVu";
            this.grcDichVu.Size = new System.Drawing.Size(435, 162);
            this.grcDichVu.TabIndex = 3;
            this.grcDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // thongTinDVBindingSource
            // 
            this.thongTinDVBindingSource.DataSource = typeof(QuanLyKhachSan.Models.ThongTinDV);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCongViecId);
            this.panel1.Controls.Add(this.cmbDichVuId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 95);
            this.panel1.TabIndex = 4;
            // 
            // cmbCongViecId
            // 
            this.cmbCongViecId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.thongTinDVBindingSource, "CongViecId", true));
            this.cmbCongViecId.DataSource = this.congViecBindingSource;
            this.cmbCongViecId.DisplayMember = "TenCV";
            this.cmbCongViecId.FormattingEnabled = true;
            this.cmbCongViecId.Location = new System.Drawing.Point(103, 59);
            this.cmbCongViecId.Name = "cmbCongViecId";
            this.cmbCongViecId.Size = new System.Drawing.Size(150, 21);
            this.cmbCongViecId.TabIndex = 2;
            this.cmbCongViecId.ValueMember = "CongViecId";
            this.cmbCongViecId.SelectedIndexChanged += new System.EventHandler(this.cmbCongViecId_SelectedIndexChanged);
            this.cmbCongViecId.SelectedValueChanged += new System.EventHandler(this.cmbCongViecId_SelectedIndexChanged);
            // 
            // congViecBindingSource
            // 
            this.congViecBindingSource.DataSource = typeof(QuanLyKhachSan.Models.CongViec);
            // 
            // cmbDichVuId
            // 
            this.cmbDichVuId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.thongTinDVBindingSource, "DichVuId", true));
            this.cmbDichVuId.DataSource = this.dichVuBindingSource;
            this.cmbDichVuId.DisplayMember = "TenDV";
            this.cmbDichVuId.FormattingEnabled = true;
            this.cmbDichVuId.Location = new System.Drawing.Point(103, 20);
            this.cmbDichVuId.Name = "cmbDichVuId";
            this.cmbDichVuId.Size = new System.Drawing.Size(150, 21);
            this.cmbDichVuId.TabIndex = 1;
            this.cmbDichVuId.ValueMember = "DichVuId";
            this.cmbDichVuId.SelectedValueChanged += new System.EventHandler(this.cmbDichVuId_SelectedValueChanged);
            // 
            // dichVuBindingSource
            // 
            this.dichVuBindingSource.DataSource = typeof(QuanLyKhachSan.Models.DichVu);
            // 
            // ThongTinDichVuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 344);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grcDichVu);
            this.Name = "ThongTinDichVuForm";
            this.Text = "ThongTinDichVuForm";
            this.Load += new System.EventHandler(this.ThongTinDichVuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinDVBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.congViecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grcDichVu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn colDichVuId;
        private DevExpress.XtraGrid.Columns.GridColumn colCongViecId;
        private System.Windows.Forms.BindingSource thongTinDVBindingSource;
        private System.Windows.Forms.ComboBox cmbCongViecId;
        private System.Windows.Forms.BindingSource congViecBindingSource;
        private System.Windows.Forms.ComboBox cmbDichVuId;
        private System.Windows.Forms.BindingSource dichVuBindingSource;
    }
}