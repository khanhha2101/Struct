using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        public struct sinhvien
        {
            public string hoten117;
            public string msv117;
            public gioitinh gioitinh117;
            public double toan117;
            public double ly117;
            public double hoa117;

            
        };
        public enum gioitinh
        {
            Nam,
            Nu
        };
        public enum hocluc
        {
            Yeu,
            TrungBinh,
            Kha,
            Gioi
        };
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int n117 = int.Parse(Console.ReadLine());
            sinhvien[] sv117 = new sinhvien[n117];
            nhapDS(ref sv117, n117);
            Console.WriteLine("\n\n==========DANH SACH SINH VIEN==========");
            xuatDS(sv117, n117);

            Console.WriteLine("\n==========TIM KIEM SINH VIEN==========");
            Console.Write("Nhap ten sinh vien: ");
            string ht117 = Console.ReadLine();
            timKiem(sv117, n117, ht117);

            Console.ReadLine();
        }

        public static void nhapDS(ref sinhvien[] sv, int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu " + (i + 1));
                Console.Write("Ho ten: ");
                string ht117 = Console.ReadLine();
                Console.Write("Ma sinh vien: ");
                string msv117 = Console.ReadLine();
                Console.Write("Gioi tinh (0: nam  1: nu): ");
                int gt117 = int.Parse(Console.ReadLine());
                Console.Write("Diem toan: ");
                double dt117 = double.Parse(Console.ReadLine());
                Console.Write("Diem ly: ");
                double dl117 = double.Parse(Console.ReadLine());
                Console.Write("Diem hoa: ");
                double dh117 = double.Parse(Console.ReadLine());


                sv[i].hoten117 = ht117;
                sv[i].msv117 = msv117;
                if (gt117 == 0)
                    sv[i].gioitinh117 = gioitinh.Nam;
                else
                    sv[i].gioitinh117 = gioitinh.Nu;
                sv[i].toan117 = dt117;
                sv[i].ly117 = dl117;
                sv[i].hoa117 = dh117;

            }
        }
        public static hocluc diemTB(double toan, double ly, double hoa)
        {
            double dtb = (toan + ly + hoa) / 3;
            if (dtb <= 4)
                return hocluc.Yeu;
            else if (dtb <= 5)
                return hocluc.TrungBinh;
            else if (dtb <= 7)
                return hocluc.Kha;
            else
                return hocluc.Gioi;
        }
        public static void xuatDS(sinhvien[] sv, int n)
        {
            int i = 1;
            foreach(sinhvien item117 in sv)
            {
                Console.WriteLine("----- " + i + " -----");
                Console.WriteLine("Ho ten: " + item117.hoten117);
                Console.WriteLine("Ma sinh vien: " + item117.msv117);
                int gt = (int)item117.gioitinh117;
                if (gt == 0)
                    Console.WriteLine("Gioi tinh: Nam");
                else
                    Console.WriteLine("Gioi tinh: Nữ");
                Console.WriteLine("Diem toan: " + item117.toan117);
                Console.WriteLine("Diem ly: " + item117.ly117);
                Console.WriteLine("Diem hoa: " + item117.hoa117);
                int hocluc = (int)diemTB(item117.toan117, item117.ly117, item117.hoa117);
                switch(hocluc)
                {
                    case 0:
                        Console.WriteLine("Hoc luc: Yeu");
                        break;
                    case 1:
                        Console.WriteLine("Hoc luc: Trung Binh");
                        break;
                    case 2:
                        Console.WriteLine("Hoc luc: Kha");
                        break;
                    case 3:
                        Console.WriteLine("Hoc luc:Gioi");
                        break;

                }

                i++;
            }
        }
        public static void timKiem(sinhvien[] sv, int n, string ht)
        {
            foreach(sinhvien item117 in sv)
            {
                if(item117.hoten117 == ht)
                {
                    Console.WriteLine("Ho ten: " + item117.hoten117);
                    Console.WriteLine("Ma sinh vien: " + item117.msv117);
                    int gt = (int)item117.gioitinh117;
                    if (gt == 0)
                        Console.WriteLine("Gioi tinh: Nam");
                    else
                        Console.WriteLine("Gioi tinh: Nữ");
                    Console.WriteLine("Diem toan: " + item117.toan117);
                    Console.WriteLine("Diem ly: " + item117.ly117);
                    Console.WriteLine("Diem hoa: " + item117.hoa117);
                    int hocluc = (int)diemTB(item117.toan117, item117.ly117, item117.hoa117);
                    switch (hocluc)
                    {
                        case 0:
                            Console.WriteLine("Hoc luc: Yeu");
                            break;
                        case 1:
                            Console.WriteLine("Hoc luc: Trung Binh");
                            break;
                        case 2:
                            Console.WriteLine("Hoc luc: Kha");
                            break;
                        case 3:
                            Console.WriteLine("Hoc luc:Gioi");
                            break;

                    }
                }
            }
        }
    }
}
