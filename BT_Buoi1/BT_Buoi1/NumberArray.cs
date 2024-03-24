using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi1
{
    internal class NumberArray
    {
        private List<int> numbers = new List<int>();


        //Khoi tao 1 mang random
        public void TaomangRandom(int count)
        {
            Random random = new Random();
            for (int i = 0; i < count ; i++)
            {
                numbers.Add(random.Next(1, 1000));
            }
        }
        //Xuatmang
        public void Xuatmang()
        {
            Console.WriteLine("Danh sach cac so nguyen ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        //Daomang
        public void Daomang()
        {
            numbers.Reverse();
        }

        // Tim so x
        public bool Timso(int x)
        {
            return numbers.Contains(x);

        }

        // Xuat cac phan tu co 2 chu so
        public List<int> ptu2chuso()
        {
            List<int> ptu2chuso = new List<int>();
            foreach (var number in numbers)
            {
                if (number >= 10 && number <= 99)
                {
                    ptu2chuso.Add(number);
                }
            }
            return ptu2chuso;
        }

        // xuat cac so chan
        public List<int> ptusochan()
        {
            List<int> ptusochan = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 ==0)
                {
                    ptusochan.Add(number);
                }
            }
            return ptusochan;
        }
        // Xuat cac so nguyen to 
        public List<int> ptusont()
        {
            List<int> ptusont = new List<int>();
            foreach (var number in numbers)
            {
                if (checksont(number) == true)
                {
                    ptusont.Add(number);
                }
            }
            return ptusont;
        }
        // Xoa cac phan tu le va boi cua 3
        public void xoacacptlevaboi3()
        {
            List<int> numbersToRemove = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 2 != 0 || number % 3 == 0)
                {
                    numbersToRemove.Add(number);
                }
            }

            foreach (var numberToRemove in numbersToRemove)
            {
                numbers.Remove(numberToRemove);
            }
        }
        // Tang gia tri cua cac so nho hon 2 so lien ke
        public void Tanggiatri1()
        {
            for (int i = 1; i < numbers.Count - 1; i++)
            {
                if (numbers[i] < numbers[i - 1] && numbers[i] < numbers[i + 1])
                {
                    numbers[i]++;
                }
            }
        }

        // Sap xep day so tang dan
        public void SortAscending()
        {
            numbers.Sort();
        }

        // Sap xep day so giam dan dan
        public void SortDescending()
        {
            numbers.Sort();
            numbers.Reverse();
        }

        //Kiem tra so nguyen to
        private bool checksont(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
