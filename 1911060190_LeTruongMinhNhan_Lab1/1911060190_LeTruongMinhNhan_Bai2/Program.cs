using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1911060190_LeTruongMinhNhan_Bai2
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        
            public Student()
        {
            SID = 1;
            TenSV = "Le Truong Minh Nhan";
            Khoa = "CNTT";
            DiemTB = 9;
        }
        public Student(Student stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }

        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        public int StudentID
        {
            get { return SID; }
            set { SID = value; }
        }

        public String Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public String Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }

        public void Nhap1SV()
        {
            Console.Write("Nhap MSV: ");
            SID = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ten: ");
            TenSV = Console.ReadLine();          
            Console.Write("Nhap khoa:");
            Khoa = Console.ReadLine();
            Console.Write("Nhap Diem TB:");
            DiemTB = float.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        
            public void Show()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
            Console.WriteLine("Khoa:{0}", this.Khoa);
            Console.WriteLine("Diem TB:{0}", this.DiemTB);
        }
    }



    struct SinhVien
    {
        int SID;
        string TenSV;
        string Khoa;
        float DiemTB;
    }
    static void NhapDS(ref SinhVien[] ds, ref int n)
    {
        Student sv = new Student();
        Console.Write("Nhap so luong SV:");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("\n ====NHAP DS SINH VIEN====");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap thong tin sinh vien thu {0}", (i + 1));

            sv.Nhap1SV();
        }

    }

    static void XuatDS(SinhVien[] ds, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Thong tin sinh vien thu {0}", (i + 1));
            Console.WriteLine("MSSV {0}", ds[i].SID);
            Console.WriteLine("Ten " + ds[i].TenSV);
            Console.WriteLine("Khoa" + ds[i].Khoa);
            Console.WriteLine("hien diem tring binh" + ds[i].DiemTB);

        }
    }



    class Tester
    {
        
        public static void Main()
        {
            Student ds = new Student();
            int n = 0;
            NhapDS(ref ds, ref n);                    
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            XuatDS(ds,  n);
            ds.Show();
            Console.ReadLine();


        }
    }
}
