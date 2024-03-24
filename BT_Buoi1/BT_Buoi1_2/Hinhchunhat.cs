using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi1_2
{
    internal class Hinhchunhat
    {
        int dai, rong;

        // Ham khoi tao
        public Hinhchunhat()
        {
            dai = 0;
            rong = 0;
        }
        public Hinhchunhat(int pdai , int prong)
        {
            dai = pdai;
            rong = prong;
        }

        // Tinh chu vi
        public int tinhchuvi() 
        {
            return (dai + rong) * 2;
        }

        // Tinh dien tich
        public int tinhdientich()
        {
            return dai * rong;
        }

        // Tinh duong cheo
        public double tinhduongcheo()
        {
            return Math.Sqrt(Math.Pow(dai,2) + Math.Pow(rong,2)) ;
        }
        // Nhap
        public void nhap()
        {
            Console.WriteLine("Moi ban nhap chieu dai:");
            dai = int.Parse(Console.ReadLine());

            Console.WriteLine("Moi ban nhap chieu rong:");
            rong = int.Parse(Console.ReadLine());

        }

        // Xuat
        public void xuat()
        {
            Console.WriteLine("Chieu dai hinh chu nhat {0}:",dai);

            Console.WriteLine("Chieu rong hinh chu nhat {0}:", rong);

            Console.WriteLine("Chu vi hinh chu nhat {0}:", tinhchuvi());

            Console.WriteLine("Dien tich hinh chu nhat {0}:", tinhdientich());

            Console.WriteLine("Duong cheo hinh chu nhat {0}:", tinhduongcheo());
        }
        public void changesize(int tx, int ty , int kieu)
        {
            if (kieu == 1)
            {
                this.dai += tx;
                this.rong += ty;
            }
            else
            {
                this.dai -= tx;
                this.rong -= ty;
            }
        }
        public void changesize(Hinhchunhat CN, int kieu)
        {
            if (kieu == 1)
            {
                this.dai += CN.dai;
                this.rong += CN.rong;
            }
            else
            {
                this.dai -= CN.dai;
                this.rong -= CN.rong;
            }
        }



    }

}
