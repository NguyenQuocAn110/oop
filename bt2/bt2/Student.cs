using System;
using System.Collections.Generic;
using System.Text;

namespace bt2
{
    class Student
    {
        int masinhvien;
        string hovaten;
        double diemTH;
        double diemLT;

        public Student(int masinhvien, string hovaten, double diemTH, double diemLT)
        {
            this.masinhvien = masinhvien;
            this.hovaten = hovaten;
            this.diemTH = diemTH;
            this.diemLT = diemLT;
        }

        public Student()
        {
        }

        public void setMasinhvien(int Newmasinhvien) { if (Newmasinhvien > 0) { this.masinhvien = masinhvien; } else masinhvien = 1; }
        public void setHovaten(string Newhovaten) { this.hovaten = hovaten; }
        public void setDiemTH(double NewdiemTH) { if (NewdiemTH > 0 || diemTH < 10) this.diemTH = diemTH; else diemTH = 0; }
        public void setDiemLT(double NewdiemLT) { if (NewdiemLT > 0 || diemLT < 10) this.diemLT = diemLT; else diemLT = 0; }
        public int getMasinhvien() { return masinhvien; }
        public string getHovaten() { return hovaten; }
        public double getDiemTH() { return diemTH; }
        public double getDiemTL() { return diemLT; }


        public double DiemTB()
        {
            return (diemLT + diemTH) / 2;
        }
        public static void printtitle()
        {
            Console.WriteLine("| {0,-15} | {1,-18} | {2,-12} | {3,-15} | {4,-18} |", "Masinhvien", "Hovaten", "DiemTH", "DiemLT", "DiemTB");

        }
        public void output()
        {
            Console.WriteLine("| {0,-15} | {1,-18} | {2,-12} | {3,-15} | {4,-18} | ", masinhvien, hovaten, diemTH, diemLT, DiemTB());
        }
    }
}
    
