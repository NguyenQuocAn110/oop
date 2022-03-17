using System;
using System.Collections.Generic;
using System.Text;

namespace bt1
{
    class Student
    {
        int x;
        int y;
        string tentoado;

        public Student(string v)
        {
        }

        public Student(String tentoado, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.tentoado = tentoado;
        }
        public void set_X(int x) { this.x = x; }
        public void set_Y(int y) { this.y = y; }
        public void set_Tentoado(string tentoado) { this.tentoado = tentoado; }
        public int get_X() { return x; }
        public int get_Y() { return y; }
        public string get_Tentoado() { return tentoado; }
        public string Tostring()
        {
            return $"{this.tentoado}( {this.x}, {this.y})";
        }
    }
}

 