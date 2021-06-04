
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NhomNVId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CongViecId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrNhomId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 192);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(690, 244);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NhomNVId,
            this.TenNhom,
            this.CongViecId,
            this.TrNhomId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // NhomNVId
            // 
            this.NhomNVId.Caption = "NhomNVId";
            this.NhomNVId.FieldName = "NhomNVId";
            this.NhomNVId.MinWidth = 25;
            this.NhomNVId.Name = "NhomNVId";
            this.NhomNVId.Visible = true;
            this.NhomNVId.VisibleIndex = 0;
            this.NhomNVId.Width = 94;
            // 
            // TenNhom
            // 
            this.TenNhom.Caption = "TenNhom";
            this.TenNhom.FieldName = "TenNhom";
            this.TenNhom.MinWidth = 25;
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.Visible = true;
            this.TenNhom.VisibleIndex = 1;
            this.TenNhom.Width = 94;
            // 
            // CongViecId
            // 
            this.CongViecId.Caption = "CongViecId";
            this.CongViecId.FieldName = "CongViecId";
            this.CongViecId.MinWidth = 25;
            this.CongViecId.Name = "CongViecId";
            this.CongViecId.Visible = true;
            this.CongViecId.VisibleIndex = 2;
            this.CongViecId.Width = 94;
            // 
            // TrNhomId
            // 
            this.TrNhomId.Caption = "TrNhomId";
            this.TrNhomId.FieldName = "TrNhomId";
            this.TrNhomId.MinWidth = 25;
            this.TrNhomId.Name = "TrNhomId";
            this.TrNhomId.Visible = true;
            this.TrNhomId.VisibleIndex = 3;
            this.TrNhomId.Width = 94;
            // 
            // NhomNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 467);
            this.Controls.Add(this.gridControl1);
            this.Name = "NhomNVForm";
            this.Text = "NhomNVForm";
            this.Load += new System.EventHandler(this.NhomNVForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NhomNVId;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn CongViecId;
        private DevExpress.XtraGrid.Columns.GridColumn TrNhomId;
    }
}