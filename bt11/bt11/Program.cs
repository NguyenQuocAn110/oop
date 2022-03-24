using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai11
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<HocVien> hocViens = new List<HocVien>();

            int soluongLamLuanVan = 0, soluongThiTotNghiep = 0, soluongThiLai = 0;

            HocVien HV1 = new HocVien("Pham Chi Luu", 1999, 9, 7.5, 8.5, 7, 7.5);
            HocVien HV2 = new HocVien("Nguyen Van Duc", 2003, 8, 8, 7, 9.5, 9);
            HocVien HV3 = new HocVien("Dao Van Anh", 2003, 8.5, 7, 8.5, 6.5, 7);
            HocVien HV4 = new HocVien("Luu Hoang Anh Kiet", 2000, 6.5, 6, 7, 5, 5);
            HocVien HV5 = new HocVien("Huynh Tan Phat", 1999, 4, 5, 7, 8, 9);

            hocViens.Add(HV1);
            hocViens.Add(HV2);
            hocViens.Add(HV3);
            hocViens.Add(HV4);
            hocViens.Add(HV5);

            for (int i = 0; i < hocViens.Count; i++)
            {
                if (hocViens[i].isLamLuanVan() == true) soluongLamLuanVan++;
                else if (hocViens[i].isThiTotNghiep() == true) soluongThiTotNghiep++;
                else soluongThiLai++;
            }
            Console.WriteLine("So luong hoc vien lam luan van = " + soluongLamLuanVan);
            Console.WriteLine("So luong hoc vien dau tot nghiep = " + soluongThiTotNghiep);
            Console.WriteLine("So luong hoc vien thi lai = " + soluongThiLai);
        }
    }
}