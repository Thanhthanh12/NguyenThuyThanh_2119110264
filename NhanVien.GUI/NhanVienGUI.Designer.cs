
namespace NhanVien.GUI
{
    partial class NhanVienGUI
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
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDV = new System.Windows.Forms.ComboBox();
            this.dtNS = new System.Windows.Forms.DateTimePicker();
            this.tbNS = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.cbGT = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(389, 475);
            this.btNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(156, 38);
            this.btNew.TabIndex = 68;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(554, 475);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(156, 38);
            this.btDelete.TabIndex = 67;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(719, 475);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(156, 38);
            this.btEdit.TabIndex = 66;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(886, 475);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(156, 38);
            this.btExit.TabIndex = 65;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvNhanVien.Location = new System.Drawing.Point(26, 108);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1016, 338);
            this.dgvNhanVien.TabIndex = 64;
            this.dgvNhanVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdEmployee";
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateBirth";
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Gender";
            this.Column4.HeaderText = "Giới Tính";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PlaceBirth";
            this.Column5.HeaderText = "Nơi Sinh";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "IdDepartment";
            this.Column6.HeaderText = "Đơn Vị";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // cbDV
            // 
            this.cbDV.FormattingEnabled = true;
            this.cbDV.Location = new System.Drawing.Point(84, 62);
            this.cbDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDV.Name = "cbDV";
            this.cbDV.Size = new System.Drawing.Size(174, 28);
            this.cbDV.TabIndex = 63;
            // 
            // dtNS
            // 
            this.dtNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNS.Location = new System.Drawing.Point(704, 20);
            this.dtNS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtNS.Name = "dtNS";
            this.dtNS.Size = new System.Drawing.Size(193, 26);
            this.dtNS.TabIndex = 62;
            // 
            // tbNS
            // 
            this.tbNS.Location = new System.Drawing.Point(344, 62);
            this.tbNS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNS.Name = "tbNS";
            this.tbNS.Size = new System.Drawing.Size(696, 26);
            this.tbNS.TabIndex = 61;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(344, 15);
            this.tbTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(256, 26);
            this.tbTen.TabIndex = 60;
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(84, 17);
            this.tbMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(175, 26);
            this.tbMa.TabIndex = 59;
            // 
            // cbGT
            // 
            this.cbGT.AutoSize = true;
            this.cbGT.Location = new System.Drawing.Point(908, 22);
            this.cbGT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(128, 24);
            this.cbGT.TabIndex = 58;
            this.cbGT.Text = "Giới tính nam";
            this.cbGT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Đơn vị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Nơi sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Họ Tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Mã";
            // 
            // NhanVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 549);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.cbDV);
            this.Controls.Add(this.dtNS);
            this.Controls.Add(this.tbNS);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.cbGT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "NhanVienGUI";
            this.Text = "NhanVienGUI";
            this.Load += new System.EventHandler(this.NhanVienGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox cbDV;
        private System.Windows.Forms.DateTimePicker dtNS;
        private System.Windows.Forms.TextBox tbNS;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.CheckBox cbGT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}