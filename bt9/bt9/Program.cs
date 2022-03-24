using System;

namespace Bai9
{
    class DanhSachCongNhan
    {
        static void Main(string[] arg)
        {
            List<CongNhan> CongNhanList = new List<CongNhan>();
            int choice;
            do
            {
                ShowMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Input(CongNhanList); break;
                    case 2:
                        CongNhan CN = new CongNhan();
                        CN.Input();
                        int count = 0;
                        for (int i = 0; i < CongNhanList.Count; i++)
                        {
                            if (CongNhanList[i].MaCN == CN.MaCN)
                            {
                                count++;
                                Console.WriteLine("Them vao khong thanh cong!!! Ma bi trung");
                            }
                        }
                        if (count == 0) CongNhanList.Add(CN); break;
                    case 3:
                        Console.WriteLine(string.Format("{0,-10}{1,-10}{2,-10}{3,-10}{4}", "Ma CN", "Ho", "Ten", "So sp", "Luong"));
                        Display(CongNhanList); break;
                    case 4:
                        Console.WriteLine(" So luong Cong Nhan trong List la: {0}", CongNhanList.Count); break;
                    case 5:
                        Console.WriteLine("Danh Sach Cong Nhan lam tren 200 san pham: ");
                        for (int i = 0; i < CongNhanList.Count; i++)
                        {
                            if (CongNhanList[i].SoSP > 200)
                            {
                                Console.WriteLine(CongNhanList[i].toString());
                            }
                        }
                        break;
                    case 6:
                        CongNhan temp = CongNhanList[0];
                        for (int i = 0; i < CongNhanList.Count - 1; i++)
                        {
                            for (int j = i + 1; j < CongNhanList.Count; j++)
                            {
                                if (CongNhanList[i].SoSP < CongNhanList[j].SoSP)
                                {
                                    temp = CongNhanList[j];
                                    CongNhanList[j] = CongNhanList[i];
                                    CongNhanList[i] = temp;
                            
            }
        }

    }
}