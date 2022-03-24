using System;
using System.Collections.Generic;
using System.Text;

namespace bt1_md
{
  public class ChuyenXe
    {
         string masochuyen, hotentaixe, soxe;
        double doanhThu;

        public Chuyenxe()
        {
            this.masochuyen = "";
            this.hotentaixe = "";
            this.soxe = "";
            this.doanhThu = 0;
        }
        public Chuyenxe(string masochuyen, string hotentaixe, string soxe, double doanhThu)
        {
            this.masochuyen = masochuyen;
            this.hotentaixe = hotentaixe;
            this.soxe = soxe;
            this.doanhThu = doanhThu;
        }
        public string getmasochuyen() { return masochuyen; }
        public string gethotentaixe() { return hotentaixe; }
        public string getsoxe() { return soxe; }
        public double getdoanhThu() { return doanhThu; }

        public void setmasochuyen(string masochuyen) { this.masochuyen = masochuyen; }
        public void sethotentaixe(string hotentaixe) { this.hotentaixe = hotentaixe; }
        public void setsoxe(string soxe) { this.soxe = soxe; }
        public void setdoanhThu(double doanhThu) { this.doanhThu = doanhThu; }

      

