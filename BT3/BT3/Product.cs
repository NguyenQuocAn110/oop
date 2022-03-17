using System;
using System.Collections.Generic;
using System.Text;

namespace BT3
{
    class Product
    {
        float ma, mb, mc;

        public Product(float ma, float mb, float mc)
        {
            this.ma = ma;
            this.mb = mb;
            this.mc = mc;
        }

        public Product()
        {
        }

        public void set_ma(float New_ma) { if (New_ma > 0) this.ma = New_ma; else ma = 0; }
        public void set_mb(float New_mb) { if (New_mb > 0) this.mb = New_mb; else mb = 0; }
        public void set_mc(float New_mc) { if (New_mc > 0) this.mc = New_mc; else mc = 0; }
        public float get_ma() { return ma; }
        public float get_mb() { return mb; }
        public float get_mc() { return mc; }

        public float tinhchuvi()
        {
            return ma + mb + mc;
        }
        public double tinhdientich()
        {
            double p = (ma + mb + mc) / 2;
            return Math.Sqrt(p * (p - ma) * (p - mb) * (p - mc));
        }
        public string xetTamgiac()
        {
            if ((ma + mb < mc) || (mb + mc < ma) || (ma + mc < mb))
            {
                return "Khong phai tam giac";
            }
            else if (ma == mb || ma == mc || mb == mc)
            {
                return "Tam giac deu";

            }
            else if ((ma == mb) && (mb == mc) && (mc == ma))
            {
                return "Tam giac can";
            }
            else return "Tam giac thuong";


        }
        public static void printtitle()
        {
            Console.WriteLine("| {0,-15} | {1,-10} | {2,-12} | {3,-15} | {4,-18} | {5,-20} |", "canh a", "canh b", "canh c", "tam giac", "chu vi", "dien tich");
        }
        public void ToString()
        {
            Console.WriteLine("| {0,-15} | {1,-10} | {2,-12} | {3,-15} | {4,-18} | {5,-20} |", ma, mb, mc, xetTamgiac(), tinhchuvi(), tinhdientich());
        }
    }
}
    

