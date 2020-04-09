namespace SQLDependency
{
    partial class VatTu
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
            System.Windows.Forms.Label maVTLabel;
            System.Windows.Forms.Label lblSL;
            System.Windows.Forms.Label tenVTLabel;
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.bntGhi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            maVTLabel = new System.Windows.Forms.Label();
            lblSL = new System.Windows.Forms.Label();
            tenVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // maVTLabel
            // 
            maVTLabel.AutoSize = true;
            maVTLabel.Location = new System.Drawing.Point(12, 322);
            maVTLabel.Name = "maVTLabel";
            maVTLabel.Size = new System.Drawing.Size(59, 20);
            maVTLabel.TabIndex = 5;
            maVTLabel.Text = "Ma VT:";
            // 
            // lblSL
            // 
            lblSL.AutoSize = true;
            lblSL.Location = new System.Drawing.Point(458, 325);
            lblSL.Name = "lblSL";
            lblSL.Size = new System.Drawing.Size(82, 20);
            lblSL.TabIndex = 7;
            lblSL.Text = "So Luong:";
            // 
            // tenVTLabel
            // 
            tenVTLabel.AutoSize = true;
            tenVTLabel.Location = new System.Drawing.Point(230, 325);
            tenVTLabel.Name = "tenVTLabel";
            tenVTLabel.Size = new System.Drawing.Size(64, 20);
            tenVTLabel.TabIndex = 9;
            tenVTLabel.Text = "Ten VT:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(755, 81);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 42);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(755, 152);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 42);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // bntGhi
            // 
            this.bntGhi.Location = new System.Drawing.Point(755, 12);
            this.bntGhi.Name = "bntGhi";
            this.bntGhi.Size = new System.Drawing.Size(75, 42);
            this.bntGhi.TabIndex = 1;
            this.bntGhi.Text = "Ghi";
            this.bntGhi.UseVisualStyleBackColor = true;
            this.bntGhi.Click += new System.EventHandler(this.bntGhi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(755, 225);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 42);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaVT
            // 
            this.txtMaVT.Location = new System.Drawing.Point(77, 319);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(100, 26);
            this.txtMaVT.TabIndex = 0;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(546, 322);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 26);
            this.txtSL.TabIndex = 2;
            // 
            // txtTenVT
            // 
            this.txtTenVT.Location = new System.Drawing.Point(300, 322);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(100, 26);
            this.txtTenVT.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(684, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // VatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 434);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(tenVTLabel);
            this.Controls.Add(this.txtTenVT);
            this.Controls.Add(lblSL);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(maVTLabel);
            this.Controls.Add(this.txtMaVT);
            this.Controls.Add(this.bntGhi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "VatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VatTu";
            this.Load += new System.EventHandler(this.VatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button bntGhi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
    }
}