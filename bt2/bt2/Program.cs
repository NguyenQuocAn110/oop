using System;

namespace bt2
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {

                var sv1 = new Student(1, "Nguyen thanh an", 8.5f, 9f);
                var sv2 = new Student(2, "Le van dat", 7.5f, 10f);

                var sv3 = new Student();
                Console.WriteLine("Ma sinh vien: "); sv3.setMasinhvien(int.Parse(Console.ReadLine()));
                Console.WriteLine("Ho va ten: "); sv3.setHovaten(Console.ReadLine());
                Console.WriteLine("Diem thuc hanh: "); sv3.setDiemTH(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Diem li thuyet: "); sv3.setDiemLT(Convert.ToDouble(Console.ReadLine()));
                Student.printtitle();
                sv1.output();
                sv2.output();
                sv3.output();
                Console.WriteLine("-------------------------------");
            }
        }
    }
}