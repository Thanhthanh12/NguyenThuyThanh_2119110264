using NhanVien.DAO.NhanVien;
using NhanVien.DTO.NhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien.BLL.NhanVien
{
    public class DepartmentBLL
    {
        DepartmentDAO dal = new DepartmentDAO();
        public List<DepartmentDTO> ReadDepList()
        {
            List<DepartmentDTO> lstDep = dal.ReadDepList();
            return lstDep;
        }
    }
}
