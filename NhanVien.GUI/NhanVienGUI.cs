using NhanVien.BLL.NhanVien;
using NhanVien.DTO.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanVien.GUI
{
    public partial class NhanVienGUI : Form
    {
        NhanVienBLL NVBLL = new NhanVienBLL();
        DepartmentBLL depBLL = new DepartmentBLL();
        public NhanVienGUI()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc mún thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbMa.Text = dgvNhanVien.Rows[idx].Cells[0].Value.ToString();
            tbTen.Text = dgvNhanVien.Rows[idx].Cells[1].Value.ToString();

            cbGT.Text = dgvNhanVien.Rows[idx].Cells[3].Value.ToString();
            tbNS.Text = dgvNhanVien.Rows[idx].Cells[4].Value.ToString();
            cbDV.Text = dgvNhanVien.Rows[idx].Cells[5].Value.ToString();

        }

        private void NhanVienGUI_Load(object sender, EventArgs e)
        {
            List<NhanVienDTO> lstNV = NVBLL.ReadNhanVien();
            foreach (NhanVienDTO nv in lstNV)
            {
                dgvNhanVien.Rows.Add(nv.Id, nv.Name, nv.Date, nv.Gender, nv.Placebirth, nv.DepartmentName);
            }
            List<DepartmentDTO> lstDep = depBLL.ReadDepList();
            foreach (DepartmentDTO dep in lstDep)
            {
                cbDV.Items.Add(dep);
            }
            cbDV.DisplayMember = "name";
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            if (tbMa.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMa.Focus();
            }
            else
            {
                nv.Id = tbMa.Text;
                nv.Name = tbTen.Text;
                nv.Date = dtNS.Text;
                nv.Placebirth = tbNS.Text;
                nv.Department = (DepartmentDTO)cbDV.SelectedItem;
                nv.Gender = cbGT.Checked;
                if (cbGT.Checked)
                {
                    nv.Gender = true;
                }
                NVBLL.NewNV(nv);

                dgvNhanVien.Rows.Add(nv.Id, nv.Name, nv.Date, nv.Gender, nv.Placebirth, nv.DepartmentName);


                MessageBox.Show("Đã thêm mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.Id = tbMa.Text;
            nv.Name = tbTen.Text;
            nv.Date = dtNS.Text;
            nv.Placebirth = tbNS.Text;
            nv.Department = (DepartmentDTO)cbDV.SelectedItem;
            NVBLL.DeleteNV(nv);


            DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                int idx = dgvNhanVien.CurrentCell.RowIndex;
                dgvNhanVien.Rows.RemoveAt(idx);
            }
            MessageBox.Show("Đã xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

            NhanVienDTO nv = new NhanVienDTO();
            if (tbMa.Text == "")
            {
                MessageBox.Show("Chưa chọn ô cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMa.Focus();
            }
            else
            {
                nv.Id = tbMa.Text;
                nv.Name = tbTen.Text;
                nv.Date = dtNS.Text;
                nv.Placebirth = tbNS.Text;
                nv.Department = (DepartmentDTO)cbDV.SelectedItem;
                nv.Gender = cbGT.Checked;
                NVBLL.EditNV(nv);
                DataGridViewRow row = dgvNhanVien.CurrentRow;
                row.Cells[0].Value = nv.Id;
                row.Cells[1].Value = nv.Name;
                row.Cells[2].Value = nv.Date;
                row.Cells[4].Value = nv.Placebirth;
                row.Cells[5].Value = nv.DepartmentName;

                if (cbGT.Checked)
                {
                    row.Cells[3].Value = true;

                }
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
