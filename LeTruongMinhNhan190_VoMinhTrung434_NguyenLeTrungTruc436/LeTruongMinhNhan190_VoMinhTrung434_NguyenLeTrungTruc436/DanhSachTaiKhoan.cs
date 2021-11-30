using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_LeTruongMinhNhan
{
    class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;

        public static DanhSachTaiKhoan Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DanhSachTaiKhoan();
                }
                return instance;
            }
            set => instance = value;
        }

        List<TaiKhoan> listTaiKhoan;

        public List<TaiKhoan> ListTaiKhoan
        {
            get => listTaiKhoan;
            set => listTaiKhoan = value;
        }

        DanhSachTaiKhoan ()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("minhnhan", "123456"));
            listTaiKhoan.Add(new TaiKhoan("minhtrung", "123456"));
            listTaiKhoan.Add(new TaiKhoan("trungtruc", "123456"));
        }
    }
}
