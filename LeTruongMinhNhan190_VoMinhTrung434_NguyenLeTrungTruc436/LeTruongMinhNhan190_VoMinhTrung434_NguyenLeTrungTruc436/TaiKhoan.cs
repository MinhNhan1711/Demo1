using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_LeTruongMinhNhan
{
    class TaiKhoan
    {
        private string tenTaiKhoan;

        public string TenTaiKhoan
        {
            get => tenTaiKhoan;
            set => tenTaiKhoan = value;

        }

        private string matKhau;

        public string MatKhau
        {
            get => matKhau;
            set => matKhau = value;
        }

        public TaiKhoan (string TaiKhoan, String MatKhau)
        {
            this.TenTaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
        }
    }
}
