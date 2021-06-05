
namespace QuanLyKhachSan
{
    partial class DichVuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DichVuForm));
            this.grcDichVu = new DevExpress.XtraGrid.GridControl();
            this.dichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DichVuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtDvId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grcDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grcDichVu
            // 
            this.grcDichVu.DataSource = this.dichVuBindingSource;
            this.grcDichVu.Location = new System.Drawing.Point(12, 161);
            this.grcDichVu.MainView = this.gridView1;
            this.grcDichVu.Name = "grcDichVu";
            this.grcDichVu.Size = new System.Drawing.Size(508, 200);
            this.grcDichVu.TabIndex = 0;
            this.grcDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dichVuBindingSource
            // 
            this.dichVuBindingSource.DataSource = typeof(QuanLyKhachSan.Models.DichVu);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DichVuId,
            this.TenDV,
            this.GiaTien});
            this.gridView1.GridControl = this.grcDichVu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // DichVuId
            // 
            this.DichVuId.Caption = "DichVuId";
            this.DichVuId.FieldName = "DichVuId";
            this.DichVuId.MinWidth = 25;
            this.DichVuId.Name = "DichVuId";
            this.DichVuId.Visible = true;
            this.DichVuId.VisibleIndex = 0;
            this.DichVuId.Width = 94;
            // 
            // TenDV
            // 
            this.TenDV.Caption = "Tên DV";
            this.TenDV.FieldName = "TenDV";
            this.TenDV.MinWidth = 25;
            this.TenDV.Name = "TenDV";
            this.TenDV.Visible = true;
            this.TenDV.VisibleIndex = 1;
            this.TenDV.Width = 94;
            // 
            // GiaTien
            // 
            this.GiaTien.Caption = "Giá tiền";
            this.GiaTien.FieldName = "GiaTien";
            this.GiaTien.MinWidth = 25;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.Visible = true;
            this.GiaTien.VisibleIndex = 2;
            this.GiaTien.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGiaTien);
            this.panel1.Controls.Add(this.txtTenDV);
            this.panel1.Controls.Add(this.txtDvId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 132);
            this.panel1.TabIndex = 1;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dichVuBindingSource, "GiaTien", true));
            this.txtGiaTien.Location = new System.Drawing.Point(322, 55);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(100, 23);
            this.txtGiaTien.TabIndex = 1;
            // 
            // txtTenDV
            // 
            this.txtTenDV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dichVuBindingSource, "TenDV", true));
            this.txtTenDV.Location = new System.Drawing.Point(121, 97);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(100, 23);
            this.txtTenDV.TabIndex = 1;
            // 
            // txtDvId
            // 
            this.txtDvId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dichVuBindingSource, "DichVuId", true));
            this.txtDvId.Location = new System.Drawing.Point(121, 24);
            this.txtDvId.Name = "txtDvId";
            this.txtDvId.Size = new System.Drawing.Size(100, 23);
            this.txtDvId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên DV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DichVuId";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(212, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(312, 384);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 39);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.ImageOptions.Image")));
            this.btnInsert.Location = new System.Drawing.Point(12, 384);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 39);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(112, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(424, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DichVuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 449);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grcDichVu);
            this.Name = "DichVuForm";
            this.Text = "DichVuForm";
            this.Load += new System.EventHandler(this.DichVuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn DichVuId;
        private DevExpress.XtraGrid.Columns.GridColumn TenDV;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtDvId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.BindingSource dichVuBindingSource;
    }
}