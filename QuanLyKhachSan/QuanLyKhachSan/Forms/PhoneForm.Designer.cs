
namespace QuanLyKhachSan.Forms
{
    partial class PhoneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbNhanVienId = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPhoneId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PhoneId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhanVienId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbNhanVienId);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtPhoneId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 194);
            this.panel1.TabIndex = 0;
            // 
            // cmbNhanVienId
            // 
            this.cmbNhanVienId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.phoneBindingSource, "NhanVienId", true));
            this.cmbNhanVienId.DataSource = this.nhanVienBindingSource;
            this.cmbNhanVienId.DisplayMember = "TenNV";
            this.cmbNhanVienId.FormattingEnabled = true;
            this.cmbNhanVienId.Location = new System.Drawing.Point(351, 38);
            this.cmbNhanVienId.Name = "cmbNhanVienId";
            this.cmbNhanVienId.Size = new System.Drawing.Size(121, 24);
            this.cmbNhanVienId.TabIndex = 2;
            this.cmbNhanVienId.ValueMember = "NhanVienId";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(QuanLyKhachSan.Models.NhanVien);
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "PhoneNumber", true));
            this.txtSDT.Location = new System.Drawing.Point(87, 110);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 23);
            this.txtSDT.TabIndex = 1;
            // 
            // phoneBindingSource
            // 
            this.phoneBindingSource.DataSource = typeof(QuanLyKhachSan.Models.Phone);
            // 
            // txtPhoneId
            // 
            this.txtPhoneId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "PhoneId", true));
            this.txtPhoneId.Location = new System.Drawing.Point(87, 39);
            this.txtPhoneId.Name = "txtPhoneId";
            this.txtPhoneId.Size = new System.Drawing.Size(100, 23);
            this.txtPhoneId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "NhanVienId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "SDT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PhoneId";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.phoneBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(13, 213);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(542, 200);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PhoneId,
            this.PhoneNumber,
            this.NhanVienId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // PhoneId
            // 
            this.PhoneId.Caption = "PhoneId";
            this.PhoneId.FieldName = "PhoneId";
            this.PhoneId.MinWidth = 25;
            this.PhoneId.Name = "PhoneId";
            this.PhoneId.Visible = true;
            this.PhoneId.VisibleIndex = 0;
            this.PhoneId.Width = 94;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Caption = "SDT";
            this.PhoneNumber.FieldName = "PhoneNumber";
            this.PhoneNumber.MinWidth = 25;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Visible = true;
            this.PhoneNumber.VisibleIndex = 1;
            this.PhoneNumber.Width = 94;
            // 
            // NhanVienId
            // 
            this.NhanVienId.Caption = "NhanVienId";
            this.NhanVienId.FieldName = "NhanVienId";
            this.NhanVienId.MinWidth = 25;
            this.NhanVienId.Name = "NhanVienId";
            this.NhanVienId.Visible = true;
            this.NhanVienId.VisibleIndex = 2;
            this.NhanVienId.Width = 94;
            // 
            // btnInsert
            // 
            this.btnInsert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.ImageOptions.Image")));
            this.btnInsert.Location = new System.Drawing.Point(13, 420);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(84, 44);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(113, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 44);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(215, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(464, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 44);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(338, 419);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 44);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // PhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 476);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "PhoneForm";
            this.Text = "PhoneForm";
            this.Load += new System.EventHandler(this.PhoneForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cmbNhanVienId;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.BindingSource phoneBindingSource;
        private System.Windows.Forms.TextBox txtPhoneId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneId;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVienId;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
    }
}