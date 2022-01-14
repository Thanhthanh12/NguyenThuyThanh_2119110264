using NhanVien.DAO.NhanVien;
using NhanVien.DTO.NhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien.BLL.NhanVien
{
    public class NhanVienBLL
    {
        NhanVienDAO dao = new NhanVienDAO();
        public List<NhanVienDTO> ReadNhanVien()
        {
            List<NhanVienDTO> lstNV = dao.ReadNhanVien();
            return lstNV;
        }

        public void NewNV(NhanVienDTO nv)
        {
            dao.NewNV(nv);
        }

        public void DeleteNV(NhanVienDTO nv)
        {
            dao.DeleteNV(nv);
        }

        public void EditNV(NhanVienDTO nv)
        {
            dao.EditNV(nv);
        }

    }
}
