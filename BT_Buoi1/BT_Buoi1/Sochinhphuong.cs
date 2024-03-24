using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi1
{
    internal class Sochinhphuong
    {
        int square_num;

        public int Square_num { get => square_num; set => square_num = value; }
        public bool checkscp(int n)
        {
            int sqrtN = (int)Math.Sqrt(n);
            return sqrtN * sqrtN == n;
        }

        public void nhap()
        {
            int n;
            while (true)
            {
                Console.Write("Nhap 1 so chinh phuong: ");
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    if (checkscp(n))
                    {
                        Square_num = n;
                        break;
                    }
                    else
                        Console.WriteLine("So ban nhap khong phai so chinh phuong. Vui long nhap lai.");
                }
                else
                {
                    Console.WriteLine("Vui long nhap 1 so nguyen duong.");
                }
            }
        }
        public void xuat()
        {
            Console.WriteLine("So chinh phuong ban vua nhap la:  ");
            Console.WriteLine(square_num);
        }

    }
}
