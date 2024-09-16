using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanBaoTrung_Buoi4
{
    internal class SinhVien
    {
        string MSSV;

        
        string hoTen;
       
        string gioiTinh;
       
        DateTime ngaySinh;
        
        string diaChi;
       

        public SinhVien() { }

        public SinhVien(string mSSV, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi)
        {
            MSSV1 = mSSV;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
        }

        public string MSSV1 { get => MSSV; set => MSSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
